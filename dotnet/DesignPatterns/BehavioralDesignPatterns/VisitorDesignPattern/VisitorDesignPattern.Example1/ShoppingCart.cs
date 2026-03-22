namespace VisitorDesignPattern.Example1;

/// <summary>
/// Shopping cart that acts as an Object Structure, holding a collection of products.
/// It allows visitors to traverse all products without exposing internal implementation.
/// </summary>
public class ShoppingCart
{
    private readonly List<IProduct> _products = new();

    public void AddProduct(IProduct product)
    {
        _products.Add(product);
        Console.WriteLine($"  Added: {product.Name} (${product.Price:F2})");
    }

    public decimal GetSubtotal()
    {
        return _products.Sum(p => p.Price);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var product in _products)
        {
            product.Accept(visitor);
        }
    }
}
