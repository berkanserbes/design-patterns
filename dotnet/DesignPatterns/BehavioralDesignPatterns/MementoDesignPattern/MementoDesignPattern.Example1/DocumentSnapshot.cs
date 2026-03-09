namespace MementoDesignPattern.Example1;

/// <summary>
/// Memento: Stores an immutable snapshot of the TextEditor's internal state at a specific point in time.
/// All properties are read-only to preserve encapsulation — no external class can modify the saved state.
/// The Caretaker (DocumentHistory) holds these snapshots but never inspects or modifies their contents.
/// </summary>
public class DocumentSnapshot 
{
    public string Content { get; }
    public string FontName { get; }
    public int FontSize { get; }
    public int CursorPosition { get; }

    public string SnapshotName { get; }
    public DateTime CreatedAt { get; }

    public DocumentSnapshot(string content, string fontName, int fontSize, int cursorPosition, string snapshotName = "Auto-Save")
    {
        Content = content;
        FontName = fontName;
        FontSize = fontSize;
        CursorPosition = cursorPosition;
        SnapshotName = snapshotName;
        CreatedAt = DateTime.Now;
    }
}