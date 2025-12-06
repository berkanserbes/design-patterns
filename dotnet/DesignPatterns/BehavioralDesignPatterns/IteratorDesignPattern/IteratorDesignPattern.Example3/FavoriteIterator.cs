namespace IteratorDesignPattern.Example3;

public class FavoriteIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex = 0;

    public FavoriteIterator(FavoritePlaylist playlist)
    {
        _songs = playlist.GetFavorites().ToList();
    }

    public bool HasNext()
    {
        return _currentIndex < _songs.Count;
    }

    public Song Next()
    {
        return _songs[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
