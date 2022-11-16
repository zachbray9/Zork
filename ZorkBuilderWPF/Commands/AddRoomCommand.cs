using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkBuilderWPF.ViewModels;
using Zork.Common;
using System.Collections.ObjectModel;
using ZorkBuilderWPF.Views;

namespace ZorkBuilderWPF.Commands
{
    public class AddRoomCommand : CommandBase
    {
        ZorkBuilderViewModel ZorkBuilderViewModel;

        public AddRoomCommand(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;
        }

        public override void Execute(object parameter)
        {
            //ZorkBuilderViewModel.Game.World.Rooms.Add(new Room("New Room", "New room default description."));
            //ZorkBuilderViewModel.Rooms = new ObservableCollection<Room>(ZorkBuilderViewModel.Game.World.Rooms);
            //ZorkBuilderViewModel.UpdateRoomNamesList();

            AddRoomView addRoomView = new AddRoomView()
            {
                DataContext = new AddRoomViewModel(ZorkBuilderViewModel),
                Owner = App.Current.MainWindow
            };
            addRoomView.Show();
        }
    }
}
