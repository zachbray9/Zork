﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork.Common
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;

            //added because when adding a new room in zorkbuilder, you couldn't assign neighbors since the UpdateNeighbors function wasn't called upon instantiating a new room
            Neighbors = new Dictionary<Directions, Room>();
            NeighborNames = new Dictionary<Directions, string>();
            //
        }


        //Overrides the ToString method that is inherited from System.Object when trying to use Console.Write(CurrentRoom) because CurrentRoom isn't a string.
        public override string ToString() => Name;

        public void UpdateNeighbors(World world)
        {
            Neighbors = new Dictionary<Directions, Room>();
            foreach(var pair in NeighborNames)
            {
                (Directions direction, string name) = (pair.Key, pair.Value);
                Neighbors.Add(direction, world.RoomsByName[name]);
            }
        }
    }
}
