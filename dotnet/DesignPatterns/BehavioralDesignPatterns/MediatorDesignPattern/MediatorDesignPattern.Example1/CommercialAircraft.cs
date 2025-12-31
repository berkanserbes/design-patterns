namespace MediatorDesignPattern.Example1;

/// <summary>
/// Concrete Colleague - Commercial passenger aircraft
/// </summary>
public class CommercialAircraft : Aircraft
{
    public CommercialAircraft(IMediator mediator, string callSign) 
        : base(mediator, callSign, "Commercial")
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
