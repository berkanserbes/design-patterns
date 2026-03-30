package behavioral.iterator.example2;

import java.time.LocalDate;

public class DateRangeIterator implements IIterator<Order> {
    private final OrderCollection collection;
    private final LocalDate startDate;
    private final LocalDate endDate;
    private int currentIndex = 0;

    public DateRangeIterator(OrderCollection collection, LocalDate startDate, LocalDate endDate) {
        this.collection = collection;
        this.startDate = startDate;
        this.endDate = endDate;
    }

    @Override
    public boolean hasNext() {
        while (currentIndex < collection.getCount()) {
            LocalDate date = collection.get(currentIndex).getOrderDate();
            if (!date.isBefore(startDate) && !date.isAfter(endDate)) return true;
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
