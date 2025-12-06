namespace IteratorDesignPattern.Example3;

public class FavoritePlaylist : IAggregate<Song>
{
    private readonly HashSet<Song> _favorites = new();

    public bool AddFavorite(Song song)
    {
        return _favorites.Add(song);
    }

    public bool RemoveFavorite(Song song)
    {
        return _favorites.Remove(song);
    }

    public HashSet<Song> GetFavorites() => _favorites;

    public IIterator<Song> CreateIterator()
    {
        return new FavoriteIterator(this);
    }
}
