using IteratorDesignPattern.Example3;

Console.WriteLine("=== Iterator Pattern - Music Streaming Platform ===\n");

var song1 = new Song { Id = "1", Title = "Bohemian Rhapsody", Artist = "Queen", Album = "A Night at the Opera", Duration = TimeSpan.FromMinutes(5.55), Genre = "Rock" };
var song2 = new Song { Id = "2", Title = "Stairway to Heaven", Artist = "Led Zeppelin", Album = "Led Zeppelin IV", Duration = TimeSpan.FromMinutes(8.02), Genre = "Rock" };
var song3 = new Song { Id = "3", Title = "Imagine", Artist = "John Lennon", Album = "Imagine", Duration = TimeSpan.FromMinutes(3.03), Genre = "Pop" };
var song4 = new Song { Id = "4", Title = "Hotel California", Artist = "Eagles", Album = "Hotel California", Duration = TimeSpan.FromMinutes(6.30), Genre = "Rock" };
var song5 = new Song { Id = "5", Title = "We Will Rock You", Artist = "Queen", Album = "News of the World", Duration = TimeSpan.FromMinutes(2.02), Genre = "Rock" };

// 1. Dictionary - Artist Library
Console.WriteLine("1. ARTIST LIBRARY (Dictionary<string, List<Song>>)");
var library = new ArtistLibrary();
library.AddSong(song1);
library.AddSong(song2);
library.AddSong(song3);
library.AddSong(song4);
library.AddSong(song5);

Console.WriteLine("\nAll songs in library:");
var libraryIterator = library.CreateIterator();
while (libraryIterator.HasNext())
{
    Console.WriteLine($"  {libraryIterator.Next()}");
}

Console.WriteLine("\nOnly Queen songs:");
var queenIterator = library.CreateArtistIterator("Queen");
while (queenIterator.HasNext())
{
    Console.WriteLine($"  {queenIterator.Next()}");
}

// 2. Queue - Play Queue
Console.WriteLine("\n2. PLAY QUEUE (Queue<Song>)");
var playQueue = new PlayQueue();
playQueue.Enqueue(song1);
playQueue.Enqueue(song3);
playQueue.Enqueue(song4);

Console.WriteLine("\nSongs in play queue (FIFO):");
var queueIterator = playQueue.CreateIterator();
while (queueIterator.HasNext())
{
    Console.WriteLine($"  {queueIterator.Next()}");
}

// 3. Stack - Listening History
Console.WriteLine("\n3. LISTENING HISTORY (Stack<Song>)");
var history = new ListeningHistory();
history.AddToHistory(song2);
history.AddToHistory(song4);
history.AddToHistory(song1);

Console.WriteLine("\nRecently played (LIFO - most recent first):");
var historyIterator = history.CreateIterator();
while (historyIterator.HasNext())
{
    Console.WriteLine($"  {historyIterator.Next()}");
}

// 4. HashSet - Favorites
Console.WriteLine("\n4. FAVORITE PLAYLIST (HashSet<Song>)");
var favorites = new FavoritePlaylist();
favorites.AddFavorite(song1);
favorites.AddFavorite(song3);
favorites.AddFavorite(song5);

Console.WriteLine("\nFavorite songs (unique, unordered):");
var favIterator = favorites.CreateIterator();
while (favIterator.HasNext())
{
    Console.WriteLine($"  {favIterator.Next()}");
}

Console.WriteLine("\n=== Demonstration Complete ===");
