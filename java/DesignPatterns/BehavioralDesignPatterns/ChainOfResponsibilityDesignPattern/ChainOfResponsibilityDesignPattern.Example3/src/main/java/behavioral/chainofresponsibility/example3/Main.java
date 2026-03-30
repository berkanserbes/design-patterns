package behavioral.chainofresponsibility.example3;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Chain of Responsibility - Support Ticket System ===\n");

        ISupportHandler chain = buildChain();

        SupportTicket[] tickets = {
            new SupportTicket(1001, "John Doe", "password reset", TicketPriority.Low, TicketCategory.General),
            new SupportTicket(1002, "Jane Smith", "login issue", TicketPriority.Medium, TicketCategory.Account),
            new SupportTicket(1003, "Bob Johnson", "API integration", TicketPriority.Medium, TicketCategory.Technical),
            new SupportTicket(1004, "Alice Brown", "plan upgrade", TicketPriority.High, TicketCategory.Billing),
            new SupportTicket(1005, "Charlie Wilson", "system outage URGENT", TicketPriority.Critical, TicketCategory.Technical),
            new SupportTicket(1006, "Diana Prince", "documentation", TicketPriority.Low, TicketCategory.General),
            new SupportTicket(1007, "Eve Davis", "database timeout", TicketPriority.High, TicketCategory.Technical)
        };

        for (SupportTicket ticket : tickets) {
            System.out.println("Processing Ticket #" + ticket.getTicketId() + " [" + ticket.getPriority() + "/" + ticket.getCategory() + "]: " + ticket.getIssue());
            chain.handleTicket(ticket);
            System.out.println("  Resolved by: " + ticket.getResolvedBy() + " - " + ticket.getResolution());
            System.out.println();
        }
    }

    private static ISupportHandler buildChain() {
        ISupportHandler level1 = new Level1SupportHandler();
        ISupportHandler level2 = new Level2SupportHandler();
        ISupportHandler teamLead = new TeamLeadHandler();
        ISupportHandler manager = new ManagerHandler();
        level1.setNext(level2).setNext(teamLead).setNext(manager);
        return level1;
    }
}
