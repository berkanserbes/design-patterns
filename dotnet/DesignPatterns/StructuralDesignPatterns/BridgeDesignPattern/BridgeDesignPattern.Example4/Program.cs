using BridgeDesignPattern.Example4;

Vehicle car = new Car(new Produce(), new Assemble());
car.Manufacture();

Console.WriteLine($"\n{new string('*', 20)}");

Vehicle bike = new Bike(new Produce(), new Assemble());
bike.Manufacture();

Console.ReadLine();