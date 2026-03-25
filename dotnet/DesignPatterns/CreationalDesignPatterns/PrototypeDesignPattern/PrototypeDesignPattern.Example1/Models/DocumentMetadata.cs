namespace PrototypeDesignPattern.Example1.Models;

public class DocumentMetadata
{
    public string Author { get; set; } = string.Empty;
    public string Version { get; set; } = "1.0";
    public List<string> Tags { get; set; } = new();
    public Dictionary<string, string> CustomProperties { get; set; } = new();
    public int PageCount { get; set; } = 1;

    public override string ToString() =>
        $"Author: {Author}, Version: {Version}, Pages: {PageCount}, Tags: [{string.Join(", ", Tags)}]";
}