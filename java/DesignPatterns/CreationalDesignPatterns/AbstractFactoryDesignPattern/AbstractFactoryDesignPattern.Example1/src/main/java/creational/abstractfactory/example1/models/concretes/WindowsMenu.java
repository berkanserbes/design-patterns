package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Menu;

public class WindowsMenu extends Menu {
    public void render()           { System.out.println("Rendering Windows Menu"); }
    public void addItem(String item) { System.out.println("Adding '" + item + "' to Windows Menu"); }
}
