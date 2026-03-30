package behavioral.state.example1;

public class ShippedState implements IOrderState {
    @Override
    public void processOrder(Order order) { System.out.println("  [ERROR] Order " + order.getOrderId() + " is already shipped."); }
    @Override
    public void shipOrder(Order order) { System.out.println("  [ERROR] Order " + order.getOrderId() + " is already shipped."); }
    @Override
    public void deliverOrder(Order order) {
        System.out.println("  Delivering order " + order.getOrderId() + "...");
        order.setState(new DeliveredState());
    }
    @Override
    public void cancelOrder(Order order) { System.out.println("  [ERROR] Cannot cancel - order is already shipped."); }
    @Override
    public String getStateName() { return "Shipped"; }
}
