package behavioral.state.example1;

public class CancelledState implements IOrderState {
    @Override
    public void processOrder(Order order) { System.out.println("  [ERROR] Order is cancelled."); }
    @Override
    public void shipOrder(Order order) { System.out.println("  [ERROR] Order is cancelled."); }
    @Override
    public void deliverOrder(Order order) { System.out.println("  [ERROR] Order is cancelled."); }
    @Override
    public void cancelOrder(Order order) { System.out.println("  [INFO] Order is already cancelled."); }
    @Override
    public String getStateName() { return "Cancelled"; }
}
