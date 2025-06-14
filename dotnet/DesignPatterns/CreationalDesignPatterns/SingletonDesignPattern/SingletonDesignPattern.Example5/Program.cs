using SingletonDesignPattern.Example5;
using System;

var x = Singleton.Instance;
var y = Singleton.Instance;

if (x == y)
{
	Console.WriteLine("x and y are the same instance.");
}
else
{
	Console.WriteLine("x and y are different instances.");
}

Console.WriteLine($"hash code of x = {x.GetHashCode()}");
Console.WriteLine($"hash code of y = {y.GetHashCode()}");