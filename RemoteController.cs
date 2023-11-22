using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_COMMAND
{
    // RemoteController class acts is an invoker for command pattern
    public class RemoteController
    {
        private ICommand[] commands; // Array to store command objects

        // Constructor initializing the command array
        public RemoteController()
        {   
            // Assuming 10 buttons, error handling added later if any buttons are not assigned
            commands = new ICommand[10]; 
                                        
        }

        // Method to assign a command to a button
        public void SetCommand(int button, ICommand command)
        {
            commands[button] = command;
        }

        // Method to press a button, executing the command assigned to the button
        public void PressButton(int button)
        {
            //if value for a button exists in the array, so its been assigned
            if (commands[button] != null)
            {
                commands[button].Execute();
            }
            else
            {
                Console.WriteLine("No command assigned to this button");
            }
        }
        // Property to get the number of command slots for main menu
        public int CommandCount => commands.Length;
    }

}
