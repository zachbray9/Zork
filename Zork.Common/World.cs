using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class World
    {
        public World()
        {
            //added this in zorkbuilder wpf because initializing a new game did not initalize a world or the rooms list in the world
            Rooms = new List<Room>();                               
        }

        public List<Room> Rooms { get; set; }

        [JsonIgnore]
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
