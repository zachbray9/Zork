using System;

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

        static void Main(string[] args)
        {
            InitializeRoomDescriptions();

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n> ");                                                                                        
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

        private static void InitializeRoomDescriptions()
        {
            Rooms[0,0].Description = "You are on a rock-strewn trail.";                                                                                 //Rocky Trail
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";         //South of House
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";                                                      //Canyon View

            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";                                                     //Forest
            Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";                                        //West of House
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";     //Behind House

            Rooms[2, 0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";            //Dense Woods
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";         //North of House
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";                                    //Clearing
        }


    }
}