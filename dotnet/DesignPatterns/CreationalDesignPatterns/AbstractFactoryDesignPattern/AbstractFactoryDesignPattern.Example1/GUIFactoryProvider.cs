namespace AbstractFactoryDesignPattern.Example1;

public static class GUIFactoryProvider
{
	public static GUIFactory GetFactory(string platform)
	{
		return platform.ToLower() switch
		{
			"windows" => new WindowsFactory(),
			"mac" => new MacFactory(),
			"linux" => new LinuxFactory(),
			_ => throw new ArgumentException("Invalid OS type", nameof(platform))
		};
	}
}
