package structural.proxy.smartreferenceproxy;

import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.UUID;

public class DatabaseConnectionProxy implements IDatabaseConnection {
    private final RealDatabaseConnection realConnection;
    private final String proxyId;
    private int referenceCount;
    private int queryCount;
    private LocalTime lastAccessTime;
    private boolean closed;

    public DatabaseConnectionProxy() {
        proxyId = UUID.randomUUID().toString().substring(0, 4).toUpperCase();
        realConnection = new RealDatabaseConnection();
        referenceCount = 1;
        lastAccessTime = LocalTime.now();
        System.out.println("[Proxy-" + proxyId + "] Smart proxy created. Reference count: " + referenceCount);
    }

    public void addReference() {
        referenceCount++;
        System.out.println("[Proxy-" + proxyId + "] Reference added. Count: " + referenceCount);
    }

    public void releaseReference() {
        referenceCount--;
        System.out.println("[Proxy-" + proxyId + "] Reference released. Count: " + referenceCount);
        if (referenceCount <= 0) {
            System.out.println("[Proxy-" + proxyId + "] No more references - auto-closing connection");
            close();
        }
    }

    @Override
    public void executeQuery(String query) {
        if (closed) throw new IllegalStateException("Connection is closed");
        queryCount++;
        lastAccessTime = LocalTime.now();
        System.out.println("[Proxy-" + proxyId + "] Query #" + queryCount + " at " +
            lastAccessTime.format(DateTimeFormatter.ofPattern("HH:mm:ss")));
        realConnection.executeQuery(query);
    }

    @Override
    public void close() {
        if (!closed) {
            closed = true;
            realConnection.close();
            System.out.println("[Proxy-" + proxyId + "] Statistics: " + queryCount + " queries executed");
        }
    }

    public void printStatistics() {
        System.out.println("\n[Proxy-" + proxyId + "] --- Statistics ---");
        System.out.println("[Proxy-" + proxyId + "] Reference Count: " + referenceCount);
        System.out.println("[Proxy-" + proxyId + "] Queries Executed: " + queryCount);
        System.out.println("[Proxy-" + proxyId + "] Last Access: " +
            (lastAccessTime != null ? lastAccessTime.format(DateTimeFormatter.ofPattern("HH:mm:ss")) : "N/A"));
        System.out.println("[Proxy-" + proxyId + "] Is Closed: " + closed);
    }
}
