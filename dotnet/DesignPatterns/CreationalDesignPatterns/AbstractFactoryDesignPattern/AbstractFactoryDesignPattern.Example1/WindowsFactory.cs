namespace AbstractFactoryDesignPattern.Example1;

public class WindowsFactory : GUIFactory
{
	public override Button CreateButton()
	{
		return new WindowsButton();
	}
	public override Menu CreateMenu()
	{
		return new WindowsMenu();
	}
	public override Dialog CreateDialog()
	{
		return new WindowsDialog();
	}
}
