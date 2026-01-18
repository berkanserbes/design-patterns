namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Concrete Flyweight class that stores the intrinsic (shared) state.
/// Multiple Tree objects can share the same TreeType instance.
/// This significantly reduces memory usage when rendering a forest with many similar trees.
/// </summary>
public class TreeType : ITreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"  Drawing '{Name}' tree at ({x}, {y}) - Color: {Color}, Texture: {Texture}");
    }
}
