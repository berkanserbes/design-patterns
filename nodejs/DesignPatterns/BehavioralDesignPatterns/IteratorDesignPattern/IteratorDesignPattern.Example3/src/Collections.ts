import { IAggregate, IIterator } from "./Interfaces";
import { Song } from "./Song";

// ─── ArtistLibrary (Map<string, Song[]>) ────────────────────────────────────

class ArtistLibraryIterator implements IIterator<Song> {
  private readonly _allSongs: Song[];
  private _index = 0;

  constructor(library: ArtistLibrary) {
    this._allSongs = [...library.getArtistSongs().values()].flat();
  }
  hasNext(): boolean { return this._index < this._allSongs.length; }
  next(): Song { return this._allSongs[this._index++]; }
  reset(): void { this._index = 0; }
}

class SpecificArtistIterator implements IIterator<Song> {
  private readonly _songs: Song[];
  private _index = 0;

  constructor(library: ArtistLibrary, artist: string) {
    this._songs = library.getArtistSongs().get(artist) ?? [];
  }
  hasNext(): boolean { return this._index < this._songs.length; }
  next(): Song { return this._songs[this._index++]; }
  reset(): void { this._index = 0; }
}

export class ArtistLibrary implements IAggregate<Song> {
  private readonly _artistSongs: Map<string, Song[]> = new Map();

  addSong(song: Song): void {
    if (!this._artistSongs.has(song.artist)) {
      this._artistSongs.set(song.artist, []);
    }
    this._artistSongs.get(song.artist)!.push(song);
  }

  getArtistSongs(): Map<string, Song[]> {
    return this._artistSongs;
  }

  createIterator(): IIterator<Song> {
    return new ArtistLibraryIterator(this);
  }

  createArtistIterator(artist: string): IIterator<Song> {
    return new SpecificArtistIterator(this, artist);
  }
}

// ─── PlayQueue (Array used as FIFO queue) ────────────────────────────────────

class QueueIterator implements IIterator<Song> {
  private readonly _songs: Song[];
  private _index = 0;

  constructor(queue: PlayQueue) {
    this._songs = [...queue.getQueue()];
  }
  hasNext(): boolean { return this._index < this._songs.length; }
  next(): Song { return this._songs[this._index++]; }
  reset(): void { this._index = 0; }
}

export class PlayQueue implements IAggregate<Song> {
  private readonly _queue: Song[] = [];

  enqueue(song: Song): void { this._queue.push(song); }
  getQueue(): Song[] { return this._queue; }

  createIterator(): IIterator<Song> {
    return new QueueIterator(this);
  }
}

// ─── ListeningHistory (Stack — most recent first) ────────────────────────────

class HistoryIterator implements IIterator<Song> {
  private readonly _songs: Song[];
  private _index = 0;

  constructor(history: ListeningHistory) {
    // Reverse so most recently added comes first (LIFO)
    this._songs = [...history.getHistory()].reverse();
  }
  hasNext(): boolean { return this._index < this._songs.length; }
  next(): Song { return this._songs[this._index++]; }
  reset(): void { this._index = 0; }
}

export class ListeningHistory implements IAggregate<Song> {
  private readonly _history: Song[] = [];

  addToHistory(song: Song): void { this._history.push(song); }
  getHistory(): Song[] { return this._history; }

  createIterator(): IIterator<Song> {
    return new HistoryIterator(this);
  }
}

// ─── FavoritePlaylist (Set — unique songs) ───────────────────────────────────

class FavoriteIterator implements IIterator<Song> {
  private readonly _songs: Song[];
  private _index = 0;

  constructor(playlist: FavoritePlaylist) {
    this._songs = [...playlist.getFavorites()];
  }
  hasNext(): boolean { return this._index < this._songs.length; }
  next(): Song { return this._songs[this._index++]; }
  reset(): void { this._index = 0; }
}

export class FavoritePlaylist implements IAggregate<Song> {
  private readonly _favorites: Set<Song> = new Set();

  addFavorite(song: Song): boolean {
    if (this._favorites.has(song)) return false;
    this._favorites.add(song);
    return true;
  }

  removeFavorite(song: Song): boolean {
    return this._favorites.delete(song);
  }

  getFavorites(): Set<Song> { return this._favorites; }

  createIterator(): IIterator<Song> {
    return new FavoriteIterator(this);
  }
}
