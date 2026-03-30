package behavioral.observer.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Observer Pattern - Author/Follower ===\n");

        Author author = new Author("Berkan Serbes");
        Follower ali = new Follower("Ali", "ali@example.com");
        Follower ayse = new Follower("Ayse", "ayse@example.com");

        author.subscribe(ali);
        author.subscribe(ayse);

        author.publishArticle(new Article("Design Patterns in Java", "An overview of design patterns..."));

        System.out.println("\nAli unsubscribed.\n");
        author.unsubscribe(ali);

        author.publishArticle(new Article("Observer Pattern Deep Dive", "Understanding the observer pattern..."));
    }
}
