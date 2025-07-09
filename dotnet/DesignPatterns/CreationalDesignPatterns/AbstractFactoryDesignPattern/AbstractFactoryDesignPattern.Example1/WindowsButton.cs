namespace AbstractFactoryDesignPattern.Example1;

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