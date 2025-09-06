namespace BridgeDesignPattern.Example4;

public abstract class Vehicle
{
	protected Workshop _workShop1;
	protected Workshop _workShop2;

	protected Vehicle(Workshop workshop1, Workshop workshop2)
	{
		_workShop1 = workshop1;
		_workShop2 = workshop2;
	}

	public abstract void Manufacture();
}
