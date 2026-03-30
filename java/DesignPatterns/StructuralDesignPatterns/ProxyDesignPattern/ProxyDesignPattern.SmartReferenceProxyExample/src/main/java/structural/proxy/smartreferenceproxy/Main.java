package structural.proxy.smartreferenceproxy;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== SMART REFERENCE PROXY PATTERN DEMO ===\n");

        DatabaseConnectionProxy connection = new DatabaseConnectionProxy();
        System.out.println();

        System.out.println("--- Client 1 executes query ---\n");
        connection.executeQuery("SELECT * FROM Users");
        System.out.println();

        System.out.println("--- Client 2 adds reference ---\n");
        connection.addReference();
        System.out.println();

        System.out.println("--- Client 2 executes query ---\n");
        connection.executeQuery("SELECT * FROM Orders");
        System.out.println();

        System.out.println("--- Client 3 adds reference ---\n");
        connection.addReference();
        System.out.println();

        System.out.println("--- Client 1 releases reference ---\n");
        connection.releaseReference();
        System.out.println();

        connection.printStatistics();
        System.out.println();

        System.out.println("--- Client 2 releases reference ---\n");
        connection.releaseReference();
        System.out.println();

        System.out.println("--- Client 3 releases reference (last one - triggers auto-close) ---\n");
        connection.releaseReference();

        System.out.println("\n=== SUMMARY ===");
        System.out.println("Smart Proxy tracked all references and access.");
        System.out.println("Connection was auto-closed when last reference was released.");
    }
}
