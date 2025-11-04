namespace ObserverDesignPattern.Example1;

public class Follower : IObserver<Article>
{
    public string Email { get; }
    public string Name { get; }

    public Follower(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void Update(Article article)
    {
        Console.WriteLine($"Email sent to {Email}: '{article.Title}' by author at {article.PublishedAt}");
    }
}