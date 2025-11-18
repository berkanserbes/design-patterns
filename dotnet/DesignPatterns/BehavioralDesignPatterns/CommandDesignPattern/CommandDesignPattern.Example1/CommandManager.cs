namespace CommandDesignPattern.Example1;

/// <summary>
/// Invoker - Manages command execution and undo/redo history
/// </summary>
public class CommandManager
{
    private readonly Stack<ICommand> _undoStack = new();
    private readonly Stack<ICommand> _redoStack = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _undoStack.Push(command);
        _redoStack.Clear(); // Clear redo stack when a new command is executed
    }

    public void Undo()
    {
        if (_undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo!");
            return;
        }

        var command = _undoStack.Pop();
        command.Unexecute();
        _redoStack.Push(command);
        Console.WriteLine("Undo completed.");
    }

    public void Redo()
    {
        if (_redoStack.Count == 0)
        {
            Console.WriteLine("Nothing to redo!");
            return;
        }

        var command = _redoStack.Pop();
        command.Execute();
        _undoStack.Push(command);
        Console.WriteLine("Redo completed.");
    }
}
