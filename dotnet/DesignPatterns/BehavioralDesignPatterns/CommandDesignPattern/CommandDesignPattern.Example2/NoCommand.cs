using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Example2;

// Null object pattern implementation for ICommand
internal class NoCommand : ICommand
{
    public void Execute()
    {
        // Do nothing
    }

    public void Undo()
    {
        // Do nothing
    }
}
