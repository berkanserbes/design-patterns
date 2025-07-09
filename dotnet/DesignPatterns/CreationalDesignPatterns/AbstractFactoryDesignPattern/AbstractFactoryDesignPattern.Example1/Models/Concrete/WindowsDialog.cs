using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Models.Concrete;

public class WindowsDialog : Dialog
{
	public override void Render()
	{
		Console.WriteLine("Rendering Windows Dialog");
	}
	public override void Show()
	{
		Console.WriteLine("Showing Windows Dialog");
	}
	public override void Close()
	{
		Console.WriteLine("Closing Windows Dialog");
	}
}
