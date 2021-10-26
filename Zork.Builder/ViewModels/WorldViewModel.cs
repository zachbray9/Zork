using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder
{
    public class WorldViewModel
    {
        public BindingList<Room> Rooms { get; set; }

        public World World
        {

            set
            {
                if(_world != value)
                {
                    _world = value;
                    if(_world != null)
                    {
                        Rooms = new BindingList<Room>(_world.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        private World _world;
    }
}
