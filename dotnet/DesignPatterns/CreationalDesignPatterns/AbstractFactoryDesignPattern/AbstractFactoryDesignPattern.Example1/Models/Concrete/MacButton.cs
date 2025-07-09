using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Models.Concrete;

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
