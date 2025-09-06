using BridgeDesignPattern.Example3;

Shape redCircle = new Circle(new Red());
Shape greenSquare = new Square(new Green());

redCircle.Draw();
greenSquare.Draw();

Console.ReadLine();