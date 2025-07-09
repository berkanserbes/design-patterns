namespace AbstractFactoryDesignPattern.Example1;

public class MacFactory : GUIFactory
{
	public override Button CreateButton()
	{
		return new MacButton();
	}
	public override Menu CreateMenu()
	{
		return new MacMenu();
	}
	public override Dialog CreateDialog()
	{
		return new MacDialog();
	}
}
