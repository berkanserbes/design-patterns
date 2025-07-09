using AbstractFactoryDesignPattern.Example1.Factory.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Abstract;
using AbstractFactoryDesignPattern.Example1.Models.Concrete;

namespace AbstractFactoryDesignPattern.Example1.Factory.Concrete;

public class LinuxFactory : GUIFactory
{
	public override Button CreateButton()
	{
		return new LinuxButton();
	}
	public override Menu CreateMenu()
	{
		return new LinuxMenu();
	}
	public override Dialog CreateDialog()
	{
		return new LinuxDialog();
	}
}
