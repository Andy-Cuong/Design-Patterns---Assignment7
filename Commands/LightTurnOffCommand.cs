using Design_Patterns___Assignment7.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Commands
{
    public class LightTurnOffCommand : ICommand
    {
        private Light _light;

        // Attach the command to a receiver on initializing
        public LightTurnOffCommand(Light light) { _light = light; }

        public void Execute() { _light.TurnOff(); }
    }
}
