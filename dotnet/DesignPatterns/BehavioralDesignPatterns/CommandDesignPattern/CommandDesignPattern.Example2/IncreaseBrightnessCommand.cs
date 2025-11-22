using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Example2;

public class IncreaseBrightnessCommand : ICommand
{
    private Light _light;
    public IncreaseBrightnessCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.IncreaseBrightness();
    }
    public void Undo()
    {
        _light.DecreaseBrightness();
    }
}
