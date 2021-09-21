using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public class Room
    {
        public string Name { get; }
        public string Description { get; set; }

        //Overrides the ToString method that is inherited from System.Object when trying to use Console.Write(CurrentRoom) because CurrentRoom isn't a string.
        public override string ToString() => Name;                    

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }
    }
}
