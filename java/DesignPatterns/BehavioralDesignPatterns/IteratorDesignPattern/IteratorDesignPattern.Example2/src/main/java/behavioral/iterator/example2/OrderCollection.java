package behavioral.iterator.example2;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class OrderCollection implements IAggregate<Order> {
    private final List<Order> orders = new ArrayList<>();

    public void addOrder(Order order) { orders.add(order); }
    public int getCount() { return orders.size(); }
    public Order get(int index) { return orders.get(index); }

    @Override
    public IIterator<Order> createIterator() { return new OrderIterator(this); }

    public IIterator<Order> createStatusFilterIterator(OrderStatus status) { return new StatusFilterIterator(this, status); }
    public IIterator<Order> createDateRangeIterator(LocalDate start, LocalDate end) { return new DateRangeIterator(this, start, end); }
    public IIterator<Order> createHighValueIterator(double minAmount) { return new HighValueOrderIterator(this, minAmount); }
}
