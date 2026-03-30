package structural.bridge.example1;

public class Remote {
    protected final IDevice device;

    public Remote(IDevice device) {
        this.device = device;
    }

    public void togglePower() {
        if (device.isEnabled()) device.disable();
        else device.enable();
    }

    public void volumeUp() {
        if (device.getVolume() < 100) device.setVolume(device.getVolume() + 1);
    }

    public void volumeDown() {
        if (device.getVolume() > 0) device.setVolume(device.getVolume() - 1);
    }

    public void channelUp() {
        device.setChannel(device.getChannel() + 1);
    }

    public void channelDown() {
        if (device.getChannel() > 1) device.setChannel(device.getChannel() - 1);
    }
}
