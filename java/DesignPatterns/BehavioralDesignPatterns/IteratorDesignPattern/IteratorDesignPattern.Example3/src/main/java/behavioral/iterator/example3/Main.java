package behavioral.iterator.example3;

import java.time.Duration;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Iterator Pattern - Music Streaming Platform ===\n");

        Song song1 = new Song("1", "Bohemian Rhapsody", "Queen", "A Night at the Opera", Duration.ofSeconds(333), "Rock");
        Song song2 = new Song("2", "Stairway to Heaven", "Led Zeppelin", "Led Zeppelin IV", Duration.ofSeconds(481), "Rock");
        Song song3 = new Song("3", "Imagine", "John Lennon", "Imagine", Duration.ofSeconds(183), "Pop");
        Song song4 = new Song("4", "Hotel California", "Eagles", "Hotel California", Duration.ofSeconds(390), "Rock");
        Song song5 = new Song("5", "We Will Rock You", "Queen", "News of the World", Duration.ofSeconds(122), "Rock");

        System.out.println("1. ARTIST LIBRARY (Dictionary<String, List<Song>>)");
        ArtistLibrary library = new ArtistLibrary();
        library.addSong(song1);
        library.addSong(song2);
        library.addSong(song3);
        library.addSong(song4);
        library.addSong(song5);

        System.out.println("\nAll songs in library:");
        IIterator<Song> libraryIterator = library.createIterator();
        while (libraryIterator.hasNext()) System.out.println("  " + libraryIterator.next());

        System.out.println("\nOnly Queen songs:");
        IIterator<Song> queenIterator = library.createArtistIterator("Queen");
        while (queenIterator.hasNext()) System.out.println("  " + queenIterator.next());

        System.out.println("\n2. PLAY QUEUE (Queue<Song>)");
        PlayQueue playQueue = new PlayQueue();
        playQueue.enqueue(song1);
        playQueue.enqueue(song3);
        playQueue.enqueue(song4);

        System.out.println("\nSongs in play queue (FIFO):");
        IIterator<Song> queueIterator = playQueue.createIterator();
        while (queueIterator.hasNext()) System.out.println("  " + queueIterator.next());

        System.out.println("\n3. LISTENING HISTORY (Stack<Song>)");
        ListeningHistory history = new ListeningHistory();
        history.addToHistory(song2);
        history.addToHistory(song4);
        history.addToHistory(song1);

        System.out.println("\nRecently played (LIFO - most recent first):");
        IIterator<Song> historyIterator = history.createIterator();
        while (historyIterator.hasNext()) System.out.println("  " + historyIterator.next());

        System.out.println("\n4. FAVORITE PLAYLIST (HashSet<Song>)");
        FavoritePlaylist favorites = new FavoritePlaylist();
        favorites.addFavorite(song1);
        favorites.addFavorite(song3);
        favorites.addFavorite(song5);

        System.out.println("\nFavorite songs (unique, unordered):");
        IIterator<Song> favIterator = favorites.createIterator();
        while (favIterator.hasNext()) System.out.println("  " + favIterator.next());

        System.out.println("\n=== Demonstration Complete ===");
    }
}
