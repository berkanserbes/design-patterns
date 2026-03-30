package creational.prototype.example3;

public abstract class Shape implements Cloneable {
    public String color;
    public double x;
    public double y;

    protected Shape(String color, double x, double y) {
        this.color = color;
        this.x     = x;
        this.y     = y;
    }

    public abstract Object clone();
    public abstract void display();
}
