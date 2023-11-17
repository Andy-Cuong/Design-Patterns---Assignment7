using Design_Patterns___Assignment7.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    internal class ThermoIncreaseCommand : ICommand
    {
        private Thermostat _thermostat;

        // Attach the command to a receiver on initializing
        public ThermoIncreaseCommand(Thermostat thermostat) { _thermostat = thermostat; }

        public void Execute() { _thermostat.Increase(); }
    }
}
