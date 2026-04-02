#ifndef HIGHBAR_CONNECTION_H
#define HIGHBAR_CONNECTION_H

#include <stddef.h>
#include <stdint.h>
#include <stdbool.h>
#include "highbar/config.h"

typedef struct {
    int fd;
    bool connected;
    HB_Config *config;
    bool recording;
    int record_fd;
} HB_Connection;

// Initialize connection structure (does not connect).
void hb_conn_init(HB_Connection *conn, HB_Config *config);

// Connect to the AI process via Unix domain socket or TCP loopback.
// Returns 0 on success.
int hb_conn_connect(HB_Connection *conn);

// Close connection and clean up.
void hb_conn_close(HB_Connection *conn);

// Send a length-prefixed message. Returns 0 on success.
// Message format: [4 bytes LE length][payload]
int hb_conn_send(HB_Connection *conn, const uint8_t *data, uint32_t len);

// Receive a length-prefixed message. Caller must free *out_data.
// Returns 0 on success, -1 on error, -2 on timeout.
// timeout_ms: max time to wait (0 = use config default).
int hb_conn_recv(HB_Connection *conn, uint8_t **out_data, uint32_t *out_len,
                 uint32_t timeout_ms);

// Check if socket is writable (non-blocking check for backpressure).
bool hb_conn_is_writable(HB_Connection *conn);

// Enable replay recording to a file descriptor.
void hb_conn_enable_recording(HB_Connection *conn, int record_fd);

// Disable replay recording.
void hb_conn_disable_recording(HB_Connection *conn);

#endif // HIGHBAR_CONNECTION_H
