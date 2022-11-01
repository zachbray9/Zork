using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.Controls
{
    public partial class RoomControl : UserControl
    {
        public GameViewModel GameViewModel;

        public Room Neighbor 
        {
            get
            {
                return (Room)neighborsComboBox.SelectedItem;
            }
            set
            {
                neighborsComboBox.SelectedItem = value;
            }
        }



        private Room room;
        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                if(room != value)
                {
                    room = value;
                    if(room != null)
                    {
                        //var neighbors = new List<Room>(room.Neighbors.Values.ToList());                                 //this needs to a list of all the rooms minus the current room and its neighbors, not just the neighbors
                        var neighbors = new List<Room>(GameViewModel.Rooms);

                        neighbors.Remove(this.room);
                        neighbors.Insert(0, noRoom);

                        neighborsComboBox.DataSource = neighbors;


                        
                        if(room.Neighbors.TryGetValue(Direction, out Room neighbor))
                        {
                            Neighbor = neighbor;
                        }
                        else
                        {
                            Neighbor = noRoom;
                        }
                    }
                    else
                    {
                        neighborsComboBox.DataSource = null;
                    }
                }
            }
        }

        public Directions Direction { 
            get => direction; 

            set
            {
                direction = value;
                directionTextBox.Text = direction.ToString();
            }
        }

        public RoomControl()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static readonly Room noRoom = new Room("None");
        private Directions direction;
    }
}
