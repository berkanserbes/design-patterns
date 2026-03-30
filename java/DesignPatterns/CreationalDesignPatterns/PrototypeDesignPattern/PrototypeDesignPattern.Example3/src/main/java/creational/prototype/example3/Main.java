package creational.prototype.example3;

public class Main {
    public static void main(String[] args) {
        Shape circle = new Circle("Red", 0, 0, 5);
        Circle copyCircle = (Circle) circle.clone();
        copyCircle.x = 10;
        copyCircle.y = 10;

        System.out.println("Original Circle:");
        circle.display();
        System.out.println("\nCloned Circle:");
        copyCircle.display();

        Shape rectangle = new Rectangle("Blue", 5, 5, 10, 20);
        Rectangle copyRectangle = (Rectangle) rectangle.clone();
        copyRectangle.x     = 15;
        copyRectangle.y     = 15;
        copyRectangle.color = "Orange";

        System.out.println("\nOriginal Rectangle:");
        rectangle.display();
        System.out.println("\nCloned Rectangle:");
        copyRectangle.display();
    }
}
