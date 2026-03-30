package behavioral.iterator.example3;

import java.util.*;

public class FavoriteIterator implements IIterator<Song> {
    private final List<Song> songs;
    private int currentIndex = 0;

    public FavoriteIterator(FavoritePlaylist playlist) {
        songs = new ArrayList<>(playlist.getFavorites());
    }

    @Override
    public boolean hasNext() { return currentIndex < songs.size(); }

    @Override
    public Song next() { return songs.get(currentIndex++); }

    @Override
    public void reset() { currentIndex = 0; }
}
