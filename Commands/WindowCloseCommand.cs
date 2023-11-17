using Design_Patterns___Assignment7.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    public class WindowCloseCommand : ICommand
    {
        private Window _window;

        // Attach the command to a receiver on initializing
        public WindowCloseCommand(Window window) { _window = window; }

        public void Execute() { _window.Close(); }
    }
}
