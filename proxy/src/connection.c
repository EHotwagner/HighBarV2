#include "highbar/connection.h"

#include <errno.h>
#include <signal.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <poll.h>

void hb_conn_init(HB_Connection *conn, HB_Config *config) {
    conn->fd = -1;
    conn->connected = false;
    conn->config = config;
    conn->recording = false;
    conn->record_fd = -1;
}

int hb_conn_connect(HB_Connection *conn) {
    // Ignore SIGPIPE so send() returns EPIPE instead of killing us
    signal(SIGPIPE, SIG_IGN);

    int fd;
    if (conn->config->transport == HB_TRANSPORT_TCP) {
        fd = socket(AF_INET, SOCK_STREAM, 0);
        if (fd < 0) return -1;

        struct sockaddr_in addr;
        memset(&addr, 0, sizeof(addr));
        addr.sin_family = AF_INET;
        addr.sin_port = htons(conn->config->tcp_port);
        addr.sin_addr.s_addr = htonl(INADDR_LOOPBACK);

        if (connect(fd, (struct sockaddr *)&addr, sizeof(addr)) < 0) {
            close(fd);
            return -1;
        }
    } else {
        fd = socket(AF_UNIX, SOCK_STREAM, 0);
        if (fd < 0) return -1;

        struct sockaddr_un addr;
        memset(&addr, 0, sizeof(addr));
        addr.sun_family = AF_UNIX;
        size_t path_len = strlen(conn->config->socket_path);
        if (path_len >= sizeof(addr.sun_path)) {
            close(fd);
            return -1;
        }
        memcpy(addr.sun_path, conn->config->socket_path, path_len + 1);

        if (connect(fd, (struct sockaddr *)&addr, sizeof(addr)) < 0) {
            close(fd);
            return -1;
        }
    }

    conn->fd = fd;
    conn->connected = true;
    return 0;
}

void hb_conn_close(HB_Connection *conn) {
    if (conn->fd >= 0) {
        close(conn->fd);
        conn->fd = -1;
    }
    conn->connected = false;
    if (conn->recording && conn->record_fd >= 0) {
        close(conn->record_fd);
        conn->record_fd = -1;
        conn->recording = false;
    }
}

// Write exactly n bytes, handling partial writes.
static int write_all(int fd, const uint8_t *buf, size_t n) {
    size_t written = 0;
    while (written < n) {
        ssize_t r = write(fd, buf + written, n - written);
        if (r < 0) {
            if (errno == EINTR) continue;
            return -1;
        }
        written += (size_t)r;
    }
    return 0;
}

// Read exactly n bytes, handling partial reads. Uses poll for timeout.
static int read_all(int fd, uint8_t *buf, size_t n, uint32_t timeout_ms) {
    size_t total = 0;
    while (total < n) {
        struct pollfd pfd = { .fd = fd, .events = POLLIN };
        int pr = poll(&pfd, 1, (int)timeout_ms);
        if (pr == 0) return -2; // timeout
        if (pr < 0) {
            if (errno == EINTR) continue;
            return -1;
        }
        ssize_t r = read(fd, buf + total, n - total);
        if (r <= 0) {
            if (r < 0 && errno == EINTR) continue;
            return -1;
        }
        total += (size_t)r;
    }
    return 0;
}

static void record_message(HB_Connection *conn, uint8_t direction,
                           const uint8_t *data, uint32_t len) {
    if (!conn->recording || conn->record_fd < 0) return;
    // Record format: [1 byte direction][4 bytes LE length][payload]
    write(conn->record_fd, &direction, 1);
    uint8_t len_buf[4];
    len_buf[0] = (uint8_t)(len & 0xFF);
    len_buf[1] = (uint8_t)((len >> 8) & 0xFF);
    len_buf[2] = (uint8_t)((len >> 16) & 0xFF);
    len_buf[3] = (uint8_t)((len >> 24) & 0xFF);
    write(conn->record_fd, len_buf, 4);
    write(conn->record_fd, data, len);
}

int hb_conn_send(HB_Connection *conn, const uint8_t *data, uint32_t len) {
    if (!conn->connected || conn->fd < 0) return -1;

    // Validate message size
    if (len > conn->config->max_message_size) return -1;

    // 4-byte little-endian length prefix
    uint8_t header[4];
    header[0] = (uint8_t)(len & 0xFF);
    header[1] = (uint8_t)((len >> 8) & 0xFF);
    header[2] = (uint8_t)((len >> 16) & 0xFF);
    header[3] = (uint8_t)((len >> 24) & 0xFF);

    if (write_all(conn->fd, header, 4) != 0) {
        conn->connected = false;
        return -1;
    }
    if (write_all(conn->fd, data, len) != 0) {
        conn->connected = false;
        return -1;
    }

    record_message(conn, 0, data, len); // 0 = sent
    return 0;
}

int hb_conn_recv(HB_Connection *conn, uint8_t **out_data, uint32_t *out_len,
                 uint32_t timeout_ms) {
    if (!conn->connected || conn->fd < 0) return -1;

    if (timeout_ms == 0) timeout_ms = conn->config->timeout_ms;

    // Read 4-byte length header
    uint8_t header[4];
    int rc = read_all(conn->fd, header, 4, timeout_ms);
    if (rc != 0) {
        if (rc == -1) conn->connected = false;
        return rc;
    }

    uint32_t len = (uint32_t)header[0]
                 | ((uint32_t)header[1] << 8)
                 | ((uint32_t)header[2] << 16)
                 | ((uint32_t)header[3] << 24);

    if (len > conn->config->max_message_size) {
        conn->connected = false;
        return -1;
    }

    uint8_t *data = (uint8_t *)malloc(len);
    if (!data) return -1;

    rc = read_all(conn->fd, data, len, timeout_ms);
    if (rc != 0) {
        free(data);
        if (rc == -1) conn->connected = false;
        return rc;
    }

    record_message(conn, 1, data, len); // 1 = received

    *out_data = data;
    *out_len = len;
    return 0;
}

bool hb_conn_is_writable(HB_Connection *conn) {
    if (!conn->connected || conn->fd < 0) return false;
    struct pollfd pfd = { .fd = conn->fd, .events = POLLOUT };
    int r = poll(&pfd, 1, 0);
    return (r > 0 && (pfd.revents & POLLOUT));
}

void hb_conn_enable_recording(HB_Connection *conn, int record_fd) {
    conn->recording = true;
    conn->record_fd = record_fd;
}

void hb_conn_disable_recording(HB_Connection *conn) {
    conn->recording = false;
    conn->record_fd = -1;
}
