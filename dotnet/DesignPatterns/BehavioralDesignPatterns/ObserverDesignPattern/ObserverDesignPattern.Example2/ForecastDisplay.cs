using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Example2;

public class ForecastDisplay : IObserver
{
    private float currentPressure = 1013.0f;
    private float lastPressure;
    private ISubject _weatherStation;

    public ForecastDisplay(ISubject weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        lastPressure = currentPressure;
        currentPressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.Write("🔮 Weather Forecast: ");

        if (currentPressure > lastPressure)
        {
            Console.WriteLine("Improving!");
        }
        else if (currentPressure == lastPressure)
        {
            Console.WriteLine("No change.");
        }
        else if (currentPressure < lastPressure)
        {
            Console.WriteLine("Bad weather incoming.");
        }
    }
}
