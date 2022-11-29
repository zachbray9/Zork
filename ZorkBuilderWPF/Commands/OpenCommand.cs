using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zork.Common;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF.Commands
{
    public class OpenCommand : CommandBase
    {
        public ZorkBuilderViewModel ZorkBuilderViewModel;

        public OpenCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }

        public override void Execute(object parameter)
        {
            OpenFileDialog openFileDialogue = new OpenFileDialog()
            {
                DefaultExt = ".json",
                Filter = "json Files (*.json)|*.json"
            };
            
            if(openFileDialogue.ShowDialog() == true)
            {
                try
                {
                    ZorkBuilderViewModel.FilePath = openFileDialogue.FileName;
                    ZorkBuilderViewModel.FileName = System.IO.Path.GetFileName(ZorkBuilderViewModel.FilePath);
                    ZorkBuilderViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(ZorkBuilderViewModel.FilePath));
                    //needed to manually set these because deserializing the game does not call OnPropertyChanged in the property setters so the UI won't update without doing this
                    ZorkBuilderViewModel.WelcomeMessage = ZorkBuilderViewModel.Game.WelcomeMessage;
                    ZorkBuilderViewModel.ExitMessage = ZorkBuilderViewModel.Game.ExitMessage;
                    ZorkBuilderViewModel.Rooms = new ObservableCollection<Room>(ZorkBuilderViewModel.Game.World.Rooms);
                    ZorkBuilderViewModel.StartingLocation = ZorkBuilderViewModel.Game.StartingLocation;
                    ZorkBuilderViewModel.UpdateRoomNamesList();
                    //

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
