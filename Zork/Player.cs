using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zork
{
    class Player
    {
        public World World { get; }

        //private static (int row, int column) Location = (1, 1);

        [JsonIgnore]
        public Room CurrentRoom{ get; set; }

        [JsonIgnore]
        public Room PreviousRoom { get; set; }


        public Player(World world, string startingLocation)                    //string startingLocation
        {
            World = world;
            CurrentRoom = World.RoomsByName[startingLocation];

            //for(int row = 0; row < World.Rooms.GetLength(0); row++)
            //{
            //    for(int column = 0; column < World.Rooms.GetLength(1); column++ )
            //    {
            //        if(World.Rooms[row, column].Name.Equals(startingLocation, StringComparison.OrdinalIgnoreCase))
            //        {
            //            Location = (row, column);
            //            return;
            //        }
            //    }
            //}
        }

        public bool Move(Directions direction)
        {

            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);
            if(isValidMove)
            {
                CurrentRoom = neighbor;
            }

            return isValidMove;

        }
    }
}
