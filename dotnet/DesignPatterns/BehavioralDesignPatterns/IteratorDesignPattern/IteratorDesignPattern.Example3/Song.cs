namespace IteratorDesignPattern.Example3;

public class Song
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public string Album { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public string Genre { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Title} - {Artist} ({Duration:mm\\:ss})";
    }
}
