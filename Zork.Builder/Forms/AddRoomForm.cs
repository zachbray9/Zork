using System;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class AddRoomForm : Form
    {
        public string RoomName 
        { 
            get => roomNameTextBox.Text; 
            set => roomNameTextBox.Text = value; 
        }
        public AddRoomForm()
        {
            InitializeComponent();
            OkButton.Enabled = false;
        }
        private void AddRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = !string.IsNullOrEmpty(RoomName);

        }
    }
}
