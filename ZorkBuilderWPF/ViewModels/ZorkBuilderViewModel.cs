using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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
            ChangesWereMade = false;

            game = new Game();
            game.World = new World();

            game.WelcomeMessage = "Welcome to Zork!";
            game.ExitMessage = "Thanks for playing!";
            rooms = new ObservableCollection<Room>();

            OpenCommand = new OpenCommand(this);
            AddRoomCommand = new AddRoomCommand(this);
            DeleteRoomCommand = new DeleteRoomCommand(this);
            SaveCommand = new SaveCommand(this);
            SaveAsCommand = new SaveAsCommand(this);
            ExitCommand = new ExitCommand(this);
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

        public ICommand SaveCommand
        {
            get;
        }

        public ICommand SaveAsCommand
        {
            get;
        }

        public ICommand ExitCommand
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

        public void SaveGame()
        {
            Game.StartingLocation = startingLocation.ToString();
            //converts the Rooms observable collection from the ZorkBuilderViewModel to a list in the ZorkBuilderViewModel.Game.World class and adds the names of the neighbors of each room to their NeighborNames list since they must be strings for serialization
            Game.World.Rooms = Rooms.ToList();
            foreach (Room room in Game.World.Rooms)
            {
                var Keys = room.Neighbors.Keys.ToList();
                foreach (var key in Keys)
                {
                    room.NeighborNames[key] = room.Neighbors[key].ToString();
                }
            }
            //

            string jsonString = JsonConvert.SerializeObject(Game, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
            ChangesWereMade = false;
        }

    }
}
