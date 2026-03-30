package structural.bridge.example1;

public class Radio implements IDevice {
    private boolean enabled;
    private int volume = 5;
    private int channel = 88;

    @Override public boolean isEnabled() { return enabled; }
    @Override public int getVolume() { return volume; }
    @Override public void setVolume(int volume) { this.volume = volume; }
    @Override public int getChannel() { return channel; }
    @Override public void setChannel(int channel) { this.channel = channel; }
    @Override public void enable() { enabled = true; }
    @Override public void disable() { enabled = false; }
}
