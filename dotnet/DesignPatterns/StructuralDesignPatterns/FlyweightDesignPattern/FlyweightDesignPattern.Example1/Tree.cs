namespace FlyweightDesignPattern.Example1;

/// <summary>
/// Context class that contains extrinsic (unique) state.
/// Each Tree has its own position (x, y) but shares the TreeType flyweight.
/// This separation allows thousands of trees to share a few TreeType objects.
/// </summary>
public class Tree
{
    public int X { get; }
    public int Y { get; }
    private readonly ITreeType _type;

    public Tree(int x, int y, ITreeType type)
    {
        X = x;
        Y = y;
        _type = type;
    }

    public void Draw()
    {
        _type.Draw(X, Y);
    }
}
