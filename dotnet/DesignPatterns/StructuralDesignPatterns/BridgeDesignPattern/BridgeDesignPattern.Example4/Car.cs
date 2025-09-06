using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Example4;

public class Car : Vehicle
{
	public Car(Workshop workshop1, Workshop workshop2) : base(workshop1, workshop2)
	{
	}

	public override void Manufacture()
	{
		Console.Write("Car");
		_workShop1.Work();
		_workShop2.Work();
	}
}
