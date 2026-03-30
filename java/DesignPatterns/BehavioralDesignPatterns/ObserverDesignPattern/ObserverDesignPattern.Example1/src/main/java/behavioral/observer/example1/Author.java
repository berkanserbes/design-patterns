package behavioral.observer.example1;

import java.util.ArrayList;
import java.util.List;

public class Author implements ISubject<Article> {
    private final String name;
    private final List<IObserver<Article>> followers = new ArrayList<>();

    public Author(String name) { this.name = name; }

    @Override
    public void subscribe(IObserver<Article> observer) { followers.add(observer); }

    @Override
    public void unsubscribe(IObserver<Article> observer) { followers.remove(observer); }

    @Override
    public void notifyObservers(Article data) {
        for (IObserver<Article> f : followers) {
            f.update(data);
        }
    }

    public void publishArticle(Article article) {
        System.out.println("[Author: " + name + "] Published: \"" + article.getTitle() + "\"");
        notifyObservers(article);
    }
}
