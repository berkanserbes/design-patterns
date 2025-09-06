namespace BridgeDesignPattern.Example3;

public class Square : Shape
{
	public Square(Color color) : base(color)
	{
	}
	public override void Draw()
	{
		Console.WriteLine("Drawing Square");
		_color.Fill();
	}
}
