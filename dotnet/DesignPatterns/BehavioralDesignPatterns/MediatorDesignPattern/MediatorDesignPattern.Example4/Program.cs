using MediatorDesignPattern.Example4;

// Create the mediator (Chat Room)
var chatRoom = new ChatRoom("Design Patterns Discussion");

Console.WriteLine();

// Create users and register them
var alice = new ChatUser(chatRoom, "Alice");
chatRoom.RegisterUser(alice);

var bob = new ChatUser(chatRoom, "Bob");
chatRoom.RegisterUser(bob);

var charlie = new ChatUser(chatRoom, "Charlie");
chatRoom.RegisterUser(charlie);

Console.WriteLine("\n--- Group Messages ---\n");

// Users send messages through the mediator
alice.Send("Hello everyone!");

Console.WriteLine();

bob.Send("Hi Alice! How are you?");

Console.WriteLine();

charlie.Send("Hey team!");

Console.WriteLine("\n--- Private Messages ---\n");

// Private messaging
alice.SendPrivate("Can we discuss the project later?", bob);

Console.WriteLine();

bob.SendPrivate("Sure, I will be available at 3 PM.", alice);
