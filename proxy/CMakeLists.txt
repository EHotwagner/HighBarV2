cmake_minimum_required(VERSION 3.20)
project(HighBarV2 C)

set(CMAKE_C_STANDARD 11)
set(CMAKE_C_STANDARD_REQUIRED ON)
set(CMAKE_POSITION_INDEPENDENT_CODE ON)

# The real Recoil engine headers (AISCommands.h, AISEvents.h) define
# 'const int NUM_CMD_TOPICS' and 'const int NUM_EVENTS' at file scope,
# which in C has external linkage and produces a definition in every TU
# that includes them. Tell the linker to tolerate these duplicates.
add_link_options("LINKER:--allow-multiple-definition")

# Find protobuf-c
find_package(PkgConfig REQUIRED)
pkg_check_modules(PROTOBUF_C REQUIRED libprotobuf-c)

# Proto generated sources directory
set(PROTO_GEN_DIR "${CMAKE_SOURCE_DIR}/../proto/gen/c")

# Collect generated protobuf sources
file(GLOB PROTO_SOURCES "${PROTO_GEN_DIR}/highbar/*.pb-c.c")
file(GLOB PROTO_HEADERS "${PROTO_GEN_DIR}/highbar/*.pb-c.h")

# Proxy library sources
set(PROXY_SOURCES
    src/arena.c
    src/config.c
    src/connection.c
    src/serialize.c
    src/deserialize.c
    src/callbacks.c
    src/proxy.c
)

# Shared library target
add_library(SkirmishAI SHARED ${PROXY_SOURCES} ${PROTO_SOURCES})

target_include_directories(SkirmishAI PRIVATE
    ${CMAKE_CURRENT_SOURCE_DIR}/include
    ${PROTO_GEN_DIR}
    ${PROTOBUF_C_INCLUDE_DIRS}
)

target_link_libraries(SkirmishAI PRIVATE
    ${PROTOBUF_C_LIBRARIES}
)

target_compile_options(SkirmishAI PRIVATE
    -Wall -Wextra -Wpedantic -Werror
    ${PROTOBUF_C_CFLAGS_OTHER}
)

# Install target
install(TARGETS SkirmishAI LIBRARY DESTINATION lib)

# Tests
enable_testing()

add_executable(test_serialize tests/test_serialize.c tests/mock_engine.c ${PROTO_SOURCES})
target_include_directories(test_serialize PRIVATE
    ${CMAKE_CURRENT_SOURCE_DIR}/include
    ${PROTO_GEN_DIR}
    ${PROTOBUF_C_INCLUDE_DIRS}
)
target_link_libraries(test_serialize PRIVATE SkirmishAI ${PROTOBUF_C_LIBRARIES})
add_test(NAME test_serialize COMMAND test_serialize)

add_executable(test_deserialize tests/test_deserialize.c tests/mock_engine.c ${PROTO_SOURCES})
target_include_directories(test_deserialize PRIVATE
    ${CMAKE_CURRENT_SOURCE_DIR}/include
    ${PROTO_GEN_DIR}
    ${PROTOBUF_C_INCLUDE_DIRS}
)
target_link_libraries(test_deserialize PRIVATE SkirmishAI ${PROTOBUF_C_LIBRARIES})
add_test(NAME test_deserialize COMMAND test_deserialize)

add_executable(test_roundtrip tests/test_roundtrip.c tests/mock_engine.c ${PROTO_SOURCES})
target_include_directories(test_roundtrip PRIVATE
    ${CMAKE_CURRENT_SOURCE_DIR}/include
    ${PROTO_GEN_DIR}
    ${PROTOBUF_C_INCLUDE_DIRS}
)
target_link_libraries(test_roundtrip PRIVATE SkirmishAI ${PROTOBUF_C_LIBRARIES})
add_test(NAME test_roundtrip COMMAND test_roundtrip)

add_executable(test_callbacks tests/test_callbacks.c tests/mock_engine.c ${PROTO_SOURCES})
target_include_directories(test_callbacks PRIVATE
    ${CMAKE_CURRENT_SOURCE_DIR}/include
    ${PROTO_GEN_DIR}
    ${PROTOBUF_C_INCLUDE_DIRS}
)
target_link_libraries(test_callbacks PRIVATE SkirmishAI ${PROTOBUF_C_LIBRARIES})
add_test(NAME test_callbacks COMMAND test_callbacks)
