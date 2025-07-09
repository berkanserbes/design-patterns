using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Models.Concrete;

public class LinuxButton : Button
{
	public override void Render()
	{
		Console.WriteLine("Rendering Linux Button");
	}
	public override void OnClick()
	{
		Console.WriteLine("Linux Button Clicked");
	}
}
