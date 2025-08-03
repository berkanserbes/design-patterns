using PrototypeDesignPattern.Example3;

Shape circle = new Circle("Red", 0, 0, 5);

var copyCircle = (Circle)circle.Clone();
copyCircle.X = 10;
copyCircle.Y = 10;

Console.WriteLine("Original Circle:");
circle.Display();

Console.WriteLine("\nCloned Circle:");
copyCircle.Display();

Shape rectangle = new Rectangle("Blue", 5, 5, 10, 20);
var copyRectangle = (Rectangle)rectangle.Clone();
copyRectangle.X = 15;
copyRectangle.Y = 15;
copyRectangle.Color = "Orange";

Console.WriteLine("\nOriginal Rectangle:");
rectangle.Display();

Console.WriteLine("\nCloned Rectangle:");
copyRectangle.Display();

Console.ReadLine();