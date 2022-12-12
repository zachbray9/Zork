using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            ZorkBuilderViewModel.Rooms.Remove((Zork.Common.Room)parameter);
            }
        }
    }
}
