using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    // A command that can execute multiple commands
    public class MacroCommand : ICommand
    {
        private List<ICommand> _commands;

        // Attach a list of commands to the macro command on init
        public MacroCommand(List<ICommand> commands) { _commands = commands; }

        public void Execute() 
        { 
            foreach (var command in _commands) { command.Execute(); }
        }
    }
}
