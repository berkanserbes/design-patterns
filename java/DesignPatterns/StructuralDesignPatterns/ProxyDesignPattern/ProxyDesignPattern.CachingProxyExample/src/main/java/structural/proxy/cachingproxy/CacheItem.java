package structural.proxy.cachingproxy;

import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;

public class CacheItem {
    private final String value;
    private final LocalDateTime expiresAt;

    public CacheItem(String value, long ttlSeconds) {
        this.value = value;
        this.expiresAt = LocalDateTime.now().plusSeconds(ttlSeconds);
    }

    public String getValue() { return value; }
    public boolean isExpired() { return LocalDateTime.now().isAfter(expiresAt); }
    public long secondsUntilExpiry() { return ChronoUnit.SECONDS.between(LocalDateTime.now(), expiresAt); }
}
