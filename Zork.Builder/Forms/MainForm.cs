using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using Zork.Builder.Controls;

namespace Zork.Builder.Forms
{
    public partial class MainForm : Form
    {
        public string assemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        internal GameViewModel ViewModel { get; private set; }

        private bool isWorldLoaded
        {
            get
            {
                return ViewModel.isWorldLoaded;
            }
            set
            {
                ViewModel.isWorldLoaded = value;

                foreach(var control in worldDependentControls)
                {
                    control.Enabled = ViewModel.isWorldLoaded;
                }

                foreach (var menuItem in worldDependentMenuItems)
                {
                    menuItem.Enabled = ViewModel.isWorldLoaded;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            gameViewModelBindingSource.DataSource = ViewModel;

            worldDependentControls = new Control[]
            {
                addRoomButton,
                deleteRoomButton,
                roomNameTextBox,
                roomDescriptionTextBox,
                northNeighborControl,
                southNeighborControl,
                eastNeighborControl,
                westNeighborControl,
                welcomeMessageTextBox,
                exitMessageTextBox,
                startingLocationComboBox
            };

            worldDependentMenuItems = new ToolStripMenuItem[]
            {
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
            };

            directionsControlMap = new Dictionary<Directions, RoomControl>
            {
                { Directions.NORTH, northNeighborControl },
                { Directions.SOUTH, southNeighborControl },
                { Directions.EAST, eastNeighborControl },
                { Directions.WEST, westNeighborControl }
            };

            isWorldLoaded = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                    ViewModel.fileName = openFileDialog.FileName;

                    Room selectedRoom = roomsListBox.SelectedItem as Room;
                    foreach(var Control in directionsControlMap.Values)
                    {
                        Control.Room = selectedRoom;
                    }

                    isWorldLoaded = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsListBox.SelectedItem != null;

            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (var Control in directionsControlMap.Values)
            {
                Control.Room = selectedRoom;
            }

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room (addRoomForm.RoomName, "");
                    ViewModel.Rooms.Add(room);

                }
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this room?", assemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private Control[] worldDependentControls;
        private ToolStripMenuItem[] worldDependentMenuItems;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveGame();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.fileName = saveFileDialog.FileName;
                ViewModel.SaveGame();
            }
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startingLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private readonly Dictionary<Directions, RoomControl> directionsControlMap;

        private void northNeighborControl_Load(object sender, EventArgs e)
        {

        }
    }
}
