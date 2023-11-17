using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment7.Receivers
{
    public class Window
    {
        public bool IsOpen { get; private set; }

        // Initialize a closed window
        public Window() { IsOpen = false; }

        // Methods to open or close window
        public void Open() 
        { 
            IsOpen = true;
            Console.WriteLine("Window is OPENED");
        }

        public void Close()
        {
            IsOpen = false;
            Console.WriteLine("Window is CLOSED");
        }
    }
}
