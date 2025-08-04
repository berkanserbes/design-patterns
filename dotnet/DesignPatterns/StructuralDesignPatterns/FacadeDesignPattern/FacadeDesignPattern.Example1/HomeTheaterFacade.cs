using FacadeDesignPattern.Example1.Models;

namespace FacadeDesignPattern.Example1;

public class HomeTheaterFacade
{
	private readonly Projector _projector;
	private readonly Amplifier _amplifier;
	private readonly DvdPlayer _dvdPlayer;
	private readonly Lights _lights;

	public HomeTheaterFacade(Projector projector, Amplifier amplifier, DvdPlayer dvdPlayer, Lights lights)
	{
		_projector = projector;
		_amplifier = amplifier;
		_dvdPlayer = dvdPlayer;
		_lights = lights;
	}

	public void WatchMovie(string movie)
	{
		Console.WriteLine("\n--- Starting Movie Mode ---");
		_lights.Dim();
		_projector.On();
		_projector.SetWideScreenMode();
		_amplifier.On();
		_amplifier.SetVolume(10);
		_dvdPlayer.On();
		_dvdPlayer.Play(movie);
	}

	public void EndMovie()
	{
		Console.WriteLine("\n--- Shutting Down Movie Mode ---");
		_dvdPlayer.Stop();
		_dvdPlayer.Off();
		_amplifier.Off();
		_projector.Off();
		_lights.On();
	}
}
