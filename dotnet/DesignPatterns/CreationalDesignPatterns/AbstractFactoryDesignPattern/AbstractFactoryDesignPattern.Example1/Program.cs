using AbstractFactoryDesignPattern.Example1;

Console.WriteLine("GUI Abstract Factory Example");

// Farklı platformlar için test
string[] platforms = { "Windows", "Mac", "Linux" };

foreach (string platform in platforms)
{	
	Console.WriteLine($"Platform: {platform}");
	try
	{
		GUIFactory factory = GUIFactoryProvider.GetFactory(platform);

		Application app = new Application(factory);
		app.CreateGUI();
		app.RunApplication();
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Error: {ex.Message}");
	}
}