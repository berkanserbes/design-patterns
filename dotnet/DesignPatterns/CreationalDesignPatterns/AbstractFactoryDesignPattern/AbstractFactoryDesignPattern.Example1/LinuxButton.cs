namespace AbstractFactoryDesignPattern.Example1;

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
