using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_COMMAND
{   
    //interface for Execute method for all commands
    public interface ICommand
    {
        void Execute();
    }
    //command to turn the light on
    public class TurnOnLightCommand : ICommand
    {
        private Light light;

        //constructor to inject receiver device
        public TurnOnLightCommand(Light light)
        {
            this.light = light;
        }
        //Execute command to turn the light on
        public void Execute()
        {
            light.On();
        }
    }
    //command to turn the light off, same logic as with light on
    public class TurnOffLightCommand : ICommand
    {
        private Light light;

        public TurnOffLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }

    // Command to increase the temperature of thermostat 
    public class IncreaseTemperatureCommand : ICommand
    {
        private Thermostat thermostat;

        //constructor to inject thermostat receiver
        public IncreaseTemperatureCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        //execute command to increase temperature
        public void Execute()
        {
            thermostat.IncreaseTemperature();
        }
    }
    // Command to decrease the temperature of thermostat, same logic as with increase 
    public class DecreaseTemperatureCommand : ICommand
    {
        private Thermostat thermostat;

        public DecreaseTemperatureCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void Execute()
        {
            thermostat.DecreaseTemperature();
        }
    }

}
