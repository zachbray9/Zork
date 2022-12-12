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
    class DeleteRoomCommand : CommandBase
    {
        private ZorkBuilderViewModel ZorkBuilderViewModel;

        public DeleteRoomCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }

        public override void Execute(object parameter)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to delete this room?", "Delete Room Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            
            if(messageBoxResult == MessageBoxResult.Yes)
            {
                //shows error if there is no room selected
                if(parameter == null)
                {
                    MessageBox.Show("There is no room selected. Please select a room and try again.", "No Selected Item Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //

                //shows error if the room you are trying to delete is the starting location
                if(ZorkBuilderViewModel.StartingLocation == (Room)parameter)
                {
                    MessageBox.Show("The room you are trying to delete is the starting location. You must change the starting location before deleting this room.", "Starting Location Delete Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //

                ZorkBuilderViewModel.Rooms.Remove((Room)parameter);

                //after deleting a room, this goes through each room and makes sure any of their neighbors that used to be the deleted room are now null
                foreach(Room room in ZorkBuilderViewModel.Rooms)
                {
                    //finds if the neighbors list of each room contains the deleted room and selects the keys from the filtered dictionary
                    var Keys = room.Neighbors.Where(x => x.Value == (Room)parameter)
                                             .Select(x => x.Key);
                    foreach(var key in Keys)
                    {
                        room.Neighbors[key] = null;
                    }
                }
                //
            }
        }
    }
}
