namespace BridgeDesignPattern.Example1;

public class Radio : IDevice
{
	public bool IsEnabled { get; private set; }
	public int Volume { get; set; } = 5;
	public int Channel { get; set; } = 88;
	public void Enable()
	{
		IsEnabled = true;
	}
	public void Disable()
	{
		IsEnabled = false;
	}
}
