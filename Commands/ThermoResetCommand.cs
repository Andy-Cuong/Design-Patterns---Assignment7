using Design_Patterns___Assignment7.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    public class ThermoResetCommand : ICommand
    {
        private Thermostat _thermostat;

        // Attach a receiver to the command on init
        public ThermoResetCommand(Thermostat thermostat) { _thermostat = thermostat; }

        public void Execute() { _thermostat.Reset(); }
    }
}
