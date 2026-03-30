package behavioral.observer.example1;

import java.time.LocalDateTime;

public class Article {
    private final String title;
    private final String content;
    private final LocalDateTime publishedAt;

    public Article(String title, String content) {
        this.title = title;
        this.content = content;
        this.publishedAt = LocalDateTime.now();
    }

    public String getTitle() { return title; }
    public String getContent() { return content; }
    public LocalDateTime getPublishedAt() { return publishedAt; }
}
