namespace CommandDesignPattern.Example1;

/// <summary>
/// Concrete Command - Insert text command
/// </summary>
public class InsertTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _text;

    public InsertTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.AppendText(_text);
    }

    public void Unexecute()
    {
        _editor.DeleteText(_text.Length);
    }
}
