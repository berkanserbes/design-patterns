package behavioral.iterator.example2;

public class HighValueOrderIterator implements IIterator<Order> {
    private final OrderCollection collection;
    private final double minAmount;
    private int currentIndex = 0;

    public HighValueOrderIterator(OrderCollection collection, double minAmount) {
        this.collection = collection;
        this.minAmount = minAmount;
    }

    @Override
    public boolean hasNext() {
        while (currentIndex < collection.getCount()) {
            if (collection.get(currentIndex).getTotalAmount() >= minAmount) return true;
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
