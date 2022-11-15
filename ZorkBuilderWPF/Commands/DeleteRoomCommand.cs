using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }
    }
}
