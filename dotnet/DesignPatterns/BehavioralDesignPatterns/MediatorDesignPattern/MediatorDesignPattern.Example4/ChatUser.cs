namespace MediatorDesignPattern.Example4;

/// <summary>
/// Concrete Colleague - Chat participant
/// </summary>
public class ChatUser : User
{
    public ChatUser(IChatMediator mediator, string name) 
        : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"[{Name}] Sending: {message}");
        Mediator.SendMessage(message, this);
    }

    public override void SendPrivate(string message, User receiver)
    {
        Console.WriteLine($"[{Name}] Sending private to {receiver.Name}: {message}");
        Mediator.SendPrivateMessage(message, this, receiver);
    }

    public override void Receive(string message, User sender)
    {
        Console.WriteLine($"[{Name}] Received from {sender.Name}: {message}");
    }
}
