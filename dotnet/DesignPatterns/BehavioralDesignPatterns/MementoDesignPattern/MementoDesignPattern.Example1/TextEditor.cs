namespace MementoDesignPattern.Example1;

/// <summary>
/// Originator: The object whose internal state changes over time and needs to be saved/restored.
/// TextEditor holds the document content, font settings, and cursor position.
/// It can produce a Memento (DocumentSnapshot) capturing its current state via CreateSnapshot(),
/// and restore a previous state from a given Memento via RestoreFromSnapshot().
/// </summary>
public class TextEditor 
{
    public string DocumentId { get; }
    public string Content { get; private set; }
    public string FontName { get; private set; }
    public int FontSize { get; private set; }
    public int CursorPosition { get; private set; }

    public TextEditor(string documentId) 
    {
        DocumentId = documentId;
        Content = string.Empty;
        FontName = "Arial";
        FontSize = 12;
        CursorPosition = 0;
    }

    #region Methods to modify the document

    public void Type(string text)
    {
        Content += text;
        CursorPosition += text.Length;
        Console.WriteLine($"[{DocumentId}] Typed '{text}' --> Content: {Content} | Cursor Position: {CursorPosition}");

    }

    public void ChangeFont(string fontName, int fontSize)
    {
        FontName = fontName;
        FontSize = fontSize;
        Console.WriteLine($"[{DocumentId}] Font changed to {FontName} with size {FontSize}");
    }

    public void MoveCursor(int position)
    {
        CursorPosition = position;
        Console.WriteLine($"[{DocumentId}] Cursor moved to position {CursorPosition}");
    }
    #endregion

    #region Memento-related methods
    public DocumentSnapshot CreateSnapshot(string name = "Auto-Save")
    {
        return new DocumentSnapshot(Content, FontName, FontSize, CursorPosition, name);
    }

    public void RestoreFromSnapshot(DocumentSnapshot documentSnapshot)
    {
        if (documentSnapshot is null) return;

        Content = documentSnapshot.Content;
        FontName = documentSnapshot.FontName;
        FontSize = documentSnapshot.FontSize;
        CursorPosition = documentSnapshot.CursorPosition;

        Console.WriteLine($"[{DocumentId}] Document restored from snapshot '{documentSnapshot.SnapshotName}' ({documentSnapshot.CreatedAt})");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"[{DocumentId}] Content: '{Content}' | Font: {FontName} ({FontSize}pt) | Cursor Position: {CursorPosition}");
    } 
    #endregion
}