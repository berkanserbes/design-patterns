package behavioral.iterator.example3;

import java.util.*;

public class FavoritePlaylist implements IAggregate<Song> {
    private final Set<Song> favorites = new LinkedHashSet<>();

    public boolean addFavorite(Song song) { return favorites.add(song); }
    public boolean removeFavorite(Song song) { return favorites.remove(song); }
    public Set<Song> getFavorites() { return favorites; }

    @Override
    public IIterator<Song> createIterator() { return new FavoriteIterator(this); }
}
