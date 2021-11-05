using System;
using System.IO;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;

namespace Zork.Builder.Forms
{
    public partial class MainForm : Form
    {
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
                northComboBox,
                southComboBox,
                eastComboBox,
                westComboBox,
                welcomeMessageTextBox,
                exitMessageTextBox,
                startingLocationComboBox
            };

            worldDependentMenuItems = new ToolStripMenuItem[]
            {
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
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

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName, ""); //{ Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);

                }
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
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
    }
}
