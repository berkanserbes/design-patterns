package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Button;

public class WindowsButton extends Button {
    public void render()   { System.out.println("Rendering Windows Button"); }
    public void onClick()  { System.out.println("Windows Button Clicked"); }
}
