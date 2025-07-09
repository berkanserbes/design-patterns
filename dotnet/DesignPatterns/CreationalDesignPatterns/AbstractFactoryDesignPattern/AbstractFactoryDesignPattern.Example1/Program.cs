using AbstractFactoryDesignPattern.Example1;
using AbstractFactoryDesignPattern.Example1.Factory.Abstract;

Console.WriteLine("GUI Abstract Factory Example");

string[] platforms = { "Windows", "Mac", "Linux" };

foreach (string platform in platforms)
{	
	Console.WriteLine($"\nPlatform: {platform}");
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