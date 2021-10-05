using System;
using System.Collections.Generic;
using System.IO;

namespace Zork
{
    class Program
    {
        private static readonly Room[,] Rooms = {
            {new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            {new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            {new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        private static (int row, int column) Location = (1, 1);

        public static Room CurrentRoom
        {

            get 
            {
                return Rooms[Location.row, Location.column];
            }


        }

        private enum Fields
        {
            Name = 0,
            Description = 1
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }

        static void Main(string[] args)
        {
            Room previousRoom = null;

            const string defaultRoomsFileName = "Rooms.txt";
            string roomsFileName = args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultRoomsFileName;

            InitializeRoomDescriptions(defaultRoomsFileName);

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {

                Console.WriteLine(CurrentRoom);   
                if(previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }
                Console.Write("> ");

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch(command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = CurrentRoom.Description;
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

        private static void InitializeRoomDescriptions(string roomDescriptionsFileName)
        {

            var roomMap = new Dictionary<string, Room>();

            foreach(Room room in Rooms)
            {
                roomMap[room.Name] = room;
            }


            string[] lines = File.ReadAllLines(roomDescriptionsFileName);
            foreach(string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;
                string[] fields = line.Split(delimiter, expectedFieldCount);
                Assert.IsTrue(fields.Length == expectedFieldCount, "Invalid record.");

                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);
                roomMap[name].Description = description;
            }

        }


    }
}