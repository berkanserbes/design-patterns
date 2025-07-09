namespace AbstractFactoryDesignPattern.Example1;

public class LinuxDialog : Dialog
{
	public override void Render()
	{
		Console.WriteLine("Rendering Linux Dialog");
	}
	public override void Show()
	{
		Console.WriteLine("Showing Linux Dialog");
	}
	public override void Close()
	{
		Console.WriteLine("Closing Linux Dialog");
	}
}
