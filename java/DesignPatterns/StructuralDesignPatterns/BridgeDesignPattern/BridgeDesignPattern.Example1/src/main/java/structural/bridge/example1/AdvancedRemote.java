package structural.bridge.example1;

public class AdvancedRemote extends Remote {
    public AdvancedRemote(IDevice device) {
        super(device);
    }

    public void mute() {
        if (device.isEnabled()) device.setVolume(0);
    }
}
