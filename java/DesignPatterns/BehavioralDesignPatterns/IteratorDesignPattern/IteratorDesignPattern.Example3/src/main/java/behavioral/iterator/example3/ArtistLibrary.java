package behavioral.iterator.example3;

import java.util.*;

public class ArtistLibrary implements IAggregate<Song> {
    private final Map<String, List<Song>> artistSongs = new LinkedHashMap<>();

    public void addSong(Song song) {
        artistSongs.computeIfAbsent(song.getArtist(), k -> new ArrayList<>()).add(song);
    }

    public Map<String, List<Song>> getArtistSongs() { return artistSongs; }

    @Override
    public IIterator<Song> createIterator() { return new ArtistLibraryIterator(this); }

    public IIterator<Song> createArtistIterator(String artist) { return new SpecificArtistIterator(this, artist); }
}
