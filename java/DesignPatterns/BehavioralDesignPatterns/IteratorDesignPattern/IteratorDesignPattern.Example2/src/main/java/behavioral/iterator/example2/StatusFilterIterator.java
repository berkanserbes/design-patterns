package behavioral.iterator.example2;

public class StatusFilterIterator implements IIterator<Order> {
    private final OrderCollection collection;
    private final OrderStatus filterStatus;
    private int currentIndex = 0;

    public StatusFilterIterator(OrderCollection collection, OrderStatus filterStatus) {
        this.collection = collection;
        this.filterStatus = filterStatus;
    }

    @Override
    public boolean hasNext() {
        while (currentIndex < collection.getCount()) {
            if (collection.get(currentIndex).getStatus() == filterStatus) return true;
            currentIndex++;
        }
        return false;
    }

    @Override
    public Order next() {
        if (!hasNext()) throw new java.util.NoSuchElementException();
        return collection.get(currentIndex++);
    }

    @Override
    public void reset() { currentIndex = 0; }
}
