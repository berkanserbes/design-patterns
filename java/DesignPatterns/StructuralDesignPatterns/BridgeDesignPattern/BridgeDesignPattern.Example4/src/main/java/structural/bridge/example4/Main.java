package structural.bridge.example4;

public class Main {
    public static void main(String[] args) {
        Vehicle car = new Car(new Produce(), new Assemble());
        car.manufacture();

        System.out.println("\n" + "*".repeat(20));

        Vehicle bike = new Bike(new Produce(), new Assemble());
        bike.manufacture();
    }
}
