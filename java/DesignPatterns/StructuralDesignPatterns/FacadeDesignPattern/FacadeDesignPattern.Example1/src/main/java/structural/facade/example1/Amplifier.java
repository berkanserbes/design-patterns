package structural.facade.example1;

public class Amplifier {
    public void on() { System.out.println("Amplifier is turned on."); }
    public void off() { System.out.println("Amplifier is turned off."); }
    public void setVolume(int level) { System.out.println("Amplifier volume is set to " + level + "."); }
}
