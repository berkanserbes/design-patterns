namespace AbstractFactoryDesignPattern.Example1;

public class MacMenu : Menu
{
	public override void Render()
	{
		Console.WriteLine("Rendering Mac Menu");
	}
	public override void AddItem(string item)
	{
		Console.WriteLine($"Adding '{item}' to Mac Menu");
	}
}
