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
        // Variable to track light status
        public bool IsOn { get; private set; }
        // Method to turn  the light on
        public void On()
        {
            // Status change
            IsOn = true;
            Console.WriteLine("Light is turned ON");
        }

        // Method to turn  the light off
        public void Off()
        {
            // Status change
            IsOn = false;
            Console.WriteLine("Light is turned OFF");
        }
    }

    // Thermostat class representing IoT device that can increase or decrease termostat temperature
    public class Thermostat
    {
        // Variable to track temperature status, set to ambient temperature by default
        public int CurrentTemperature { get; private set; } = 23; 
        // Method to increase the temperature
        public void IncreaseTemperature()
        {
            //increase by 1
            CurrentTemperature++;
            Console.WriteLine("Temperature increased to "+ CurrentTemperature);
        }

        // Method to decrease the temperature
        public void DecreaseTemperature()
        {
            //decrease by 1
            CurrentTemperature--;
            Console.WriteLine("Temperature decreased to " + CurrentTemperature);
        }
    }

}
