using System;
using System.ComponentModel;
using Zork.Common;

namespace Zork.Builder
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {

            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveGame()
        {

        }

        private Game _game;
    }
}
