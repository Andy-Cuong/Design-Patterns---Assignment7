using Design_Patterns___Assignment7.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Invoker
{
    public class RemoteController
    {
        // Assume the remote controller has 10 buttons
        private List<ICommand> Commands = new(10);

        // Initialize a controller with no functionality
        public RemoteController() 
        {
            for (int i = 0; i < Commands.Capacity; i++) Commands.Add(new NoCommand());
        }

        // Assign a specific command to a slot
        public void SetCommandAtSlot(int slot, ICommand command)
        {
            Commands[slot] = command;
        }

        // Call this method when a button on the remote controller is pressed
        public void OnButtonPressed(int slot)
        {
            Commands[slot].Execute();
        }
    }
}
