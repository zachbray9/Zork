using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Zork.Common
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Room[] Rooms { get; set; }

        public Dictionary<string, Room> RoomsByName { get; private set; }


        [OnDeserialized]
        public void OnDeserialized(StreamingContext context)
        {
            RoomsByName = new Dictionary<string, Room>();
            foreach(Room room in Rooms)
            {
                RoomsByName.Add(room.Name, room);
            }

            foreach(Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }
    }
}
