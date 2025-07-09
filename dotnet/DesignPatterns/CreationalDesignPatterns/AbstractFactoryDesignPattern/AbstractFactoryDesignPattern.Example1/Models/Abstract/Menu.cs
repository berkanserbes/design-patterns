namespace AbstractFactoryDesignPattern.Example1.Models.Abstract;

public abstract class Menu
{
	public abstract void Render();
	public abstract void AddItem(string item);
}
