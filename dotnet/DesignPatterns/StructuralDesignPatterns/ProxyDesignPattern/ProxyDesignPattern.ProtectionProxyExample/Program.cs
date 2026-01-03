// ============================================================================
// PROTECTION PROXY DESIGN PATTERN
// ============================================================================
// Protection Proxy controls access to an object based on access rights.
// 
// Pattern Structure:
//   - IDocument: Subject interface
//   - SensitiveDocument: RealSubject (no access control)
//   - DocumentProxy: Proxy (checks user role before allowing access)
//
// Access Rules:
//   - Viewer: Read only
//   - Editor: Read + Write
//   - Admin:  Read + Write + Delete
// ============================================================================

using ProxyDesignPattern.ProtectionProxyExample;

Console.WriteLine("=== PROTECTION PROXY PATTERN DEMO ===\n");

// Create the real document
var document = new SensitiveDocument("Financial Report", "Q4 Revenue: $1,000,000");

// Create users with different roles
var viewer = new User("John", Role.Viewer);
var editor = new User("Jane", Role.Editor);
var admin = new User("Bob", Role.Admin);

// Test with Viewer
Console.WriteLine("--- Testing VIEWER Access ---\n");
IDocument viewerProxy = new DocumentProxy(document, viewer);
viewerProxy.Read();
viewerProxy.Write("Hacked content!");
viewerProxy.Delete();

Console.WriteLine("\n--- Testing EDITOR Access ---\n");
IDocument editorProxy = new DocumentProxy(document, editor);
editorProxy.Read();
editorProxy.Write("Q4 Revenue: $1,500,000");
editorProxy.Delete();

Console.WriteLine("\n--- Testing ADMIN Access ---\n");
IDocument adminProxy = new DocumentProxy(document, admin);
adminProxy.Read();
adminProxy.Write("CONFIDENTIAL");
adminProxy.Delete();

Console.WriteLine("\n=== SUMMARY ===");
Console.WriteLine("Viewer: Could only READ");
Console.WriteLine("Editor: Could READ and WRITE");
Console.WriteLine("Admin:  Could READ, WRITE and DELETE");
