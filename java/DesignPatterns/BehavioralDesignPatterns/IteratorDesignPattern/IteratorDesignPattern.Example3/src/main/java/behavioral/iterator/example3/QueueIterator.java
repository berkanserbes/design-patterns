package behavioral.iterator.example3;

import java.util.*;

public class QueueIterator implements IIterator<Song> {
    private final List<Song> songs;
    private int currentIndex = 0;

    public QueueIterator(PlayQueue playQueue) {
        songs = new ArrayList<>(playQueue.getQueue());
    }

    @Override
    public boolean hasNext() { return currentIndex < songs.size(); }

    @Override
    public Song next() { return songs.get(currentIndex++); }

    @Override
    public void reset() { currentIndex = 0; }
}
