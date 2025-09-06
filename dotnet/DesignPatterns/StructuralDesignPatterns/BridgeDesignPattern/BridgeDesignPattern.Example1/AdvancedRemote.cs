namespace BridgeDesignPattern.Example1;

public class AdvancedRemote : Remote
{
	public AdvancedRemote(IDevice device) : base(device)
	{
	}
	public void Mute()
	{
		if (_device.IsEnabled)
			_device.Volume = 0;
	}
}