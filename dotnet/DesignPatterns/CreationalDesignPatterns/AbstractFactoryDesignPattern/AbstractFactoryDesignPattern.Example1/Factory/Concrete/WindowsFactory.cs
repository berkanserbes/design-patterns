using AbstractFactoryDesignPattern.Example1.Factory.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Concrete;

namespace AbstractFactoryDesignPattern.Example1.Factory.Concrete;

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
