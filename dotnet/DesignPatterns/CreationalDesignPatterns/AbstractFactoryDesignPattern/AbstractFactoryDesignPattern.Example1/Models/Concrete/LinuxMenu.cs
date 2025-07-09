using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Models.Concrete;

public class LinuxMenu : Menu
{
	public override void Render()
	{
		Console.WriteLine("Rendering Linux Menu");
	}
	public override void AddItem(string item)
	{
		Console.WriteLine($"Adding '{item}' to Linux Menu");
	}
}
