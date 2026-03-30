package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Menu;

public class MacMenu extends Menu {
    public void render()           { System.out.println("Rendering Mac Menu"); }
    public void addItem(String item) { System.out.println("Adding '" + item + "' to Mac Menu"); }
}
