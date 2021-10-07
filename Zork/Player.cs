using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zork
{
    public class Player
    {
        public World World { get; }

        //private static (int row, int column) Location = (1, 1);

        [JsonIgnore]
        public Room Location{ get; private set; }

        [JsonIgnore]
        public string LocationName {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }


        public Player(World world, string startingLocation)                    //string startingLocation
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {

            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if(isValidMove)
            {
                Location = destination;
            }

            return isValidMove;

        }
    }
}
