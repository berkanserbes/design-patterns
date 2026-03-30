package creational.abstractfactory.example1;

import creational.abstractfactory.example1.factory.abstracts.GUIFactory;

public class Main {
    public static void main(String[] args) {
        System.out.println("GUI Abstract Factory Example");

        String[] platforms = {"Windows", "Mac", "Linux"};

        for (String platform : platforms) {
            System.out.println("\nPlatform: " + platform);
            try {
                GUIFactory factory = GUIFactoryProvider.getFactory(platform);
                Application app = new Application(factory);
                app.createGUI();
                app.runApplication();
            } catch (Exception ex) {
                System.out.println("Error: " + ex.getMessage());
            }
        }
    }
}
