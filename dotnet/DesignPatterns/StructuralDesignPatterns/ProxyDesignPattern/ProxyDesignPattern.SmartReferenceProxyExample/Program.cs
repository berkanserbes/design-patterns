// ============================================================================
// SMART REFERENCE PROXY DESIGN PATTERN
// ============================================================================
// Smart Reference Proxy performs additional actions when an object is accessed:
// - Reference counting (track how many clients use the object)
// - Access logging (audit trail)
// - Last access time tracking
// - Auto-cleanup when no references remain
// 
// Pattern Structure:
//   - IDatabaseConnection: Subject interface
//   - RealDatabaseConnection: RealSubject (expensive resource)
//   - DatabaseConnectionProxy: Smart Proxy (tracks references & access)
// ============================================================================

namespace ProxyDesignPattern.SmartReferenceProxyExample;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== SMART REFERENCE PROXY PATTERN DEMO ===\n");

        // Create connection with initial reference
        var connection = new DatabaseConnectionProxy();
        Console.WriteLine();

        // Simulate multiple clients using the connection
        Console.WriteLine("--- Client 1 executes query ---\n");
        connection.ExecuteQuery("SELECT * FROM Users");
        Console.WriteLine();

        Console.WriteLine("--- Client 2 adds reference ---\n");
        connection.AddReference();
        Console.WriteLine();

        Console.WriteLine("--- Client 2 executes query ---\n");
        connection.ExecuteQuery("SELECT * FROM Orders");
        Console.WriteLine();

        Console.WriteLine("--- Client 3 adds reference ---\n");
        connection.AddReference();
        Console.WriteLine();

        Console.WriteLine("--- Client 1 releases reference ---\n");
        connection.ReleaseReference();
        Console.WriteLine();

        // Print current stats
        connection.PrintStatistics();
        Console.WriteLine();

        Console.WriteLine("--- Client 2 releases reference ---\n");
        connection.ReleaseReference();
        Console.WriteLine();

        Console.WriteLine("--- Client 3 releases reference (last one - triggers auto-close) ---\n");
        connection.ReleaseReference();

        Console.WriteLine("\n=== SUMMARY ===");
        Console.WriteLine("Smart Proxy tracked all references and access.");
        Console.WriteLine("Connection was auto-closed when last reference was released.");
    }
}
