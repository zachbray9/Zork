using System;

namespace Zork
{
    class Program
    {
        private static readonly string[,] Rooms = {
            {"Rocky Trail", "South of House", "Canyon View" },
            {"Forest", "West of House", "Behind House" },
            {"Dense Woods", "North of House", "Clearing" }
        };

        private static (int row, int column) Location = (1, 1);

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.Write($"{Rooms[Location.row, Location.column]}\n> ");
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
                case Commands.NORTH when Location.row < Rooms.GetLength(0) - 1:
                    Location.row++;
                    didMove = true;
                    break;

                case Commands.SOUTH when Location.row > 0:
                    Location.row--;
                    didMove = true;
                    break;

                case Commands.EAST when Location.column < Rooms.GetLength(1) - 1:
                    Location.column++;
                    didMove = true;
                    break;

                case Commands.WEST when Location.column > 0:
                    Location.column--;
                    didMove = true;
                    break;
            }

            return didMove;
        }


    }
}