package structural.facade.example1;

public class DvdPlayer {
    public void on() { System.out.println("DVD player is turned on."); }
    public void off() { System.out.println("DVD player is turned off."); }
    public void play(String movie) { System.out.println("Playing movie: '" + movie + "'."); }
    public void stop() { System.out.println("Movie playback stopped."); }
}
