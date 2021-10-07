using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        //public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        public Player Player { get; private set; }

        private bool IsRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }


        public void Run()
        {
            IsRunning = true;
            Room PreviousRoom = null;
            
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {

                Console.WriteLine(Player.Location);
                if (PreviousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    PreviousRoom = Player.Location;
                }
                Console.Write("> ");

                command = ToCommand(Console.ReadLine().Trim());

                string outputString = null;                                                                        //made output string null
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = ExitMessage;
                        break;

                    case Commands.LOOK:
                        outputString = Player.Location.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        if(Player.Move(direction) == false)
                        {
                            outputString = "The way is shut!";
                        }
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


        public static Game Load(string fileName)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(fileName));
            game.Player = game.World.SpawnPlayer();

            return game;
        }
    }
}
