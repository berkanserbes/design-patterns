using FacadeDesignPattern.Example1;
using FacadeDesignPattern.Example1.Models;

var projector = new Projector();
var amplifier = new Amplifier();
var dvdPlayer = new DvdPlayer();
var lights = new Lights();

var homeTheater = new HomeTheaterFacade(projector, amplifier, dvdPlayer, lights);

homeTheater.WatchMovie("Inception");
Console.WriteLine("\nAfter a while...");
homeTheater.EndMovie();