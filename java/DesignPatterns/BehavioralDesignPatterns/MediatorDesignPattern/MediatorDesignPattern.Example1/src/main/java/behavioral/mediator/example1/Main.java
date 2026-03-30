package behavioral.mediator.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Mediator Pattern - Air Traffic Control ===\n");

        AirTrafficControlTower atc = new AirTrafficControlTower();

        Aircraft thy101 = new CommercialAircraft(atc, "THY-101");
        Aircraft pgs202 = new CommercialAircraft(atc, "PGS-202");
        Aircraft cargo303 = new CargoAircraft(atc, "CARGO-303");
        Aircraft ek404 = new CommercialAircraft(atc, "EK-404");

        System.out.println("\n--- Registering Aircraft ---");
        atc.registerAircraft(thy101);
        atc.registerAircraft(pgs202);
        atc.registerAircraft(cargo303);
        atc.registerAircraft(ek404);

        System.out.println("\n--- Communication ---");
        thy101.send("Approaching runway, requesting landing.");
        pgs202.send("Holding at 5000ft.");

        System.out.println("\n--- Landing Requests ---");
        thy101.requestLanding();
        pgs202.requestLanding();
        cargo303.requestLanding();

        System.out.println("\n--- Takeoff Request ---");
        ek404.requestTakeoff();

        System.out.println("\n=== End of Air Traffic Control Demo ===");
    }
}
