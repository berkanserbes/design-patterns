package creational.abstractfactory.example1.factory.concretes;

import creational.abstractfactory.example1.factory.abstracts.GUIFactory;
import creational.abstractfactory.example1.models.abstracts.*;
import creational.abstractfactory.example1.models.concretes.*;

public class WindowsFactory extends GUIFactory {
    public Button createButton() { return new WindowsButton(); }
    public Menu   createMenu()   { return new WindowsMenu(); }
    public Dialog createDialog() { return new WindowsDialog(); }
}
