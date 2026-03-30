package behavioral.iterator.example3;

import java.time.Duration;

public class Song {
    private String id;
    private String title;
    private String artist;
    private String album;
    private Duration duration;
    private String genre;

    public Song() {}

    public Song(String id, String title, String artist, String album, Duration duration, String genre) {
        this.id = id; this.title = title; this.artist = artist;
        this.album = album; this.duration = duration; this.genre = genre;
    }

    public String getId() { return id; }
    public String getTitle() { return title; }
    public String getArtist() { return artist; }
    public String getAlbum() { return album; }
    public Duration getDuration() { return duration; }
    public String getGenre() { return genre; }

    @Override
    public String toString() {
        long secs = duration.getSeconds();
        return String.format("%s - %s (%02d:%02d)", title, artist, secs / 60, secs % 60);
    }
}
