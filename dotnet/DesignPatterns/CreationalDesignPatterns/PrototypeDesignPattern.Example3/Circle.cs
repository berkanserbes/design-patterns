namespace PrototypeDesignPattern.Example3;

public class Circle : Shape
{
	public double Radius { get; set; }

	public Circle(string color, double x, double y, double radius) : base(color, x, y)
	{
		Radius = radius;
	}

	private Circle(Circle other) : base(other.Color, other.X, other.Y)
	{
		Radius = other.Radius;
	}

	public override object Clone()
	{
		return new Circle(this);
	}

	public override void Display()
	{
		Console.WriteLine($"Circle at ({X}, {Y}) with color {Color} and radius {Radius}");
	}
}
