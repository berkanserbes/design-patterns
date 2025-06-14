using SingletonDesignPattern.Example4;

Thread thread1 = new Thread(() =>
{
	var instance = Singleton.GetInstance("Hello");
	Console.WriteLine($"Thread 1 Value: {instance.Value}");
	Console.WriteLine($"Thread 1: {instance.GetHashCode()}");
});

Thread thread2 = new Thread(() =>
{
	var instance = Singleton.GetInstance("Hi");
	Console.WriteLine($"Thread 2 Value: {instance.Value}");
	Console.WriteLine($"Thread 2: {instance.GetHashCode()}");
});

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();