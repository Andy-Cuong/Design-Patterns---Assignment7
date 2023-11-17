using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    // Null object for command slots that are not assigned (yet)
    public class NoCommand : ICommand
    {
        // Do nothing
        public void Execute() { Console.WriteLine("This slot is not assigned"); }
    }
}
