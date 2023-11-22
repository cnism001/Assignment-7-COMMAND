using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_COMMAND
{
    // Light class for IoT device turning light on or off
    public class Light
    {
        // Method to turn  the light on
        public void On()
        {
            Console.WriteLine("Light is turned ON");
        }

        // Method to turn  the light off
        public void Off()
        {
            Console.WriteLine("Light is turned OFF");
        }
    }

    // Thermostat class representing IoT device that can increase or decrease termostat temperature
    public class Thermostat
    {
        // Method to increase the temperature
        public void IncreaseTemperature()
        {
            Console.WriteLine("Temperature increased");
        }

        // Method to decrease the temperature
        public void DecreaseTemperature()
        {
            Console.WriteLine("Temperature decreased");
        }
    }

}
