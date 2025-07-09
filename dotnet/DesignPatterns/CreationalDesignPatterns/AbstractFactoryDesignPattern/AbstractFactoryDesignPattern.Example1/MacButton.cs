namespace AbstractFactoryDesignPattern.Example1;

public class MacButton : Button
{
	public override void Render()
	{
		Console.WriteLine("Rendering Mac Button");
	}
	public override void OnClick()
	{
		Console.WriteLine("Mac Button Clicked");
	}
}
