using ChainOfResponsibilityDesignPattern.Example3;
using ChainOfResponsibilityDesignPattern.Example3.Handlers;

Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║     Customer Support Ticket Management System             ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");

// Create the chain of responsibility
var level1Support = new Level1SupportHandler();
var level2Support = new Level2SupportHandler();
var teamLead = new TeamLeadHandler();
var manager = new ManagerHandler();

// Setup the chain
level1Support
    .SetNext(level2Support)
    .SetNext(teamLead)
    .SetNext(manager);

while (true)
{
    Console.WriteLine("\nSupport Ticket Scenarios:");
    Console.WriteLine("1. Password Reset Request (Low Priority)");
    Console.WriteLine("2. Account Login Issue (Medium Priority)");
    Console.WriteLine("3. API Integration Problem (Medium Priority)");
    Console.WriteLine("4. Plan Upgrade Request (High Priority)");
    Console.WriteLine("5. System Outage - URGENT! (Critical Priority)");
    Console.WriteLine("6. Documentation Request (Low Priority)");
    Console.WriteLine("7. Database Connection Timeout (High Priority)");
    Console.WriteLine("0. Exit");
    Console.Write("\nSelect a ticket scenario (0-7): ");
    
    var choice = Console.ReadLine();
    
    if (choice == "0")
    {
        Console.WriteLine("\nExiting Support System. Goodbye!");
        break;
    }

    Console.WriteLine();
    
    switch (choice)
    {
        case "1":
            TestPasswordReset(level1Support);
            break;
        case "2":
            TestAccountLogin(level1Support);
            break;
        case "3":
            TestApiIntegration(level1Support);
            break;
        case "4":
            TestPlanUpgrade(level1Support);
            break;
        case "5":
            TestSystemOutage(level1Support);
            break;
        case "6":
            TestDocumentation(level1Support);
            break;
        case "7":
            TestDatabaseTimeout(level1Support);
            break;
        default:
            Console.WriteLine("Invalid choice! Please select 0-7.");
            break;
    }
    
    if (choice is "1" or "2" or "3" or "4" or "5" or "6" or "7")
    {
        Console.WriteLine("\n" + new string('─', 60));
    }
}

static void TestPasswordReset(ISupportHandler handler)
{
    var ticket = new SupportTicket(1001, "John Doe", "How to reset my password?", TicketPriority.Low, TicketCategory.General);
    ProcessTicket(ticket, handler);
}

static void TestAccountLogin(ISupportHandler handler)
{
    var ticket = new SupportTicket(1002, "Jane Smith", "Cannot login to my account", TicketPriority.Medium, TicketCategory.Account);
    ProcessTicket(ticket, handler);
}

static void TestApiIntegration(ISupportHandler handler)
{
    var ticket = new SupportTicket(1003, "Bob Johnson", "API integration not working", TicketPriority.Medium, TicketCategory.Technical);
    ProcessTicket(ticket, handler);
}

static void TestPlanUpgrade(ISupportHandler handler)
{
    var ticket = new SupportTicket(1004, "Alice Brown", "Need to upgrade my plan", TicketPriority.High, TicketCategory.Billing);
    ProcessTicket(ticket, handler);
}

static void TestSystemOutage(ISupportHandler handler)
{
    var ticket = new SupportTicket(1005, "Charlie Wilson", "URGENT: System outage affecting production!", TicketPriority.Critical, TicketCategory.Technical);
    ProcessTicket(ticket, handler);
}

static void TestDocumentation(ISupportHandler handler)
{
    var ticket = new SupportTicket(1006, "Diana Prince", "Where can I find documentation?", TicketPriority.Low, TicketCategory.General);
    ProcessTicket(ticket, handler);
}

static void TestDatabaseTimeout(ISupportHandler handler)
{
    var ticket = new SupportTicket(1007, "Eve Davis", "Database connection timeout", TicketPriority.High, TicketCategory.Technical);
    ProcessTicket(ticket, handler);
}

static void ProcessTicket(SupportTicket ticket, ISupportHandler handler)
{
    Console.WriteLine($"Ticket #{ticket.TicketId}");
    Console.WriteLine($"Customer: {ticket.CustomerName}");
    Console.WriteLine($"Issue: {ticket.Issue}");
    Console.WriteLine($"Priority: {ticket.Priority} | Category: {ticket.Category}\n");
    
    handler.HandleTicket(ticket);
    
    if (ticket.IsResolved)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Status: ✓ RESOLVED");
        Console.WriteLine($"Handled By: {ticket.ResolvedBy}");
        Console.WriteLine($"Resolution: {ticket.Resolution}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Status: ⚠ UNRESOLVED - No handler available for this ticket.");
        Console.ResetColor();
    }
}

