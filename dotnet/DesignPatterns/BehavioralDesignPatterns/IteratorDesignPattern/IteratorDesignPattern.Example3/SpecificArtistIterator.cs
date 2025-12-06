namespace IteratorDesignPattern.Example3;

public class SpecificArtistIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex = 0;

    public SpecificArtistIterator(ArtistLibrary library, string artist)
    {
        _songs = library.GetArtistSongs().ContainsKey(artist)
            ? library.GetArtistSongs()[artist]
            : new List<Song>();
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
