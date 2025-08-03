namespace PrototypeDesignPattern.Example3;

public abstract class Shape : ICloneable
{
	public string Color { get; set; } = string.Empty;
	public double X { get; set; }
	public double Y { get; set; }

	protected Shape(string color, double x, double y)
	{
		Color = color;
		X = x;
		Y = y;
	}

	public abstract object Clone();

	public virtual void Display()
	{
		Console.WriteLine($"Shape at ({X}, {Y}) with color {Color}");
	}
}
