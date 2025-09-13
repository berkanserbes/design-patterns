namespace CompositeDesignPattern.Example1;

public class Product : OrderItem
{
	public double Weight { get; set; }
	public Product(string name, double weight) : base(name)
	{
		Weight = weight;
	}

	public override double GetWeight()
	{
		return Weight;
	}
}
