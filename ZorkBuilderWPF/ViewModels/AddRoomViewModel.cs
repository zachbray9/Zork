using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZorkBuilderWPF.Commands;

namespace ZorkBuilderWPF.ViewModels
{
    public class AddRoomViewModel : ViewModelBase, IClosable
    {
        public ZorkBuilderViewModel ZorkBuilderViewModel;

        public AddRoomViewModel(ZorkBuilderViewModel zorkBuilderViewModel)
        {
            ZorkBuilderViewModel = zorkBuilderViewModel;

            ConfirmAddRoomCommand = new ConfirmAddRoomCommand(this);
        }

        private string newRoomName;
        public string NewRoomName
        {
            get => newRoomName;
            set
            {
                newRoomName = value;
                OnPropertyChanged(nameof(NewRoomName));
            }
        }

        private string newRoomDescription;
        public string NewRoomDescription
        {
            get => newRoomDescription;
            set
            {
                newRoomDescription = value;
                OnPropertyChanged(nameof(NewRoomDescription));
            }
        }

        public ICommand ConfirmAddRoomCommand
        {
            get;
        }

        private DelegateCommand closeAddRoomWindowCommand;
        public DelegateCommand CloseAddRoomWindowCommand =>
            closeAddRoomWindowCommand ?? (closeAddRoomWindowCommand = new DelegateCommand(CloseWindow));

        private void CloseWindow()
        {
            Close?.Invoke();
        }

        public Action Close { get; set; }
        
    }

    interface IClosable
    {
        Action Close { get; set; }
    }
}
