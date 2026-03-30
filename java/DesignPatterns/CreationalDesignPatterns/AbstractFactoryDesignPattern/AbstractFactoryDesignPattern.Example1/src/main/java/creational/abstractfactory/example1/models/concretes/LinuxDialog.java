package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Dialog;

public class LinuxDialog extends Dialog {
    public void render() { System.out.println("Rendering Linux Dialog"); }
    public void show()   { System.out.println("Showing Linux Dialog"); }
    public void close()  { System.out.println("Closing Linux Dialog"); }
}
