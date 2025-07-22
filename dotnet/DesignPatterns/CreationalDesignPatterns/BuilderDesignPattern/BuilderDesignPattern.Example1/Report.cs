namespace BuilderDesignPattern.Example1;

public class Report
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? Header { get; set; }
    public string? Footer { get; set; }
    public string? Font { get; set; }


    public override string ToString()
    {
        return $"Report:\nTitle: {Title}\nContent: {Content}\nHeader: {Header}\nFooter: {Footer}\nFont: {Font}";
    }

}