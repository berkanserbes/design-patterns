namespace MediatorDesignPattern.Example4;

/// <summary>
/// Mediator interface - Defines the contract for chat room coordination
/// </summary>
public interface IChatMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, User sender);
    void SendPrivateMessage(string message, User sender, User receiver);
}
