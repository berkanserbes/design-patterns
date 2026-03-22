namespace VisitorDesignPattern.Example1;

/// <summary>
/// Element interface that declares an Accept method to allow visitors to process the element.
/// All concrete product types must implement this interface.
/// </summary>
public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
    void Accept(IVisitor visitor);
}
