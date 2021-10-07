using System;
using System.Runtime.Serialization;

namespace Zork
{
    class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        public Player Player { get; private set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {

                Console.WriteLine(Player.CurrentRoom);
                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }
                Console.Write("\n> ");

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = ExitMessage;
                        break;

                    case Commands.LOOK:
                        outputString = Player.CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        outputString = Player.Move(direction) ? $"You moved {command}." : "The way is shut!";
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
