namespace SingletonDesignPattern.Example5;

public class Singleton
{
	private static readonly Lazy<Singleton> _lazyInstance = new(() => new Singleton());

	public static Singleton Instance => _lazyInstance.Value;

	private Singleton() { }

}
