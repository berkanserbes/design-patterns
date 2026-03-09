namespace MementoDesignPattern.Example1;

/// <summary>
/// Extended Caretaker: Manages multiple TextEditor documents and their independent history chains.
/// Each document is registered with its own dedicated DocumentHistory (Caretaker) instance,
/// meaning undo/redo operations on one document never affect any other document.
/// This demonstrates how the Memento pattern scales naturally to multi-document environments,
/// such as a code editor with multiple open tabs.
/// </summary>
public class WorkspaceManager 
{
    private readonly Dictionary<string, DocumentHistory> _documentHistories = new();

    public void RegisterDocument(TextEditor textEditor) 
    {
        if(_documentHistories.ContainsKey(textEditor.DocumentId))
        {
            throw new InvalidOperationException("Document is already registered.");
        }

        _documentHistories[textEditor.DocumentId] = new DocumentHistory(textEditor);

    }

    public DocumentHistory GetDocumentHistory(string documentId)
    {
        if(!_documentHistories.TryGetValue(documentId, out var history))
        {
            throw new KeyNotFoundException("Document not found.");
        }
        return history;
    }
}
