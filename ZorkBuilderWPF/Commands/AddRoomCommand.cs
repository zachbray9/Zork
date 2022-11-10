using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkBuilderWPF.ViewModels;
using Zork.Common;

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
            ZorkBuilderViewModel.Game.World.Rooms.Add(new Room("New Room", "New room default description."));
            ZorkBuilderViewModel.Rooms = ZorkBuilderViewModel.Game.World.Rooms;
            ZorkBuilderViewModel.UpdateRoomNamesList();
        }
    }
}
