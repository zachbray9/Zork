using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
