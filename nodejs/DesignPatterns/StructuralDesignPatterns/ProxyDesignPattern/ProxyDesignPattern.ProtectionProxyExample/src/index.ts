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

import { DocumentProxy } from "./DocumentProxy";
import { IDocument } from "./IDocument";
import { SensitiveDocument } from "./SensitiveDocument";
import { Role, User } from "./User";

console.log("=== PROTECTION PROXY PATTERN DEMO ===\n");

// Create the real document
const document = new SensitiveDocument("Financial Report", "Q4 Revenue: $1,000,000");

// Create users with different roles
const viewer = new User("John", Role.Viewer);
const editor = new User("Jane", Role.Editor);
const admin = new User("Bob", Role.Admin);

// Test with Viewer
console.log("--- Testing VIEWER Access ---\n");
const viewerProxy: IDocument = new DocumentProxy(document, viewer);
viewerProxy.read();
viewerProxy.write("Hacked content!");
viewerProxy.delete();

console.log("\n--- Testing EDITOR Access ---\n");
const editorProxy: IDocument = new DocumentProxy(document, editor);
editorProxy.read();
editorProxy.write("Q4 Revenue: $1,500,000");
editorProxy.delete();

console.log("\n--- Testing ADMIN Access ---\n");
const adminProxy: IDocument = new DocumentProxy(document, admin);
adminProxy.read();
adminProxy.write("CONFIDENTIAL");
adminProxy.delete();

console.log("\n=== SUMMARY ===");
console.log("Viewer: Could only READ");
console.log("Editor: Could READ and WRITE");
console.log("Admin:  Could READ, WRITE and DELETE");
