package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Dialog;

public class WindowsDialog extends Dialog {
    public void render() { System.out.println("Rendering Windows Dialog"); }
    public void show()   { System.out.println("Showing Windows Dialog"); }
    public void close()  { System.out.println("Closing Windows Dialog"); }
}
