using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IOutputService output { get; set; }

        [JsonIgnore]
        public static Game Instance { get; private set; }

        public World World { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public static void StartGameFromFile(string gameFileName)
        {
            if(!File.Exists(gameFileName))
            {
                throw new FileNotFoundException("Expected file.", gameFileName);
            }

            StartGame(File.ReadAllText(gameFileName));
        }

        public static void StartGame(string jsonString)
        {
            //game = JsonConvert.DeserializeObject<Game>(jsonString);
            Instance = Load(jsonString);
            //Instance.Run();
        }

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            return game;
        }

        public void Run()
        {
            Console.WriteLine(Instance.WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                
                Console.WriteLine(Instance.Player.CurrentRoom);
                if (Instance.Player.PreviousRoom != Instance.Player.CurrentRoom)
                {
                    Console.WriteLine(Instance.Player.CurrentRoom.Description);
                    Instance.Player.PreviousRoom = Instance.Player.CurrentRoom;
                }
                Console.Write("\n> ");

                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = Instance.ExitMessage;
                        break;

                    case Commands.LOOK:
                        outputString = Instance.Player.CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        outputString = Instance.Player.Move(direction) ? $"You moved {command}." : "The way is shut!";
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
