namespace BridgeDesignPattern.Example1;

public class Remote
{
	protected readonly IDevice _device;

	public Remote(IDevice device)
	{
		_device = device;
	}

	public void TogglePower()
	{
		if (_device.IsEnabled)
			_device.Disable();

		else _device.Enable();
	}

	public void VolumeUp()
	{
		if (_device.Volume < 100)
			_device.Volume++;
	}

	public void VolumeDown()
	{
		if (_device.Volume > 0)
			_device.Volume--;
	}

	public void ChannelUp()
	{
		_device.Channel++;
	}

	public void ChannelDown()
	{
		if (_device.Channel > 1)
			_device.Channel--;
	}
}
