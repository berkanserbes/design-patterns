package behavioral.mediator.example1;

import java.util.*;

public class AirTrafficControlTower implements IMediator {
    private final List<Aircraft> registeredAircraft = new ArrayList<>();
    private final Queue<Aircraft> landingQueue = new ArrayDeque<>();
    private final Queue<Aircraft> takeoffQueue = new ArrayDeque<>();
    private boolean runwayAvailable = true;

    @Override
    public void registerAircraft(Aircraft aircraft) {
        registeredAircraft.add(aircraft);
        System.out.println("[ATC] " + aircraft.getCallSign() + " (" + aircraft.getAircraftType() + ") registered.");
    }

    @Override
    public void sendMessage(String message, Aircraft sender) {
        System.out.println("[ATC] Broadcasting from " + sender.getCallSign() + ": " + message);
        for (Aircraft ac : registeredAircraft) {
            if (ac != sender) {
                ac.receive(message);
            }
        }
    }

    @Override
    public void requestLanding(Aircraft aircraft) {
        if (runwayAvailable) {
            runwayAvailable = false;
            System.out.println("[ATC] Runway cleared for " + aircraft.getCallSign() + ". CLEARED TO LAND.");
            processRunway(aircraft, "Landing");
        } else {
            landingQueue.add(aircraft);
            System.out.println("[ATC] " + aircraft.getCallSign() + " added to landing queue (position " + landingQueue.size() + ").");
        }
    }

    @Override
    public void requestTakeoff(Aircraft aircraft) {
        if (runwayAvailable) {
            runwayAvailable = false;
            System.out.println("[ATC] Runway cleared for " + aircraft.getCallSign() + ". CLEARED FOR TAKEOFF.");
            processRunway(aircraft, "Takeoff");
        } else {
            takeoffQueue.add(aircraft);
            System.out.println("[ATC] " + aircraft.getCallSign() + " added to takeoff queue (position " + takeoffQueue.size() + ").");
        }
    }

    private void processRunway(Aircraft aircraft, String operation) {
        System.out.println("[ATC] " + aircraft.getCallSign() + " - " + operation + " in progress...");
        // Simulate runway operation (synchronous, short delay)
        try { Thread.sleep(500); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        System.out.println("[ATC] " + aircraft.getCallSign() + " - " + operation + " complete. Runway now available.");
        runwayAvailable = true;
        processNextInQueue();
    }

    private void processNextInQueue() {
        if (!landingQueue.isEmpty()) {
            Aircraft next = landingQueue.poll();
            System.out.println("[ATC] Processing next in landing queue: " + next.getCallSign());
            requestLanding(next);
        } else if (!takeoffQueue.isEmpty()) {
            Aircraft next = takeoffQueue.poll();
            System.out.println("[ATC] Processing next in takeoff queue: " + next.getCallSign());
            requestTakeoff(next);
        }
    }
}
