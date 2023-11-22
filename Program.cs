using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_COMMAND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of receivers
            Light light = new Light();
            Thermostat thermostat = new Thermostat();
            // Instantiate the display status 
            ICommand displayStatus = new DisplayStatusCommand(light, thermostat);
            // Creating instance of the invoker
            RemoteController remote = new RemoteController();

            // Setting up commands for invoker
            remote.SetCommand(1, new TurnOnLightCommand(light), "Turn the light on");
            remote.SetCommand(2, new TurnOffLightCommand(light), "Turn the light off");
            remote.SetCommand(3, new IncreaseTemperatureCommand(thermostat), "Increase temperature");
            remote.SetCommand(4, new DecreaseTemperatureCommand(thermostat), "Decrease temperature");

            // Composite command example (Turn off light and decrease temperature)
            CompositeCommand nightMode = new CompositeCommand();
            
            nightMode.Add(new TurnOffLightCommand(light));
            nightMode.Add(new DecreaseTemperatureCommand(thermostat));
            remote.SetCommand(5, nightMode,"Turn the light off and decrease temperature");

            // Assign the display statu  to button 6
            remote.SetCommand(6, displayStatus, "Display current light and thermostate status");

            // New test command for button 7
            CompositeCommand daymode = new CompositeCommand();
            daymode.Add(new TurnOnLightCommand(light));
            daymode.Add(new IncreaseTemperatureCommand(thermostat));
            daymode.Add(new IncreaseTemperatureCommand(thermostat));
            daymode.Add(new IncreaseTemperatureCommand(thermostat));
            daymode.Add(new IncreaseTemperatureCommand(thermostat));
            daymode.Add(new IncreaseTemperatureCommand(thermostat));
            remote.SetCommand(7, daymode, "Turn the lights on and increase temperature by 5");

            // Display the menu
            remote.DisplayMenu();

            // Main loop
            while (true)
            {
                Console.WriteLine($"Enter command number (1 to {remote.CommandCount - 1}) or 0 to exit:");
                if (!int.TryParse(Console.ReadLine(), out int commandNumber) || commandNumber < 0 || commandNumber >= remote.CommandCount)
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 0 and {remote.CommandCount - 1}.");
                    continue;
                }
                // Exit condition for the app, in actual physical remote it would be removed and loop adjusted to take numbers 1 to CommandCount.length - 1
                if (commandNumber == 0) break; 

                remote.PressButton(commandNumber);
                

            }
            // Display the status receivers after exiting the loop
            Console.WriteLine($"Light status: {(light.IsOn ? "On" : "Off")}");
            Console.WriteLine($"Thermostat temperature: {thermostat.CurrentTemperature}");
        }
    }
}
