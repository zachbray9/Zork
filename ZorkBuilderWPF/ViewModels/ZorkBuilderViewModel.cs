using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            }
        }

        public ZorkBuilderViewModel()
        {
            game = new Game();
            game.World = new World();

            game.WelcomeMessage = "Welcome to Zork!";
            game.ExitMessage = "Thanks for playing!";
            rooms = new ObservableCollection<Room>();

            OpenCommand = new OpenCommand(this);
            AddRoomCommand = new AddRoomCommand(this);
            DeleteRoomCommand = new DeleteRoomCommand(this);
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

        private Room startingLocation;
        public Room StartingLocation
        {
            get
            {
                return startingLocation;
            }
            set
            {
                startingLocation = value;
                //Starting location needs to be serialized as a string, but used as a room in the program
                Game.StartingLocation = value.ToString();
                OnPropertyChanged(nameof(StartingLocation));
            }
        }

        private ObservableCollection<Room> rooms;
        public ObservableCollection<Room> Rooms
        {
            get => rooms;
            set
            {
                rooms = value;
                OnPropertyChanged(nameof(Rooms));
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

        public ICommand DeleteRoomCommand
        {
            get;
        }

        public Room ChangeStringToRoom(string inputString)
        {
            for(int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].Name == inputString)
                    return Rooms[i];
            }

            return null;
        }

    }
}
