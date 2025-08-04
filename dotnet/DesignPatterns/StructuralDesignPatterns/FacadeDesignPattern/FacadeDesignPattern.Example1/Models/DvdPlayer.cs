namespace FacadeDesignPattern.Example1.Models;

public class DvdPlayer
{
	public void On() => Console.WriteLine("DVD player is turned on.");
	public void Off() => Console.WriteLine("DVD player is turned off.");
	public void Play(string movie) => Console.WriteLine($"Playing movie: '{movie}'.");
	public void Stop() => Console.WriteLine("Movie playback stopped.");
}
