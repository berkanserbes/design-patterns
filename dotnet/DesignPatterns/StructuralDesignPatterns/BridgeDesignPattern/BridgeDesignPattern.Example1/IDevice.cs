namespace BridgeDesignPattern.Example1;

public interface IDevice
{
	bool IsEnabled { get; }
	int Volume { get; set; }
	int Channel { get; set; }

	void Enable();
	void Disable();
}
