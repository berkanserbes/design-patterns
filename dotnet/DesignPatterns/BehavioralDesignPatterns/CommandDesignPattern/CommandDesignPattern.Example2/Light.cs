namespace CommandDesignPattern.Example2;

public class Light
{
    private string location;
    private bool isOn;

    public Light(string location)
    {
        this.location = location;
        this.isOn = false;
    }

    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine($"{location} ışığı açıldı.");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine($"{location} ışığı kapandı.");
    }

    public void IncreaseBrightness()
    {
        Console.WriteLine($"{location} ışığının parlaklığı artırıldı.");
    }

    public void DecreaseBrightness()
    {
        Console.WriteLine($"{location} ışığının parlaklığı azaltıldı.");
    }
}
