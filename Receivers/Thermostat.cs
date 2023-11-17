using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Receivers
{
    public class Thermostat
    {
        public int Temperature { get; private set; }

        // Initialize a thermostat with given initial temperature
        public Thermostat(int temp) { Temperature = temp; }
        
        // Initialize a thermostat with default initial temperature
        public Thermostat() { Temperature = 20; }

        // Methods to change temperature
        public void Increase() 
        { 
            Temperature++;
            Console.WriteLine($"Current temperature: {Temperature}");
        }
        public void Decrease() 
        {
            Temperature--;
            Console.WriteLine($"Current temperature: {Temperature}");
        }
        public void Reset()
        { 
            Temperature = 20;
            Console.WriteLine($"Current temperature: {Temperature}");
        }
    }
}
