package structural.bridge.example1;

public interface IDevice {
    boolean isEnabled();
    int getVolume();
    void setVolume(int volume);
    int getChannel();
    void setChannel(int channel);
    void enable();
    void disable();
}
