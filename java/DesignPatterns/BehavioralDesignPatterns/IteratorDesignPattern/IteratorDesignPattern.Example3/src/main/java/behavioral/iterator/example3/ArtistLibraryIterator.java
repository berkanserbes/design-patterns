package behavioral.iterator.example3;

import java.util.*;

public class ArtistLibraryIterator implements IIterator<Song> {
    private final List<Song> allSongs = new ArrayList<>();
    private int currentIndex = 0;

    public ArtistLibraryIterator(ArtistLibrary library) {
        for (List<Song> songs : library.getArtistSongs().values()) {
            allSongs.addAll(songs);
        }
    }

    @Override
    public boolean hasNext() { return currentIndex < allSongs.size(); }

    @Override
    public Song next() { return allSongs.get(currentIndex++); }

    @Override
    public void reset() { currentIndex = 0; }
}
