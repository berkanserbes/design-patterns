using SingletonDesignPattern.Example3;

//var x = Singleton.Instance;
//var y = Singleton.Instance;

//if (x == y)
//{
//	Console.WriteLine("x and y are the same instance.");
//}
//else
//{
//	Console.WriteLine("x and y are different instances.");
//}

//Console.WriteLine($"Hash code of x = {x.GetHashCode()}");
//Console.WriteLine($"Hash code of y = {y.GetHashCode()}");

Thread thread = new Thread(() =>
{
	var instance = Singleton.Instance;
	Console.WriteLine($"Thread 1: {instance.GetHashCode()}");
});

Thread thread2 = new Thread(() =>
{
	var instance = Singleton.Instance;
	Console.WriteLine($"Thread 2: {instance.GetHashCode()}");
});

thread.Start();
thread2.Start();

thread.Join();
thread2.Join();