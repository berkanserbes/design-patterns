package structural.bridge.example1;

public class Main {
    public static void main(String[] args) {
        IDevice tv = new Tv();
        Remote remote = new Remote(tv);

        remote.togglePower();
        remote.volumeUp();
        System.out.println("TV Volume: " + tv.getVolume());

        IDevice radio = new Radio();
        AdvancedRemote advRemote = new AdvancedRemote(radio);

        advRemote.togglePower();
        advRemote.mute();
        System.out.println("Radio Volume: " + radio.getVolume());
    }
}
