using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zork.Common;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF.Commands
{
    public class ConfirmAddRoomCommand : CommandBase
    {
        AddRoomViewModel AddRoomViewModel;

        public ConfirmAddRoomCommand(AddRoomViewModel addRoomViewModel)
        {
            AddRoomViewModel = addRoomViewModel;
        }

        public override void Execute(object parameter)
        {
            if (AddRoomViewModel.ZorkBuilderViewModel.RoomNames.Contains(AddRoomViewModel.NewRoomName))
            {
                MessageBox.Show("A room with this name already exists. Please enter a new name.", "Zork Builder", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(AddRoomViewModel.NewRoomName == null)
            {
                MessageBox.Show("Please enter a name for the new room you are trying to add.", "Zork Builder", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddRoomViewModel.ZorkBuilderViewModel.Rooms.Add(new Room(AddRoomViewModel.NewRoomName, AddRoomViewModel.NewRoomDescription));
                AddRoomViewModel.ZorkBuilderViewModel.UpdateRoomNamesList();
                AddRoomViewModel.CloseAddRoomWindowCommand.Execute();
                
            }
        }
    }

    
}
