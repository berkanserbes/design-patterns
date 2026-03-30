package creational.abstractfactory.example1.factory.abstracts;

import creational.abstractfactory.example1.models.abstracts.Button;
import creational.abstractfactory.example1.models.abstracts.Dialog;
import creational.abstractfactory.example1.models.abstracts.Menu;

public abstract class GUIFactory {
    public abstract Button createButton();
    public abstract Menu createMenu();
    public abstract Dialog createDialog();
}
