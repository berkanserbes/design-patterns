package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Dialog;

public class MacDialog extends Dialog {
    public void render() { System.out.println("Rendering Mac Dialog"); }
    public void show()   { System.out.println("Showing Mac Dialog"); }
    public void close()  { System.out.println("Closing Mac Dialog"); }
}
