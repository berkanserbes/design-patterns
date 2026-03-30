package behavioral.state.example1;

public class PendingState implements IOrderState {
    @Override
    public void processOrder(Order order) {
        System.out.println("  Processing order " + order.getOrderId() + "...");
        order.setState(new ProcessingState());
    }
    @Override
    public void shipOrder(Order order) { System.out.println("  [ERROR] Cannot ship - order is still Pending."); }
    @Override
    public void deliverOrder(Order order) { System.out.println("  [ERROR] Cannot deliver - order is still Pending."); }
    @Override
    public void cancelOrder(Order order) {
        System.out.println("  Cancelling order " + order.getOrderId() + ".");
        order.setState(new CancelledState());
    }
    @Override
    public String getStateName() { return "Pending"; }
}
