namespace AbstractFactoryDesignPattern.Example1;

public class WindowsMenu : Menu
{
	public override void Render()
	{
		Console.WriteLine("Rendering Windows Menu");
	}
	public override void AddItem(string item)
	{
		Console.WriteLine($"Adding '{item}' to Windows Menu");
	}
}
