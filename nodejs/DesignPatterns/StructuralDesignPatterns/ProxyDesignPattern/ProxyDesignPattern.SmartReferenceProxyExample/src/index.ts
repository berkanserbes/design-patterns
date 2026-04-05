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

import { DatabaseConnectionProxy } from "./DatabaseConnectionProxy";

console.log("=== SMART REFERENCE PROXY PATTERN DEMO ===\n");

// Create connection with initial reference
const connection = new DatabaseConnectionProxy();
console.log();

// Simulate multiple clients using the connection
console.log("--- Client 1 executes query ---\n");
connection.executeQuery("SELECT * FROM Users");
console.log();

console.log("--- Client 2 adds reference ---\n");
connection.addReference();
console.log();

console.log("--- Client 2 executes query ---\n");
connection.executeQuery("SELECT * FROM Orders");
console.log();

console.log("--- Client 3 adds reference ---\n");
connection.addReference();
console.log();

console.log("--- Client 1 releases reference ---\n");
connection.releaseReference();
console.log();

// Print current stats
connection.printStatistics();
console.log();

console.log("--- Client 2 releases reference ---\n");
connection.releaseReference();
console.log();

console.log("--- Client 3 releases reference (last one - triggers auto-close) ---\n");
connection.releaseReference();

console.log("\n=== SUMMARY ===");
console.log("Smart Proxy tracked all references and access.");
console.log("Connection was auto-closed when last reference was released.");
