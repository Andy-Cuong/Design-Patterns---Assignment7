using Design_Patterns___Assignment7.Commands;
using Design_Patterns___Assignment7.Invoker;
using Design_Patterns___Assignment7.Receivers;

// Init receivers
Light light = new Light();
Thermostat thermostat = new Thermostat();
Window window = new Window();

// Init invoker
RemoteController remoteController = new RemoteController();

// Init single commands
LightTurnOnCommand lightTurnOnCommand = new LightTurnOnCommand(light);
LightTurnOffCommand lightTurnOffCommand = new LightTurnOffCommand(light);
ThermoIncreaseCommand thermoIncreaseCommand = new ThermoIncreaseCommand(thermostat);
ThermoDecreaseCommand thermoDecreaseCommand = new ThermoDecreaseCommand(thermostat);
ThermoResetCommand thermoResetCommand = new ThermoResetCommand(thermostat);
WindowOpenCommand windowOpenCommand = new WindowOpenCommand(window);
WindowCloseCommand windowCloseCommand = new WindowCloseCommand(window);

// Init macro command
List<ICommand> commands = new List<ICommand> { lightTurnOffCommand, thermoResetCommand, windowCloseCommand };
MacroCommand resetCommand = new MacroCommand(commands);

// Attach the commands to respective slots
remoteController.SetCommandAtSlot(0, resetCommand);
remoteController.SetCommandAtSlot(1, lightTurnOffCommand);
remoteController.SetCommandAtSlot(2, lightTurnOnCommand);
remoteController.SetCommandAtSlot(3, thermoIncreaseCommand);
remoteController.SetCommandAtSlot(4, thermoDecreaseCommand);
remoteController.SetCommandAtSlot(5, thermoResetCommand);
remoteController.SetCommandAtSlot(6, windowCloseCommand);
remoteController.SetCommandAtSlot(7, windowOpenCommand);

// Instructions
Console.WriteLine("----WELCOME TO REMOTE CONTROLLER----");
Console.WriteLine("Press 1 to turn off the light");
Console.WriteLine("Press 2 to turn on the light");
Console.WriteLine("Press 3 to increase thermostat's temperature");
Console.WriteLine("Press 4 to decrease thermostat's temperature");
Console.WriteLine("Press 5 to reset thermostat's temperature");
Console.WriteLine("Press 6 to close the window");
Console.WriteLine("Press 7 to open the window");
Console.WriteLine("Press 0 to reset to default settings");

// Infinite loop
while (true)
{
    Console.Write("\nYou press: ");

    // Check if the input is an integer
    int slot;
    if (!int.TryParse(Console.ReadLine(), out slot))
    {
        // If not, try again
        Console.WriteLine("Invalid input. Try again");
        continue;
    }

    // Check if the input is in the controller's range
    try 
    {
        remoteController.OnButtonPressed(slot); // If it is, execute the command
    } 
    catch (ArgumentOutOfRangeException)
    {
        // If not, notify and try again
        Console.WriteLine("The remote controller only has 10 buttons, which means 9 is the max you can get. Try again");
    }
}


