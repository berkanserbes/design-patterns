namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Unshared Concrete Flyweight - a tree that cannot be shared.
/// This represents special trees (like decorated trees, landmarks) that have unique properties.
/// Unlike regular flyweights, these objects are not meant to be reused.
/// </summary>
public class SpecialTree
{
    public int X { get; }
    public int Y { get; }
    public string Name { get; }
    public string UniqueFeature { get; }
    private readonly ITreeType _baseType;

    public SpecialTree(int x, int y, string name, string uniqueFeature, ITreeType baseType)
    {
        X = x;
        Y = y;
        Name = name;
        UniqueFeature = uniqueFeature;
        _baseType = baseType;
    }

    public void Draw()
    {
        Console.WriteLine($"  [SPECIAL] '{Name}' at ({X}, {Y}) - {UniqueFeature}");
        Console.WriteLine($"            Base type: {_baseType.Name}, Color: {_baseType.Color}");
    }
}
