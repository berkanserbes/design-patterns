using BridgeDesignPattern.Example1;

IDevice tv = new Tv();
Remote remote = new Remote(tv);

remote.TogglePower();
remote.VolumeUp();
Console.WriteLine($"TV Volume: {tv.Volume}");

IDevice radio = new Radio();
AdvancedRemote advRemote = new AdvancedRemote(radio);

advRemote.TogglePower();
advRemote.Mute();
Console.WriteLine($"Radio Volume: {radio.Volume}");
Console.ReadLine();