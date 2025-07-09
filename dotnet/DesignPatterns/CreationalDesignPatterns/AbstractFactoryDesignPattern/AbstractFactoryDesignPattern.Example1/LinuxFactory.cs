namespace AbstractFactoryDesignPattern.Example1;

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
