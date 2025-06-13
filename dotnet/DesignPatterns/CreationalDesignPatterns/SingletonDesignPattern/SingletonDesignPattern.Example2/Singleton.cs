namespace SingletonDesignPattern.Example2;

public class Singleton
{
	private static Singleton _instance;

	private Singleton() { }
	static Singleton()
	{
		_instance = new Singleton();
	}

	public static Singleton GetInstance => _instance;
}
