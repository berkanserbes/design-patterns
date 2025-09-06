namespace BridgeDesignPattern.Example3;

public class Circle : Shape
{
	public Circle(Color color) : base(color)
	{
	}
	public override void Draw()
	{
		Console.WriteLine("Drawing Circle");
		_color.Fill();
	}
}