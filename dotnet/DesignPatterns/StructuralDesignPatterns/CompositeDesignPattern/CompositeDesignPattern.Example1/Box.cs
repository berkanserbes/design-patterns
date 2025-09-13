namespace CompositeDesignPattern.Example1;

public class Box : OrderItem
{
	private readonly List<OrderItem> _items = new();
	private readonly double _boxWeight;

	public Box(string name, double boxWeight = 100) : base(name)
	{
		_boxWeight = boxWeight;
	}

	public override double GetWeight()
	{
		return _boxWeight + _items.Sum(i => i.GetWeight());
	}

	public void AddItem(OrderItem item)
	{
		_items.Add(item);
	}

	public void RemoveItem(OrderItem item)
	{
		_items.Remove(item);
	}
}
