namespace BridgeDesignPattern.Example1;

public class Tv : IDevice
{
	public bool IsEnabled { get; private set; }
	public int Volume { get; set; } = 10;
	public int Channel { get; set; } = 1;
	public void Enable()
	{
		IsEnabled = true;
	}
	public void Disable()
	{
		IsEnabled = false;
	}
}
