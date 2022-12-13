using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork.Common
{
    public class Player //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        public World World { get; }

        [JsonIgnore]
        public Room CurrentRoom{ get; set; }

        [JsonIgnore]
        public Room PreviousRoom { get; set; }

        [JsonIgnore]
        public int MovesCount { get; private set; }

        [JsonIgnore]
        public int Score { get; private set; }


        public Player(World world, string startingLocation)
        {
            MovesCount = 0;
            Score = 0;
            World = world;
            CurrentRoom = World.RoomsByName[startingLocation];

        }


        public bool Move(Directions direction)
        {

            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);
            if(isValidMove)
            {
                //returns false if the neighbor you are trying to go to is the current room. (Zork builder neighbors combo box does not allow for an empty option)
                if (CurrentRoom == CurrentRoom.Neighbors[direction])
                    return false;
                //

                CurrentRoom = neighbor;
            }

            return isValidMove;

        }

        public void IncrementMovesCount()
        {
            MovesCount += 1;
        }


        public void AddScore(int amountToAdd)
        {
            Score += amountToAdd;
        }
    }
}
