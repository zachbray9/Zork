using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine().Trim().ToUpper();
            Commands command = ToCommand(inputString);

            if(inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");
            }
            else if(inputString == "LOOK")
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.");
            }
            else
            {
                Console.WriteLine("Unrecognized command.");
            }

        }

        static Commands ToCommand(string commandString)
        {
            Commands command;

            if(commandString = "QUIT")
            {
                command = Commands.QUIT;
            }
            else
            {
                command = Commands.UNKNOWN;
            }

            return command;

        }
    }
}
