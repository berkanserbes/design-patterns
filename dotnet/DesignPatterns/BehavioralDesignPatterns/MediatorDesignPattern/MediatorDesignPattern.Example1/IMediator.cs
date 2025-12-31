namespace MediatorDesignPattern.Example1;

/// <summary>
/// Mediator interface - Abstraction that centrally manages all communication
/// </summary>
public interface IMediator
{
    void RegisterAircraft(Aircraft aircraft);
    void SendMessage(string message, Aircraft sender);
    void RequestLanding(Aircraft aircraft);
    void RequestTakeoff(Aircraft aircraft);
}
