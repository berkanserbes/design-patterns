package structural.facade.example1;

public class Main {
    public static void main(String[] args) {
        Projector projector = new Projector();
        Amplifier amplifier = new Amplifier();
        DvdPlayer dvdPlayer = new DvdPlayer();
        Lights lights = new Lights();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(projector, amplifier, dvdPlayer, lights);

        homeTheater.watchMovie("Inception");
        System.out.println("\nAfter a while...");
        homeTheater.endMovie();
    }
}
