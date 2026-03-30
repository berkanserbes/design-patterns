package behavioral.chainofresponsibility.example3;

public class SupportTicket {
    private final int ticketId;
    private final String customerName;
    private final String issue;
    private final TicketPriority priority;
    private final TicketCategory category;
    private boolean isResolved;
    private String resolvedBy;
    private String resolution;

    public SupportTicket(int ticketId, String customerName, String issue,
                         TicketPriority priority, TicketCategory category) {
        this.ticketId = ticketId;
        this.customerName = customerName;
        this.issue = issue;
        this.priority = priority;
        this.category = category;
    }

    public int getTicketId() { return ticketId; }
    public String getCustomerName() { return customerName; }
    public String getIssue() { return issue; }
    public TicketPriority getPriority() { return priority; }
    public TicketCategory getCategory() { return category; }
    public boolean isResolved() { return isResolved; }
    public void setResolved(boolean resolved) { isResolved = resolved; }
    public String getResolvedBy() { return resolvedBy; }
    public void setResolvedBy(String resolvedBy) { this.resolvedBy = resolvedBy; }
    public String getResolution() { return resolution; }
    public void setResolution(String resolution) { this.resolution = resolution; }
}
