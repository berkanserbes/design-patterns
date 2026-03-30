package creational.abstractfactory.example1;

import creational.abstractfactory.example1.factory.abstracts.GUIFactory;
import creational.abstractfactory.example1.factory.concretes.*;

public class GUIFactoryProvider {
    public static GUIFactory getFactory(String platform) {
        return switch (platform.toLowerCase()) {
            case "windows" -> new WindowsFactory();
            case "mac"     -> new MacFactory();
            case "linux"   -> new LinuxFactory();
            default        -> throw new IllegalArgumentException("Invalid platform: " + platform);
        };
    }
}
