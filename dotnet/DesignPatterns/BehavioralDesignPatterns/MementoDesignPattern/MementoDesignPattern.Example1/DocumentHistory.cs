namespace MementoDesignPattern.Example1;

/// <summary>
/// Caretaker: Manages the history of snapshots for a single TextEditor document.
/// It holds two stacks — one for undo operations and one for redo operations —
/// and orchestrates saving (Backup), reverting (Undo), and re-applying (Redo) states.
/// Crucially, it never reads or modifies the contents of a DocumentSnapshot;
/// it only stores and retrieves them, keeping the Memento's encapsulation intact.
/// </summary>
public class DocumentHistory 
{
    private readonly TextEditor _textEditor;

    // Undo / Redo stacks
    private readonly Stack<DocumentSnapshot> _undoStack = new();
    private readonly Stack<DocumentSnapshot> _redoStack = new();

    public DocumentHistory(TextEditor textEditor)
    {
        _textEditor = textEditor;
    }

    public void Backup(string snapshotName = "Auto-Save")
    {
        _undoStack.Push(_textEditor.CreateSnapshot(snapshotName));
        _redoStack.Clear();
    }

    public void Undo()
    {
        if(_undoStack.Count == 0)
        {
            Console.WriteLine("No more undo steps available.");
            return;
        }

        // Save current state to redo stack before undoing
        _redoStack.Push(_textEditor.CreateSnapshot("Before Undo"));

        // Restore previous state from undo stack
        var previousSnapshot = _undoStack.Pop();
        _textEditor.RestoreFromSnapshot(previousSnapshot);
    }

    public void Redo()
    {
        if(_redoStack.Count == 0)
        {
            Console.WriteLine("No more redo steps available.");
            return;
        }

        _undoStack.Push(_textEditor.CreateSnapshot("Before Redo"));

        // Restore next state from redo stack
        var nextSnapshot = _redoStack.Pop();
        _textEditor.RestoreFromSnapshot(nextSnapshot);
    }
}