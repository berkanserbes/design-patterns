namespace FacadeDesignPattern.Example1.Models;

public class Projector
{
	public void On() => Console.WriteLine("Projector is turned on.");
	public void Off() => Console.WriteLine("Projector is turned off.");
	public void SetWideScreenMode() => Console.WriteLine("Projector is set to wide screen mode.");
}
