using SingletonDesignPattern.Example1;

var x = Singleton.GetOrCreateInstance();
var y = Singleton.GetOrCreateInstance();

if (x == y)
{
	Console.WriteLine("x and y are the same instance.");
}
else
{
	Console.WriteLine("x and y are different instances.");
}

Console.WriteLine($"Hash code of x = {x.GetHashCode()}");
Console.WriteLine($"Hash code of y = {y.GetHashCode()}");