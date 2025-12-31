namespace MediatorDesignPattern.Example1;

/// <summary>
/// Concrete Mediator - Air Traffic Control Tower
/// Coordinates all communication between aircraft
/// </summary>
public class AirTrafficControlTower : IMediator
{
    private readonly List<Aircraft> _aircrafts = new();
    private readonly Queue<Aircraft> _landingQueue = new();
    private readonly Queue<Aircraft> _takeoffQueue = new();
    private bool _runwayAvailable = true;

    public void RegisterAircraft(Aircraft aircraft)
    {
        _aircrafts.Add(aircraft);
        Console.WriteLine($"[TOWER] {aircraft.CallSign} ({aircraft.AircraftType}) registered to the system.");
    }

    public void SendMessage(string message, Aircraft sender)
    {
        // Relay message to all aircraft except the sender
        foreach (var aircraft in _aircrafts.Where(a => a != sender))
        {
            aircraft.Receive($"{sender.CallSign}: {message}");
        }
    }

    public void RequestLanding(Aircraft aircraft)
    {
        if (_runwayAvailable && _landingQueue.Count == 0)
        {
            _runwayAvailable = false;
            Console.WriteLine($"[TOWER] {aircraft.CallSign}, cleared for landing. Runway is clear.");
            
            // Notify other aircraft
            foreach (var other in _aircrafts.Where(a => a != aircraft))
            {
                other.Receive($"[TOWER] {aircraft.CallSign} is landing, please hold.");
            }

            // Simulation: Runway will be available after 3 seconds
            Task.Delay(3000).ContinueWith(_ =>
            {
                _runwayAvailable = true;
                Console.WriteLine($"[TOWER] {aircraft.CallSign} landing completed. Runway is clear.");
                ProcessNextInQueue();
            });
        }
        else
        {
            _landingQueue.Enqueue(aircraft);
            Console.WriteLine($"[TOWER] {aircraft.CallSign}, runway is busy. You are #{_landingQueue.Count} in queue.");
            aircraft.Receive($"[TOWER] Please hold, you will be notified when it's your turn.");
        }
    }

    public void RequestTakeoff(Aircraft aircraft)
    {
        if (_runwayAvailable && _takeoffQueue.Count == 0 && _landingQueue.Count == 0)
        {
            _runwayAvailable = false;
            Console.WriteLine($"[TOWER] {aircraft.CallSign}, cleared for takeoff. Have a safe flight!");
            
            // Notify other aircraft
            foreach (var other in _aircrafts.Where(a => a != aircraft))
            {
                other.Receive($"[TOWER] {aircraft.CallSign} is taking off.");
            }

            // Simulation: Runway will be available after 2 seconds
            Task.Delay(2000).ContinueWith(_ =>
            {
                _runwayAvailable = true;
                Console.WriteLine($"[TOWER] {aircraft.CallSign} takeoff completed. Runway is clear.");
                ProcessNextInQueue();
            });
        }
        else
        {
            _takeoffQueue.Enqueue(aircraft);
            Console.WriteLine($"[TOWER] {aircraft.CallSign}, runway is busy or landing has priority. You are #{_takeoffQueue.Count} in queue.");
            aircraft.Receive($"[TOWER] Please hold, you will be notified when it's your turn.");
        }
    }

    private void ProcessNextInQueue()
    {
        // Landing has priority
        if (_landingQueue.Count > 0)
        {
            var nextAircraft = _landingQueue.Dequeue();
            Console.WriteLine($"[TOWER] Calling next aircraft: {nextAircraft.CallSign}");
            RequestLanding(nextAircraft);
        }
        else if (_takeoffQueue.Count > 0)
        {
            var nextAircraft = _takeoffQueue.Dequeue();
            Console.WriteLine($"[TOWER] Calling next aircraft: {nextAircraft.CallSign}");
            RequestTakeoff(nextAircraft);
        }
    }
}
