namespace VisitorDesignPattern.Example1;

/// <summary>
/// Concrete Visitor 1: Calculates the tax for each product type.
/// Electronics: 18% VAT
/// Food: 8% VAT (reduced rate)
/// Clothing: 12% VAT
/// </summary>
public class TaxCalculatorVisitor : IVisitor
{
    public decimal TotalTax { get; private set; }

    public void Visit(ElectronicsProduct product)
    {
        decimal tax = product.Price * 0.18m;
        TotalTax += tax;
        Console.WriteLine($"  [Tax] {product.Name}: ${product.Price:F2} x 18% VAT = ${tax:F2}");
    }

    public void Visit(FoodProduct product)
    {
        decimal taxRate = product.IsOrganic ? 0.05m : 0.08m;
        decimal tax = product.Price * taxRate;
        TotalTax += tax;
        string label = product.IsOrganic ? "5% (organic)" : "8%";
        Console.WriteLine($"  [Tax] {product.Name}: ${product.Price:F2} x {label} VAT = ${tax:F2}");
    }

    public void Visit(ClothingProduct product)
    {
        decimal tax = product.Price * 0.12m;
        TotalTax += tax;
        Console.WriteLine($"  [Tax] {product.Name}: ${product.Price:F2} x 12% VAT = ${tax:F2}");
    }
}
