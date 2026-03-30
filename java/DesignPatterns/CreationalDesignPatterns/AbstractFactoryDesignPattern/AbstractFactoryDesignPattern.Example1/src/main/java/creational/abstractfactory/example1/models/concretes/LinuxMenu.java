package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Menu;

public class LinuxMenu extends Menu {
    public void render()           { System.out.println("Rendering Linux Menu"); }
    public void addItem(String item) { System.out.println("Adding '" + item + "' to Linux Menu"); }
}
