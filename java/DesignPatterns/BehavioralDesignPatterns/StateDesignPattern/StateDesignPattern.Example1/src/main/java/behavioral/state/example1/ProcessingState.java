package behavioral.state.example1;

public class ProcessingState implements IOrderState {
    @Override
    public void processOrder(Order order) { System.out.println("  [INFO] Order " + order.getOrderId() + " is already being processed."); }
    @Override
    public void shipOrder(Order order) {
        System.out.println("  Shipping order " + order.getOrderId() + "...");
        order.setState(new ShippedState());
    }
    @Override
    public void deliverOrder(Order order) { System.out.println("  [ERROR] Cannot deliver - order must be shipped first."); }
    @Override
    public void cancelOrder(Order order) {
        System.out.println("  Cancelling order " + order.getOrderId() + ".");
        order.setState(new CancelledState());
    }
    @Override
    public String getStateName() { return "Processing"; }
}
