namespace MediatorDesignPattern.Example1;

/// <summary>
/// Colleague class - Aircraft object
/// Each aircraft communicates through the mediator (tower), not directly with other aircraft
/// </summary>
public abstract class Aircraft
{
    protected IMediator Mediator;
    public string CallSign { get; }
    public string AircraftType { get; }

    protected Aircraft(IMediator mediator, string callSign, string aircraftType)
    {
        Mediator = mediator;
        CallSign = callSign;
        AircraftType = aircraftType;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
    public abstract void RequestLanding();
    public abstract void RequestTakeoff();
}
