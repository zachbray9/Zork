using System;
using System.IO;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        internal GameViewModel ViewModel { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
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
            MessageBox.Show("Not yet implemented.");
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }
    }
}
