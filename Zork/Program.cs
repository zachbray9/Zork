using System;

namespace Zork
{
    class Program
    {
        private static string[] Rooms = new string[] { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" };
        private static int locationColumn = 1;

        private static string Location
        {
            get
            {
                return Rooms[locationColumn];
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.Write($"{Location}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch(command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!"; 
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
         }
        



        static Commands ToCommand(string commandString)
        {
            return Enum.TryParse<Commands>(commandString, ignoreCase: true, out Commands command) ? command : Commands.UNKNOWN;
        }

        static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH:
                case Commands.SOUTH:
                    break;

                case Commands.EAST when locationColumn < Rooms.Length - 1:
                    locationColumn++;
                    didMove = true;
                    break;

                case Commands.WEST when locationColumn > 0:
                    locationColumn--;
                    didMove = true;
                    break;
            }

            return didMove;
        }


    }
}