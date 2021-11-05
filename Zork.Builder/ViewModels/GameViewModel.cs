using System;
using System.ComponentModel;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;

namespace Zork.Builder
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool isWorldLoaded { get; set; }

        
        public string fileName { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public string WelcomeMessage { get; set; }
        public string ExitMessage { get; set; }
        public string StartingLocation { get; set; }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        public Game Game
        {

            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        WelcomeMessage = _game.WelcomeMessage;
                        ExitMessage = _game.ExitMessage;
                        StartingLocation = _game.StartingLocation;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        WelcomeMessage = "Welcome to Zork!";
                        ExitMessage = "Thank you for playing!";
                        StartingLocation = "West of House";
                    }
                }

            }
        }

        public void SaveGame()
        {
            if(string.IsNullOrEmpty(fileName))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using(StreamWriter streamWriter = new StreamWriter(fileName))
            using(JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}
