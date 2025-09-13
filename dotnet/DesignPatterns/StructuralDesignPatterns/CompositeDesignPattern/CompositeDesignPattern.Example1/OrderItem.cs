namespace CompositeDesignPattern.Example1;

public abstract class OrderItem
{
	public string Name { get; set; }

	protected OrderItem(string name)
	{
		Name = name;
	}

	public abstract double GetWeight();
}
