namespace ObserverDesignPattern.Example1;

public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedAt { get; set; }

    public Article(string title, string content)
    {
        Title = title;
        Content = content;
        PublishedAt = DateTime.Now;
    }
}