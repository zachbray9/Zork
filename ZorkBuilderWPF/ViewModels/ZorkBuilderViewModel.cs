using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zork.Common;

namespace ZorkBuilderWPF.ViewModels
{
    public class ZorkBuilderViewModel : ViewModelBase
    {
        private Game game;
        public Game Game
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
                OnPropertyChanged(nameof(game));
            }
        }

        public string WelcomeMessage
        {
            get
            {
                return game.WelcomeMessage;
            }
            set
            {
                game.WelcomeMessage = value;
                OnPropertyChanged(nameof(WelcomeMessage));
            }
        }

        public string ExitMessage
        {
            get
            {
                return game.ExitMessage;
            }
            set
            {
                game.ExitMessage = value;
                OnPropertyChanged(nameof(ExitMessage));
            }
        }

        public string StartingLocation
        {
            get
            {
                return game.StartingLocation;
            }
            set
            {
                game.StartingLocation = value;
                OnPropertyChanged(nameof(StartingLocation));
            }
        }

        private List<Room> rooms;
        public List<Room> Rooms
        {
            get
            {
                //return game.World.Rooms;
                return rooms;
            }
            set
            {
                //game.World.Rooms = value;
                rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        private List<string> roomNames;
        public List<string> RoomNames
        {
            get
            {
                roomNames = new List<string>();
                for(int i = 0; i < Rooms.Count; i++)
                {
                    roomNames[i] = Rooms[i].ToString();
                }
                return roomNames;
            }
            set
            {
                roomNames = value;
                OnPropertyChanged(nameof(RoomNames));
            }
        }

        public ZorkBuilderViewModel()
        {
            game = new Game();
            Rooms = new List<Room>();
            Rooms.Add(new Room("bruh room", "this is a room"));
        }
    }
}
