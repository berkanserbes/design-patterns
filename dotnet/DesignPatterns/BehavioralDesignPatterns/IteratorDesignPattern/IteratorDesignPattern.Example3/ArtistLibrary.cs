namespace IteratorDesignPattern.Example3;

public class ArtistLibrary : IAggregate<Song>
{
    private readonly Dictionary<string, List<Song>> _artistSongs = new();

    public void AddSong(Song song)
    {
        if (!_artistSongs.ContainsKey(song.Artist))
        {
            _artistSongs[song.Artist] = new List<Song>();
        }
        _artistSongs[song.Artist].Add(song);
    }

    public Dictionary<string, List<Song>> GetArtistSongs() => _artistSongs;

    public IIterator<Song> CreateIterator()
    {
        return new ArtistLibraryIterator(this);
    }

    public IIterator<Song> CreateArtistIterator(string artist)
    {
        return new SpecificArtistIterator(this, artist);
    }
}
