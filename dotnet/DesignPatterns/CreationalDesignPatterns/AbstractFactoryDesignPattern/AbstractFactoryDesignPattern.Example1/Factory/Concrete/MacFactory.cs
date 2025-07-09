using AbstractFactoryDesignPattern.Example1.Factory.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Concrete;

namespace AbstractFactoryDesignPattern.Example1.Factory.Concrete;

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
