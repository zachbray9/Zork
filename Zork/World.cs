using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    class World
    {
        public HashSet<Room> Rooms { get; set; }

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer()
        {
            return new Player(this, StartingLocation);
        }

        [OnDeserialized]
        private void OnDeserizalized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(Room => room.Name, room => room);

            foreach(Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

    }
}
