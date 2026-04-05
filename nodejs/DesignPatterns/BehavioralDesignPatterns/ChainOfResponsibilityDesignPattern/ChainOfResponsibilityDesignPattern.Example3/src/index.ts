// ============================================================================
// CHAIN OF RESPONSIBILITY - Example 3: Customer Support Ticket System
// ============================================================================
// Chain: Level1 → Level2 → TeamLead → Manager
// Each level handles tickets it can resolve; escalates others up the chain.

import { Level1SupportHandler } from "./Handlers/Level1SupportHandler";
import { Level2SupportHandler } from "./Handlers/Level2SupportHandler";
import { ManagerHandler } from "./Handlers/ManagerHandler";
import { TeamLeadHandler } from "./Handlers/TeamLeadHandler";
import { ISupportHandler, SupportTicket, TicketCategory, TicketPriority } from "./SupportTicket";

function processTicket(ticket: SupportTicket, handler: ISupportHandler): void {
  console.log(`Ticket #${ticket.ticketId}`);
  console.log(`Customer: ${ticket.customerName}`);
  console.log(`Issue: ${ticket.issue}`);
  console.log(`Priority: ${TicketPriority[ticket.priority]} | Category: ${ticket.category}\n`);

  handler.handleTicket(ticket);

  if (ticket.isResolved) {
    console.log(`Status: RESOLVED`);
    console.log(`Handled By: ${ticket.resolvedBy}`);
    console.log(`Resolution: ${ticket.resolution}`);
  } else {
    console.log(`Status: UNRESOLVED - No handler available for this ticket.`);
  }
  console.log("\n" + "─".repeat(60) + "\n");
}

// Build the chain
const level1  = new Level1SupportHandler();
const level2  = new Level2SupportHandler();
const teamLead= new TeamLeadHandler();
const manager = new ManagerHandler();

level1.setNext(level2).setNext(teamLead).setNext(manager);

console.log("=== Customer Support Ticket Management System ===\n");

const tickets: SupportTicket[] = [
  new SupportTicket(1001, "John Doe",      "How to reset my password?",               TicketPriority.Low,      TicketCategory.General),
  new SupportTicket(1002, "Jane Smith",    "Cannot login to my account",              TicketPriority.Medium,   TicketCategory.Account),
  new SupportTicket(1003, "Bob Johnson",   "API integration not working",             TicketPriority.Medium,   TicketCategory.Technical),
  new SupportTicket(1004, "Alice Brown",   "Need to upgrade my plan",                 TicketPriority.High,     TicketCategory.Billing),
  new SupportTicket(1005, "Charlie Wilson","URGENT: System outage affecting production!", TicketPriority.Critical, TicketCategory.Technical),
  new SupportTicket(1006, "Diana Prince",  "Where can I find documentation?",         TicketPriority.Low,      TicketCategory.General),
  new SupportTicket(1007, "Eve Davis",     "Database connection timeout",             TicketPriority.High,     TicketCategory.Technical),
];

for (const ticket of tickets) {
  processTicket(ticket, level1);
}
