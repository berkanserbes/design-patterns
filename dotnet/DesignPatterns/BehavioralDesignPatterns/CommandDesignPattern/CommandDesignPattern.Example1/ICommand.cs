namespace CommandDesignPattern.Example1;

/// <summary>
/// Command interface - defines the Execute and Undo operations
/// </summary>
public interface ICommand
{
    void Execute();
    void Unexecute();
}
