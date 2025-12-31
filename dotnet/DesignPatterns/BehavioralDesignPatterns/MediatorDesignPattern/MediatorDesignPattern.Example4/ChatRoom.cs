namespace MediatorDesignPattern.Example4;

/// <summary>
/// Concrete Mediator - Chat room that coordinates all messaging
/// </summary>
public class ChatRoom : IChatMediator
{
    private readonly List<User> _users = new();
    private readonly string _roomName;

    public ChatRoom(string roomName)
    {
        _roomName = roomName;
        Console.WriteLine($"[CHAT ROOM] '{_roomName}' created.");
    }

    public void RegisterUser(User user)
    {
        _users.Add(user);
        Console.WriteLine($"[CHAT ROOM] {user.Name} joined the room.");
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users.Where(u => u != sender))
        {
            user.Receive(message, sender);
        }
    }

    public void SendPrivateMessage(string message, User sender, User receiver)
    {
        if (_users.Contains(receiver))
        {
            receiver.Receive($"[Private] {message}", sender);
        }
        else
        {
            Console.WriteLine($"[CHAT ROOM] User {receiver.Name} is not in the room.");
        }
    }
}
