namespace CommandDesignPattern.Example1;

/// <summary>
/// Receiver - The text editor that performs the actual operations
/// </summary>
public class TextEditor
{
    private string _content = string.Empty;

    public string Content => _content;

    public void AppendText(string text)
    {
        _content += text;
        Console.WriteLine($"Text added: '{text}'");
    }

    public void DeleteText(int length)
    {
        if (length > _content.Length)
            length = _content.Length;

        _content = _content.Substring(0, _content.Length - length);
        Console.WriteLine($"Deleted {length} characters");
    }

    public void DisplayContent()
    {
        Console.WriteLine($"\n=== Editor Content ===");
        Console.WriteLine($"'{_content}'");
        Console.WriteLine($"=====================\n");
    }
}
