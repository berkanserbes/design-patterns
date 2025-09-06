namespace BridgeDesignPattern.Example4;

public class Bike : Vehicle
{
	public Bike(Workshop workshop1, Workshop workshop2) : base(workshop1, workshop2)
	{
	}

	public override void Manufacture()
	{
		Console.Write("Bike");
		_workShop1.Work();
		_workShop2.Work();
	}
}
