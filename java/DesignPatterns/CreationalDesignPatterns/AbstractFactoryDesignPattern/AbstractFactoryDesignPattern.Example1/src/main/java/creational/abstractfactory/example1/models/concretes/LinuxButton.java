package creational.abstractfactory.example1.models.concretes;

import creational.abstractfactory.example1.models.abstracts.Button;

public class LinuxButton extends Button {
    public void render()   { System.out.println("Rendering Linux Button"); }
    public void onClick()  { System.out.println("Linux Button Clicked"); }
}
