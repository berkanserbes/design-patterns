package creational.prototype.example3;

public class Circle extends Shape {
    public double radius;

    public Circle(String color, double x, double y, double radius) {
        super(color, x, y);
        this.radius = radius;
    }

    private Circle(Circle other) {
        super(other.color, other.x, other.y);
        this.radius = other.radius;
    }

    @Override
    public Object clone() { return new Circle(this); }

    @Override
    public void display() {
        System.out.println("Circle at (" + x + ", " + y + ") with color " + color + " and radius " + radius);
    }
}
