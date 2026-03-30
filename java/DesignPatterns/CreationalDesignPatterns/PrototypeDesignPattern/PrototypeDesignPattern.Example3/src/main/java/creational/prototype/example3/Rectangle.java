package creational.prototype.example3;

public class Rectangle extends Shape {
    public double width;
    public double height;

    public Rectangle(String color, double x, double y, double width, double height) {
        super(color, x, y);
        this.width  = width;
        this.height = height;
    }

    private Rectangle(Rectangle other) {
        super(other.color, other.x, other.y);
        this.width  = other.width;
        this.height = other.height;
    }

    @Override
    public Object clone() { return new Rectangle(this); }

    @Override
    public void display() {
        System.out.println("Rectangle at (" + x + ", " + y + ") with dimensions " + width + "x" + height + " and color " + color);
    }
}
