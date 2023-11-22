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

            // Creating instance of the invoker
            RemoteController remote = new RemoteController();

            // Setting up commands for invoker
            remote.SetCommand(1, new TurnOnLightCommand(light));
            remote.SetCommand(2, new TurnOffLightCommand(light));
            remote.SetCommand(3, new IncreaseTemperatureCommand(thermostat));
            remote.SetCommand(4, new DecreaseTemperatureCommand(thermostat));

            // Composite command example (Turn off light and decrease temperature)
            CompositeCommand nightMode = new CompositeCommand();
            nightMode.Add(new TurnOffLightCommand(light));
            nightMode.Add(new DecreaseTemperatureCommand(thermostat));
            remote.SetCommand(5, nightMode);

        }
    }
}
