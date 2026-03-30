package creational.abstractfactory.example1;

import creational.abstractfactory.example1.factory.abstracts.GUIFactory;
import creational.abstractfactory.example1.models.abstracts.*;

public class Application {
    private final GUIFactory factory;
    private Button button;
    private Menu menu;
    private Dialog dialog;

    public Application(GUIFactory factory) {
        this.factory = factory;
    }

    public void createGUI() {
        button = factory.createButton();
        menu   = factory.createMenu();
        dialog = factory.createDialog();
    }

    public void runApplication() {
        System.out.println("=== Starting GUI Application ===");
        button.render();
        menu.render();
        dialog.render();

        System.out.println("\n=== User Interaction ===");
        menu.addItem("File");
        menu.addItem("Edit");
        menu.addItem("Appearance");

        dialog.show();
        button.onClick();
        dialog.close();
    }
}
