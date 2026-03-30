package behavioral.command.example2;

public class Light {
    private final String location;
    private boolean isOn = false;
    private int brightness = 50;

    public Light(String location) { this.location = location; }

    public void turnOn() {
        isOn = true;
        System.out.println(location + " lambasi acildi. (Parlaklik: " + brightness + "%)");
    }

    public void turnOff() {
        isOn = false;
        System.out.println(location + " lambasi kapatildi.");
    }

    public void increaseBrightness() {
        brightness = Math.min(100, brightness + 10);
        System.out.println(location + " parlaklik arttirildi: " + brightness + "%");
    }

    public void decreaseBrightness() {
        brightness = Math.max(0, brightness - 10);
        System.out.println(location + " parlaklik azaltildi: " + brightness + "%");
    }

    public int getBrightness() { return brightness; }
}
