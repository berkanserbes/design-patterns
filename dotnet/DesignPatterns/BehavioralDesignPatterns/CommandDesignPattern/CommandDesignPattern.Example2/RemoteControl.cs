using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Example2;

public class RemoteControl
{
    private ICommand[] onCommands;
    private ICommand[] offCommands;
    private ICommand lastCommand;

    public RemoteControl()
    {
        onCommands = new ICommand[7]; 
        offCommands = new ICommand[7];

        // Null Object Pattern - Boş komut
        ICommand noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
        lastCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void OnButtonPressed(int slot)
    {
        onCommands[slot].Execute();
        lastCommand = onCommands[slot];
    }

    public void OffButtonPressed(int slot)
    {
        offCommands[slot].Execute();
        lastCommand = offCommands[slot];
    }

    public void UndoButtonPressed()
    {
        lastCommand.Undo();
    }

    public void PrintCommands()
    {
        Console.WriteLine("\n----- Uzaktan Kumanda -----");
        for (int i = 0; i < onCommands.Length; i++)
        {
            Console.WriteLine($"[slot {i}] {onCommands[i].GetType().Name} | {offCommands[i].GetType().Name}");
        }
    }
}
