namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Flyweight interface that defines the intrinsic state operations.
/// The intrinsic state is shared between multiple objects and remains constant.
/// In this example, tree type properties (name, color, texture) are intrinsic.
/// </summary>
public interface ITreeType
{
    string Name { get; }
    string Color { get; }
    string Texture { get; }
    
    /// <summary>
    /// Draws the tree at the specified position.
    /// Position (x, y) is extrinsic state - unique to each tree instance.
    /// </summary>
    void Draw(int x, int y);
}
