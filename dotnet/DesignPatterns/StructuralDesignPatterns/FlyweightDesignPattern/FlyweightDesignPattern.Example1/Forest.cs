namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Client class that uses the Flyweight pattern.
/// The Forest manages trees and uses the factory to ensure tree types are shared.
/// </summary>
public class Forest
{
    private readonly List<Tree> _trees = new();
    private readonly List<SpecialTree> _specialTrees = new();
    private readonly TreeTypeFactory _factory = new();

    /// <summary>
    /// Plants a regular tree. The TreeType is obtained from the factory (shared).
    /// </summary>
    public void PlantTree(int x, int y, string name, string color, string texture)
    {
        var type = _factory.GetTreeType(name, color, texture);
        var tree = new Tree(x, y, type);
        _trees.Add(tree);
    }

    /// <summary>
    /// Plants a special tree with unique features. Uses base type from factory.
    /// </summary>
    public void PlantSpecialTree(int x, int y, string specialName, string uniqueFeature, 
        string baseName, string baseColor, string baseTexture)
    {
        var baseType = _factory.GetTreeType(baseName, baseColor, baseTexture);
        var specialTree = new SpecialTree(x, y, specialName, uniqueFeature, baseType);
        _specialTrees.Add(specialTree);
    }

    /// <summary>
    /// Draws all trees in the forest.
    /// </summary>
    public void Draw()
    {
        Console.WriteLine("\n=== Forest Rendering ===");
        Console.WriteLine("Regular Trees:");
        foreach (var tree in _trees)
        {
            tree.Draw();
        }

        if (_specialTrees.Count > 0)
        {
            Console.WriteLine("\nSpecial Trees:");
            foreach (var tree in _specialTrees)
            {
                tree.Draw();
            }
        }
    }

    /// <summary>
    /// Displays memory usage statistics.
    /// </summary>
    public void DisplayStats()
    {
        Console.WriteLine("\n=== Memory Statistics ===");
        Console.WriteLine($"Total trees planted: {_trees.Count + _specialTrees.Count}");
        Console.WriteLine($"  - Regular trees: {_trees.Count}");
        Console.WriteLine($"  - Special trees: {_specialTrees.Count}");
        Console.WriteLine($"Unique TreeType objects in memory: {_factory.GetTreeTypeCount()}");
        Console.WriteLine($"Memory saved by sharing: {_trees.Count - _factory.GetTreeTypeCount()} TreeType objects");
    }
}
