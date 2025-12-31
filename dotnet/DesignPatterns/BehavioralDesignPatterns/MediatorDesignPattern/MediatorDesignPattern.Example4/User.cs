namespace MediatorDesignPattern.Example4;

/// <summary>
/// Colleague abstract class - Base class for all chat users
/// </summary>
public abstract class User
{
    protected IChatMediator Mediator;
    public string Name { get; }

    protected User(IChatMediator mediator, string name)
    {
        Mediator = mediator;
        Name = name;
    }

    public abstract void Send(string message);
    public abstract void SendPrivate(string message, User receiver);
    public abstract void Receive(string message, User sender);
}
