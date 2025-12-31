using MediatorDesignPattern.Example1;


// Create the Mediator (Air Traffic Control Tower)
var tower = new AirTrafficControlTower();

Console.WriteLine("=== AIRCRAFT REGISTRATION ===");
Console.WriteLine();

// Create aircraft and register them to the system
var turkishAirlines = new CommercialAircraft(tower, "THY-101");
tower.RegisterAircraft(turkishAirlines);

var pegasus = new CommercialAircraft(tower, "PGS-202");
tower.RegisterAircraft(pegasus);

var cargoPlane = new CargoAircraft(tower, "CARGO-303");
tower.RegisterAircraft(cargoPlane);

var emirates = new CommercialAircraft(tower, "EK-404");
tower.RegisterAircraft(emirates);

Console.WriteLine();
Console.WriteLine("=== INTER-AIRCRAFT COMMUNICATION ===");
Console.WriteLine();

// Aircraft communicate with each other through the mediator
turkishAirlines.Send("Hello, approaching the airport.");
Thread.Sleep(500);

pegasus.Send("We are also approaching, fuel status is critical.");
Thread.Sleep(500);

Console.WriteLine();
Console.WriteLine("=== LANDING AND TAKEOFF REQUESTS ===");
Console.WriteLine();

// Multiple aircraft requesting landing simultaneously
turkishAirlines.RequestLanding();
Thread.Sleep(500);

pegasus.RequestLanding();
Thread.Sleep(500);

emirates.RequestLanding();
Thread.Sleep(500);

// An aircraft requesting takeoff
cargoPlane.RequestTakeoff();
Thread.Sleep(500);

Console.WriteLine();
Console.WriteLine("=== RUNWAY OPERATIONS IN PROGRESS ===");
Console.WriteLine("(Please wait, operations will proceed automatically in sequence...)");
Console.WriteLine();

// Wait for operations to complete
Thread.Sleep(15000);