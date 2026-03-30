package behavioral.state.example1;

public class DeliveredState implements IOrderState {
    @Override
    public void processOrder(Order order) { System.out.println("  [ERROR] Order already delivered."); }
    @Override
    public void shipOrder(Order order) { System.out.println("  [ERROR] Order already delivered."); }
    @Override
    public void deliverOrder(Order order) { System.out.println("  [INFO] Order already delivered."); }
    @Override
    public void cancelOrder(Order order) { System.out.println("  [ERROR] Cannot cancel - order already delivered."); }
    @Override
    public String getStateName() { return "Delivered"; }
}
