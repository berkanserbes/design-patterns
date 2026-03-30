package behavioral.state.example1;

public class Order {
    private final String orderId;
    private final String productName;
    private IOrderState currentState;

    public Order(String orderId, String productName) {
        this.orderId = orderId;
        this.productName = productName;
        this.currentState = new PendingState();
    }

    public void setState(IOrderState state) { this.currentState = state; }
    public String getOrderId() { return orderId; }
    public String getProductName() { return productName; }
    public String getStateName() { return currentState.getStateName(); }

    public void processOrder() { currentState.processOrder(this); }
    public void shipOrder() { currentState.shipOrder(this); }
    public void deliverOrder() { currentState.deliverOrder(this); }
    public void cancelOrder() { currentState.cancelOrder(this); }

    public void display() {
        System.out.println("Order [" + orderId + "] " + productName + " -> State: " + currentState.getStateName());
    }
}
