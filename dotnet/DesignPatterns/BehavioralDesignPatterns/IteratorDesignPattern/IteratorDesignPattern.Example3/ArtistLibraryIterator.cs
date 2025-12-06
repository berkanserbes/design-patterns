namespace IteratorDesignPattern.Example3;

public class ArtistLibraryIterator : IIterator<Song>
{
    private readonly ArtistLibrary _library;
    private readonly List<Song> _allSongs;
    private int _currentIndex = 0;

    public ArtistLibraryIterator(ArtistLibrary library)
    {
        _library = library;
        _allSongs = new List<Song>();
        
        foreach (var artistSongs in _library.GetArtistSongs().Values)
        {
            _allSongs.AddRange(artistSongs);
        }
    }

    public bool HasNext()
    {
        return _currentIndex < _allSongs.Count;
    }

    public Song Next()
    {
        return _allSongs[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
