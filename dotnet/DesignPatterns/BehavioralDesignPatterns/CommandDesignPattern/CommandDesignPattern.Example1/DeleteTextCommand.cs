namespace CommandDesignPattern.Example1;

/// <summary>
/// Concrete Command - Delete text command
/// </summary>
public class DeleteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _length;
    private string _deletedText = string.Empty;

    public DeleteTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
    }

    public void Execute()
    {
        // Store the deleted text for undo
        var contentLength = _editor.Content.Length;
        var deleteLength = Math.Min(_length, contentLength);
        
        if (deleteLength > 0)
        {
            _deletedText = _editor.Content.Substring(contentLength - deleteLength);
            _editor.DeleteText(deleteLength);
        }
    }

    public void Unexecute()
    {
        if (!string.IsNullOrEmpty(_deletedText))
        {
            _editor.AppendText(_deletedText);
        }
    }
}
