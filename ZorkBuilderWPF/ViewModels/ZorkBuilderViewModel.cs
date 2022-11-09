using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zork.Common;
using ZorkBuilderWPF.Commands;

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
                OnPropertyChanged(nameof(Game));
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                OnPropertyChanged(nameof(fileName));
            }
        }

        private string filePath;
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
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

        public List<Room> Rooms
        {
            get
            {
                return game.World.Rooms;
                
                //return rooms;
            }
            set
            {
                game.World.Rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        //private List<string> roomNames = new List<string>();
        //public List<string> RoomNames
        //{
        //    get
        //    {
        //        for (int i = 0; i < Rooms.Count; i++)
        //        {
        //            roomNames[i] = Rooms[i].ToString();
        //        }
        //        return roomNames;
        //    }
        //    set
        //    {
        //        roomNames = value;
        //        OnPropertyChanged(nameof(RoomNames));
        //    }
        //}

        public ZorkBuilderViewModel()
        {
            game = new Game();
            game.World = new World();
            //game.WelcomeMessage = "Welcome to Zork!";
            //game.ExitMessage = "Thanks for playing!";
            //Rooms.Add(new Room("bruh room", "this is a room"));

            OpenCommand = new OpenCommand(this);
            AddRoomCommand = new AddRoomCommand(this);
        }

        public ICommand OpenCommand
        {
            get;
        }

        public ICommand AddRoomCommand
        {
            get;
        }
        
    }
}
