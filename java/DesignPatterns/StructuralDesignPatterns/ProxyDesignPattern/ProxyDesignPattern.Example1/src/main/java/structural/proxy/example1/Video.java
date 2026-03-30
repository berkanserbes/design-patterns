package structural.proxy.example1;

public class Video {
    private final String id;
    private final String title;
    private final boolean premium;
    private String content;

    public Video(String id, String title, boolean premium) {
        this.id = id;
        this.title = title;
        this.premium = premium;
    }

    public String getId() { return id; }
    public String getTitle() { return title; }
    public boolean isPremium() { return premium; }
    public String getContent() { return content; }
    public void setContent(String content) { this.content = content; }
}
