namespace ObserverDesignPattern.Example1;

public class Author : ISubject<Article>
{
    private readonly List<IObserver<Article>> _followers = new();
    public string Name { get; }

    public Author(string name)
    {
        Name = name;
    }

    public void Subscribe(IObserver<Article> observer)
    {
        if (!_followers.Contains(observer))
            _followers.Add(observer);
    }

    public void Unsubscribe(IObserver<Article> observer)
    {
        _followers.Remove(observer);
    }

    public void Notify(Article article)
    {
        foreach (var follower in _followers)
        {
            follower.Update(article);
        }
    }

    public void PublishArticle(string title, string content)
    {
        var article = new Article(title, content);
        Console.WriteLine($"{Name} published a new article: {title}");
        Notify(article);
    }
}