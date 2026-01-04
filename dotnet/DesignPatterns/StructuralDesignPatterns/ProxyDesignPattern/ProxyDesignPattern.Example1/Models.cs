namespace ProxyDesignPattern.Example1;

/// <summary>
/// Represents a video in the streaming service.
/// </summary>
public class Video
{
    public string Id { get; }
    public string Title { get; }
    public bool IsPremium { get; }
    public string? Content { get; set; }

    public Video(string id, string title, bool isPremium)
    {
        Id = id;
        Title = title;
        IsPremium = isPremium;
    }
}

/// <summary>
/// Subscription types for users.
/// </summary>
public enum SubscriptionType
{
    Free,
    Premium
}

/// <summary>
/// Represents a user of the streaming service.
/// </summary>
public class User
{
    public string Name { get; }
    public SubscriptionType Subscription { get; }

    public User(string name, SubscriptionType subscription)
    {
        Name = name;
        Subscription = subscription;
    }
}
