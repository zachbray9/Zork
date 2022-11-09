using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class World //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public World()
        {
            Rooms = new List<Room>();                                //added this in zorkbuilder wpf because initializing a new game did not initalize a world or the rooms list in the world
        }

        //public Room[] Rooms { get; set; }
        public List<Room> Rooms { get; set; }

        [JsonIgnore]  //added because saving in zork builder was serializing the RoomsByName list
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
