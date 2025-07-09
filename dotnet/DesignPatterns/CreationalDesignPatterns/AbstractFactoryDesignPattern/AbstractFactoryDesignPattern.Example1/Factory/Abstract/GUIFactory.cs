using AbstractFactoryDesignPattern.Example1.Models.Abstract;

namespace AbstractFactoryDesignPattern.Example1.Factory.Abstract;

public abstract class GUIFactory
{
	public abstract Button CreateButton();
	public abstract Menu CreateMenu();
	public abstract Dialog CreateDialog();
}
