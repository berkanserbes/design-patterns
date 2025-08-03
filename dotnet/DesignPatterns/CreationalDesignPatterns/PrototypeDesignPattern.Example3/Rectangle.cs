namespace PrototypeDesignPattern.Example3;

public class Rectangle : Shape
{
	public double Width { get; set; }
	public double Height { get; set; }

	public Rectangle(string color, double x, double y, double width, double height) : base(color, x, y)
	{
		Width = width;
		Height = height;
	}

	private Rectangle(Rectangle other) : base(other.Color, other.X, other.Y)
	{
		Width = other.Width;
		Height = other.Height;
	}

	public override object Clone()
	{
		return new Rectangle(this);
	}

	public override void Display()
	{
		Console.WriteLine($"Rectangle at ({X}, {Y}) with dimensions {Width}x{Height} and color {Color}");
	}
}
