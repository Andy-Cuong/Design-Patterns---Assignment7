using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Receivers
{
    public class Light
    {
        public bool IsOn { get; private set; }

        // Initialize a light with off state
        public Light() { IsOn = false; }

        // Methods to toggle light state
        public void TurnOn() 
        { 
            IsOn = true;
            Console.WriteLine("Light is ON");
        }
        public void TurnOff() 
        { 
            IsOn = false;
            Console.WriteLine("Light is OFF");
        }
    }
}
