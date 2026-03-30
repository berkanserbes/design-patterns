package structural.proxy.smartreferenceproxy;

import java.util.UUID;

public class RealDatabaseConnection implements IDatabaseConnection {
    private final String connectionId;
    private boolean closed;

    public RealDatabaseConnection() {
        connectionId = UUID.randomUUID().toString().substring(0, 8).toUpperCase();
        System.out.println("[Connection-" + connectionId + "] Database connection opened");
    }

    @Override
    public void executeQuery(String query) {
        if (closed) throw new IllegalStateException("Connection is closed");
        System.out.println("[Connection-" + connectionId + "] Executing: " + query);
        try { Thread.sleep(100); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        System.out.println("[Connection-" + connectionId + "] Query completed");
    }

    @Override
    public void close() {
        if (!closed) {
            closed = true;
            System.out.println("[Connection-" + connectionId + "] Connection closed");
        }
    }
}
