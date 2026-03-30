package structural.proxy.smartreferenceproxy;

public interface IDatabaseConnection {
    void executeQuery(String query);
    void close();
}
