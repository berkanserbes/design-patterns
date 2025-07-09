namespace AbstractFactoryDesignPattern.Example1;

public class MacDialog : Dialog
{
	public override void Render()
	{
		Console.WriteLine("Rendering Mac Dialog");
	}
	public override void Show()
	{
		Console.WriteLine("Showing Mac Dialog");
	}
	public override void Close()
	{
		Console.WriteLine("Closing Mac Dialog");
	}
}