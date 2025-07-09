namespace AbstractFactoryDesignPattern.Example1;

public abstract class GUIFactory
{
	public abstract Button CreateButton();
	public abstract Menu CreateMenu();
	public abstract Dialog CreateDialog();
}
