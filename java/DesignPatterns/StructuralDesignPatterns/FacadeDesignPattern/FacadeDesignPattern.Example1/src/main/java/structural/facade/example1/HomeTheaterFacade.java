package structural.facade.example1;

public class HomeTheaterFacade {
    private final Projector projector;
    private final Amplifier amplifier;
    private final DvdPlayer dvdPlayer;
    private final Lights lights;

    public HomeTheaterFacade(Projector projector, Amplifier amplifier, DvdPlayer dvdPlayer, Lights lights) {
        this.projector = projector;
        this.amplifier = amplifier;
        this.dvdPlayer = dvdPlayer;
        this.lights = lights;
    }

    public void watchMovie(String movie) {
        System.out.println("\n--- Starting Movie Mode ---");
        lights.dim();
        projector.on();
        projector.setWideScreenMode();
        amplifier.on();
        amplifier.setVolume(10);
        dvdPlayer.on();
        dvdPlayer.play(movie);
    }

    public void endMovie() {
        System.out.println("\n--- Shutting Down Movie Mode ---");
        dvdPlayer.stop();
        dvdPlayer.off();
        amplifier.off();
        projector.off();
        lights.on();
    }
}
