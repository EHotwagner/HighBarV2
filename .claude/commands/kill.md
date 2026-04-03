Kill all stale HighBarV2 engine and test processes.

Run the following commands and report what was killed:

1. Find and kill any `spring-headless`, `spring-dedicated`, or `recoil-main` processes:
   ```bash
   pkill -9 -f "spring-headless|spring-dedicated|recoil-main" 2>/dev/null
   ```

2. Check for any process holding UDP port 8452 (engine autohost port) and kill it:
   ```bash
   ss -ulnp | grep 8452
   ```
   If found, extract the PID and `kill -9` it.

3. Clean up stale socket files:
   ```bash
   rm -f /tmp/highbar-test-*.sock /tmp/highbar-test-*.sock.pid
   rm -f /tmp/hb-test*.sock /tmp/hb*.sock
   ```

4. Verify everything is clean:
   ```bash
   pgrep -a "spring|recoil" || echo "No engine processes"
   ss -ulnp | grep 8452 || echo "Port 8452 free"
   ls /tmp/highbar-test-*.sock 2>/dev/null || echo "No stale sockets"
   ```

Report a summary of what was found and killed.
