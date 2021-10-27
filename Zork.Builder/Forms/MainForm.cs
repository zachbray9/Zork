using System;
using System.IO;
using System.Windows.Forms;
using Zork;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        internal WorldViewModel ViewModel { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
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
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
