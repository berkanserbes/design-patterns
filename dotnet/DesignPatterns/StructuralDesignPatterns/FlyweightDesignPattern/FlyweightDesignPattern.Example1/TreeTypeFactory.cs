namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Flyweight Factory that manages the creation and reuse of flyweight objects.
/// It ensures that flyweights are shared properly and returns existing ones when possible.
/// </summary>
public class TreeTypeFactory
{
    private readonly Dictionary<string, ITreeType> _treeTypes = new();

    /// <summary>
    /// Returns an existing TreeType or creates a new one if it doesn't exist.
    /// The key is a combination of name, color, and texture.
    /// </summary>
    public ITreeType GetTreeType(string name, string color, string texture)
    {
        var key = $"{name}_{color}_{texture}";
        
        if (!_treeTypes.TryGetValue(key, out var treeType))
        {
            treeType = new TreeType(name, color, texture);
            _treeTypes[key] = treeType;
        }
        
        return treeType;
    }

    /// <summary>
    /// Returns the number of unique tree types created (flyweight objects in memory).
    /// </summary>
    public int GetTreeTypeCount() => _treeTypes.Count;
}
