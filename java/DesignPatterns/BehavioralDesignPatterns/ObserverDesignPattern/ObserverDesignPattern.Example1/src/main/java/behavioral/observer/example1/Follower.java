package behavioral.observer.example1;

public class Follower implements IObserver<Article> {
    private final String name;
    private final String email;

    public Follower(String name, String email) {
        this.name = name;
        this.email = email;
    }

    @Override
    public void update(Article article) {
        System.out.println("  [Email to " + email + "] Dear " + name + ", new article published: \"" + article.getTitle() + "\"");
    }
}
