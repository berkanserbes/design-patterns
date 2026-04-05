// ============================================================================
// ITERATOR DESIGN PATTERN - Example 3: Music Streaming Platform
// ============================================================================
// Demonstrates iterators over different underlying data structures:
//   - Map<string, Song[]>  → ArtistLibrary
//   - Array (FIFO queue)   → PlayQueue
//   - Array (LIFO stack)   → ListeningHistory
//   - Set                  → FavoritePlaylist

import { ArtistLibrary, FavoritePlaylist, ListeningHistory, PlayQueue } from "./Collections";
import { Song } from "./Song";

console.log("=== Iterator Pattern - Music Streaming Platform ===\n");

const song1 = new Song("1", "Bohemian Rhapsody",  "Queen",       "A Night at the Opera", 355, "Rock");
const song2 = new Song("2", "Stairway to Heaven", "Led Zeppelin","Led Zeppelin IV",       482, "Rock");
const song3 = new Song("3", "Imagine",            "John Lennon", "Imagine",               183, "Pop");
const song4 = new Song("4", "Hotel California",   "Eagles",      "Hotel California",      390, "Rock");
const song5 = new Song("5", "We Will Rock You",   "Queen",       "News of the World",     122, "Rock");

// 1. Map — Artist Library
console.log("1. ARTIST LIBRARY (Map<string, Song[]>)");
const library = new ArtistLibrary();
[song1, song2, song3, song4, song5].forEach((s) => library.addSong(s));

console.log("\nAll songs in library:");
const libraryIterator = library.createIterator();
while (libraryIterator.hasNext()) {
  console.log(`  ${libraryIterator.next()}`);
}

console.log("\nOnly Queen songs:");
const queenIterator = library.createArtistIterator("Queen");
while (queenIterator.hasNext()) {
  console.log(`  ${queenIterator.next()}`);
}

// 2. Array (FIFO) — Play Queue
console.log("\n2. PLAY QUEUE (FIFO)");
const playQueue = new PlayQueue();
[song1, song3, song4].forEach((s) => playQueue.enqueue(s));

console.log("\nSongs in play queue (FIFO):");
const queueIterator = playQueue.createIterator();
while (queueIterator.hasNext()) {
  console.log(`  ${queueIterator.next()}`);
}

// 3. Array (LIFO) — Listening History
console.log("\n3. LISTENING HISTORY (LIFO — most recent first)");
const history = new ListeningHistory();
[song2, song4, song1].forEach((s) => history.addToHistory(s));

console.log("\nRecently played:");
const historyIterator = history.createIterator();
while (historyIterator.hasNext()) {
  console.log(`  ${historyIterator.next()}`);
}

// 4. Set — Favorites
console.log("\n4. FAVORITE PLAYLIST (Set — unique songs)");
const favorites = new FavoritePlaylist();
[song1, song3, song5].forEach((s) => favorites.addFavorite(s));

console.log("\nFavorite songs:");
const favIterator = favorites.createIterator();
while (favIterator.hasNext()) {
  console.log(`  ${favIterator.next()}`);
}

console.log("\n=== Demonstration Complete ===");
