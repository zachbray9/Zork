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
            get => game;
            set
            {
                game = value;
                //OnPropertyChanged(nameof(Game));
            }
        }

        public ZorkBuilderViewModel()
        {
            game = new Game();
            game.World = new World();

            game.WelcomeMessage = "Welcome to Zork!";
            game.ExitMessage = "Thanks for playing!";
            rooms = new List<Room>();
            //Rooms.Add(new Room("bruh room", "this is a room"));

            OpenCommand = new OpenCommand(this);
            AddRoomCommand = new AddRoomCommand(this);
        }

        private string fileName;
        public string FileName
        {
            get
            {
                if (fileName == null)
                    return $"Zorkbuilder - Untitled";
                else
                    return $"Zorkbuilder - {fileName}";
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
            get => filePath;
            set => filePath = value;
        }

        public string WelcomeMessage
        {
            get => game.WelcomeMessage;
            set
            {
                game.WelcomeMessage = value;
                OnPropertyChanged(nameof(WelcomeMessage));
            }
        }

        public string ExitMessage
        {
            get => game.ExitMessage;
            set
            {
                game.ExitMessage = value;
                OnPropertyChanged(nameof(ExitMessage));
            }
        }

        public string StartingLocation
        {
            get => game.StartingLocation;
            set
            {
                game.StartingLocation = value;
                OnPropertyChanged(nameof(StartingLocation));
            }
        }

        private List<Room> rooms;
        public List<Room> Rooms
        {
            //get => game.World.Rooms;
            get => rooms;
            set
            {
                //game.World.Rooms = value;
                rooms = value;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        private List<string> roomNames = new List<string>();
        public List<string> RoomNames
        {
            get => roomNames;
            set
            {
                roomNames = value;
                OnPropertyChanged(nameof(RoomNames));
            }
        }


        public ICommand OpenCommand
        {
            get;
        }

        public ICommand AddRoomCommand
        {
            get;
        }

        public void UpdateRoomNamesList()
        {
            roomNames = new List<string>();
            foreach(Room room in rooms)
            {
                roomNames.Add(room.Name);
            }
            

        }

    }
}
