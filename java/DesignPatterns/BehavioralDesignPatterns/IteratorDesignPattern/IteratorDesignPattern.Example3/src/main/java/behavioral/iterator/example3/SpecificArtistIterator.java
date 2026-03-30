package behavioral.iterator.example3;

import java.util.*;

public class SpecificArtistIterator implements IIterator<Song> {
    private final List<Song> songs;
    private int currentIndex = 0;

    public SpecificArtistIterator(ArtistLibrary library, String artist) {
        songs = library.getArtistSongs().getOrDefault(artist, Collections.emptyList());
    }

    @Override
    public boolean hasNext() { return currentIndex < songs.size(); }

    @Override
    public Song next() { return songs.get(currentIndex++); }

    @Override
    public void reset() { currentIndex = 0; }
}
