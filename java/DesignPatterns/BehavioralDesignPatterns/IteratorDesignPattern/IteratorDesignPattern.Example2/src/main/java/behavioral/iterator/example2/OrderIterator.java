package behavioral.iterator.example2;

public class OrderIterator implements IIterator<Order> {
    private final OrderCollection collection;
    private int currentIndex = 0;

    public OrderIterator(OrderCollection collection) { this.collection = collection; }

    @Override
    public boolean hasNext() { return currentIndex < collection.getCount(); }

    @Override
    public Order next() { return collection.get(currentIndex++); }

    @Override
    public void reset() { currentIndex = 0; }
}
