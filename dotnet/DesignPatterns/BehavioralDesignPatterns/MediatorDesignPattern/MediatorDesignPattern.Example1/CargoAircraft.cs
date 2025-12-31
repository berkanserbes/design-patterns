namespace MediatorDesignPattern.Example1;

/// <summary>
/// Concrete Colleague - Cargo aircraft
/// </summary>
public class CargoAircraft : Aircraft
{
    public CargoAircraft(IMediator mediator, string callSign) 
        : base(mediator, callSign, "Cargo")
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"[{CallSign}] Sending: {message}");
        Mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"[{CallSign}] Received: {message}");
    }

    public override void RequestLanding()
    {
        Console.WriteLine($"[{CallSign}] Requesting landing clearance...");
        Mediator.RequestLanding(this);
    }

    public override void RequestTakeoff()
    {
        Console.WriteLine($"[{CallSign}] Requesting takeoff clearance...");
        Mediator.RequestTakeoff(this);
    }
}
