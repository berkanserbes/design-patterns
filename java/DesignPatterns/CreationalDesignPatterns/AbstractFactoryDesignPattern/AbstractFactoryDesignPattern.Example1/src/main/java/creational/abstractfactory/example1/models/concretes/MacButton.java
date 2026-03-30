package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Button;

public class MacButton extends Button {
    public void render()   { System.out.println("Rendering Mac Button"); }
    public void onClick()  { System.out.println("Mac Button Clicked"); }
}
