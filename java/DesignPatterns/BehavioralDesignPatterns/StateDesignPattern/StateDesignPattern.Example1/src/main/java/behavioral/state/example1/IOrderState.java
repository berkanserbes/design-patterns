package behavioral.state.example1;

public interface IOrderState {
    void processOrder(Order order);
    void shipOrder(Order order);
    void deliverOrder(Order order);
    void cancelOrder(Order order);
    String getStateName();
}
