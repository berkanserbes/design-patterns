package structural.bridge.example3;

public class Main {
    public static void main(String[] args) {
        Shape redCircle = new Circle(new Red());
        Shape greenSquare = new Square(new Green());

        redCircle.draw();
        greenSquare.draw();
    }
}
