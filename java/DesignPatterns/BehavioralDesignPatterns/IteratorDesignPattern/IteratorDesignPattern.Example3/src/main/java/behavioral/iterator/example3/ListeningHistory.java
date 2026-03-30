package behavioral.iterator.example3;

import java.util.*;

public class ListeningHistory implements IAggregate<Song> {
    private final Deque<Song> history = new ArrayDeque<>();

    public void addToHistory(Song song) { history.push(song); }
    public Deque<Song> getHistory() { return history; }

    @Override
    public IIterator<Song> createIterator() { return new HistoryIterator(this); }
}
