namespace VisitorDesignPattern.Example1;

/// <summary>
/// Concrete Visitor 2: Applies discounts based on product type and properties.
/// Electronics: 5% discount (standard)
/// Food: 10% discount for organic products, 3% for others
/// Clothing: 15% discount (seasonal sale)
/// </summary>
public class DiscountVisitor : IVisitor
{
    public decimal TotalDiscount { get; private set; }

    public void Visit(ElectronicsProduct product)
    {
        decimal discount = product.Price * 0.05m;
        TotalDiscount += discount;
        Console.WriteLine($"  [Discount] {product.Name}: 5% discount = -${discount:F2}");
    }

    public void Visit(FoodProduct product)
    {
        decimal discountRate = product.IsOrganic ? 0.10m : 0.03m;
        decimal discount = product.Price * discountRate;
        TotalDiscount += discount;
        string label = product.IsOrganic ? "10% (organic promotion)" : "3%";
        Console.WriteLine($"  [Discount] {product.Name}: {label} discount = -${discount:F2}");
    }

    public void Visit(ClothingProduct product)
    {
        decimal discount = product.Price * 0.15m;
        TotalDiscount += discount;
        Console.WriteLine($"  [Discount] {product.Name} (Size: {product.Size}): 15% seasonal sale = -${discount:F2}");
    }
}
