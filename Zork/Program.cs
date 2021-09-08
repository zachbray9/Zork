﻿using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
           
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;
                    case Commands.LOOK:
                        outputString = "A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;
                    case Commands.NORTH:                       
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = $"You moved {command}.";
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

    }
}
