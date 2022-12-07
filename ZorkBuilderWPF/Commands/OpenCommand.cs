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
                        //Rooms list needs to be set before startinglocation because using ChangeStringToRoom() requires the rooms list to be filled
                    ZorkBuilderViewModel.Rooms = new ObservableCollection<Room>(ZorkBuilderViewModel.Game.World.Rooms);
                        //Switches the string to a Room because starting location deserializes as a string and we need it to be a room for the Rooms List (need to change it back to a string upon serializing)
                    ZorkBuilderViewModel.StartingLocation = ZorkBuilderViewModel.ChangeStringToRoom(ZorkBuilderViewModel.Game.StartingLocation);
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
