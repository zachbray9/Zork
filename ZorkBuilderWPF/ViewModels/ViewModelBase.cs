using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkBuilderWPF.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private bool changesWereMade;
        public bool ChangesWereMade
        {
            get
            {
                return changesWereMade;
            }
            set
            {
                changesWereMade = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            changesWereMade = true;
        }
    }
}
