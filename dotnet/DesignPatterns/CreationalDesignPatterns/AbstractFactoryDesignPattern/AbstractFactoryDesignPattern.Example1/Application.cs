namespace AbstractFactoryDesignPattern.Example1;

public class Application
{
	private readonly GUIFactory _factory;

	private Button _button;
	private Menu _menu;
	private Dialog _dialog;
	public Application(GUIFactory factory)
	{
		_factory = factory;
	}

	public void CreateGUI()
	{
		_button = _factory.CreateButton();
		_menu = _factory.CreateMenu();
		_dialog = _factory.CreateDialog();
	}

	public void RunApplication()
	{
		Console.WriteLine("=== Starting GUI Application ===");

		_button.Render();
		_menu.Render();
		_dialog.Render();

		Console.WriteLine("\n=== User Interaction ===");

		_menu.AddItem("File");
		_menu.AddItem("Edit");
		_menu.AddItem("Appearance");

		_dialog.Show();
		_button.OnClick();
		_dialog.Close();
	}
}
