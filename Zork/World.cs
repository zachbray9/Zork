using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Zork
{
    public class World
    {
        public HashSet<Room> Rooms { get; set; }

        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer()
        {
            return new Player(this, StartingLocation);
        }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }

        }

            [JsonProperty]
            private string StartingLocation{ get; set; }

            private Dictionary<string, Room> mRoomsByName;

        
    }
}
