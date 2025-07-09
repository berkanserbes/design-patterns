using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Models.Concrete;

public class WindowsButton : Button
{
	public override void Render()
	{
		Console.WriteLine("Rendering Windows Button");
	}
	public override void OnClick()
	{
		Console.WriteLine("Windows Button Clicked");
	}
}