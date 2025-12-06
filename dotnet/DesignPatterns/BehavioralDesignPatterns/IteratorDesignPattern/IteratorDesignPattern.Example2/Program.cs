using IteratorDesignPattern.Example2;

Console.WriteLine("Iterator Design Pattern - Example 2: Order Management System\n");

var orderCollection = new OrderCollection();
orderCollection.AddOrder(new Order(1, "Alice Johnson", new DateTime(2024, 1, 15), 250.00m, OrderStatus.Delivered));
orderCollection.AddOrder(new Order(2, "Bob Smith", new DateTime(2024, 1, 20), 1500.00m, OrderStatus.Shipped));
orderCollection.AddOrder(new Order(3, "Charlie Brown", new DateTime(2024, 2, 5), 450.00m, OrderStatus.Processing));
orderCollection.AddOrder(new Order(4, "Diana Prince", new DateTime(2024, 2, 10), 3200.00m, OrderStatus.Delivered));
orderCollection.AddOrder(new Order(5, "Eve Wilson", new DateTime(2024, 2, 15), 180.00m, OrderStatus.Pending));
orderCollection.AddOrder(new Order(6, "Frank Miller", new DateTime(2024, 3, 1), 2100.00m, OrderStatus.Shipped));
orderCollection.AddOrder(new Order(7, "Grace Lee", new DateTime(2024, 3, 5), 550.00m, OrderStatus.Cancelled));

Console.WriteLine("All Orders:");
var allOrdersIterator = orderCollection.CreateIterator();
while (allOrdersIterator.HasNext())
{
    Console.WriteLine(allOrdersIterator.Next());
}

Console.WriteLine("\nFiltered by Status (Shipped):");
var shippedIterator = orderCollection.CreateStatusFilterIterator(OrderStatus.Shipped);
while (shippedIterator.HasNext())
{
    Console.WriteLine(shippedIterator.Next());
}

Console.WriteLine("\nFiltered by Date Range (February 2024):");
var dateRangeIterator = orderCollection.CreateDateRangeIterator(
    new DateTime(2024, 2, 1), 
    new DateTime(2024, 2, 28));
while (dateRangeIterator.HasNext())
{
    Console.WriteLine(dateRangeIterator.Next());
}

Console.WriteLine("\nHigh Value Orders (>= $1000):");
var highValueIterator = orderCollection.CreateHighValueIterator(1000m);
while (highValueIterator.HasNext())
{
    Console.WriteLine(highValueIterator.Next());
}
