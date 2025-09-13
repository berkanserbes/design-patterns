using CompositeDesignPattern.Example1;

// Singular products
var book = new Product("C# Programming Book", 500);
var headphones = new Product("Wireless Headphones", 200);
var phoneCase = new Product("Phone Case", 100);

// Create a box and add products to it
var box1 = new Box("Box 1", 200);
box1.AddItem(book);
box1.AddItem(headphones);

// Create another box and add the first box and another product to it
var box2 = new Box("Box 2", 150);
box2.AddItem(phoneCase);
box2.AddItem(box1);

// Display weights of individual products and boxes
Console.WriteLine($"{book.Name} weight: {book.GetWeight()} gr");
Console.WriteLine($"{headphones.Name} weight: {headphones.GetWeight()} gr");
Console.WriteLine($"{phoneCase.Name} weight: {phoneCase.GetWeight()} gr");

Console.WriteLine($"{box1.Name} total weight: {box1.GetWeight()} gr");
Console.WriteLine($"{box2.Name} total weight: {box2.GetWeight()} gr");