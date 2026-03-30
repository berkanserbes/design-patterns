package behavioral.state.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== State Pattern - E-Commerce Order Status ===\n");

        System.out.println("--- Scenario 1: Successful flow ---");
        Order order1 = new Order("ORD-001", "Laptop");
        order1.display();
        order1.processOrder(); order1.display();
        order1.shipOrder(); order1.display();
        order1.deliverOrder(); order1.display();

        System.out.println("\n--- Scenario 2: Cancellation ---");
        Order order2 = new Order("ORD-002", "Mouse");
        order2.display();
        order2.processOrder(); order2.display();
        order2.cancelOrder(); order2.display();

        System.out.println("\n--- Scenario 3: Invalid transitions ---");
        Order order3 = new Order("ORD-003", "Keyboard");
        order3.shipOrder();   // invalid - pending
        order3.deliverOrder(); // invalid - pending

        System.out.println("\n--- Scenario 4: Operations after delivery ---");
        Order order4 = new Order("ORD-004", "Monitor");
        order4.processOrder();
        order4.shipOrder();
        order4.deliverOrder();
        order4.cancelOrder();  // invalid - delivered
        order4.processOrder(); // invalid - delivered
    }
}
