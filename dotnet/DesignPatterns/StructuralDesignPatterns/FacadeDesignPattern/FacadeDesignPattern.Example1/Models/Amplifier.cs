namespace FacadeDesignPattern.Example1.Models;

public class Amplifier
{
	public void On() => Console.WriteLine("Amplifier is turned on.");
	public void Off() => Console.WriteLine("Amplifier is turned off.");
	public void SetVolume(int level) => Console.WriteLine($"Amplifier volume is set to {level}.");
}
