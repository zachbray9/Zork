
namespace Zork.Builder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.roomNeighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.westNeighborControl = new Zork.Builder.Controls.RoomControl();
            this.eastNeighborControl = new Zork.Builder.Controls.RoomControl();
            this.southNeighborControl = new Zork.Builder.Controls.RoomControl();
            this.northNeighborControl = new Zork.Builder.Controls.RoomControl();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.roomPropertiesGroupBox.SuspendLayout();
            this.roomNeighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveFileSeparatorStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitFileSeparatorStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileSeparatorStripMenuItem
            // 
            this.saveFileSeparatorStripMenuItem.Name = "saveFileSeparatorStripMenuItem";
            this.saveFileSeparatorStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitFileSeparatorStripMenuItem
            // 
            this.exitFileSeparatorStripMenuItem.Name = "exitFileSeparatorStripMenuItem";
            this.exitFileSeparatorStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.deleteRoomButton);
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 118);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(200, 320);
            this.roomsGroupBox.TabIndex = 1;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(100, 276);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(14, 276);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 19);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(188, 251);
            this.roomsListBox.TabIndex = 0;
            this.roomsListBox.ValueMember = "Name";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.AllowNew = true;
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // roomPropertiesGroupBox
            // 
            this.roomPropertiesGroupBox.Controls.Add(this.roomNeighborsGroupBox);
            this.roomPropertiesGroupBox.Controls.Add(this.roomDescriptionTextBox);
            this.roomPropertiesGroupBox.Controls.Add(this.roomDescriptionLabel);
            this.roomPropertiesGroupBox.Controls.Add(this.roomNameTextBox);
            this.roomPropertiesGroupBox.Controls.Add(this.roomNameLabel);
            this.roomPropertiesGroupBox.Location = new System.Drawing.Point(218, 118);
            this.roomPropertiesGroupBox.Name = "roomPropertiesGroupBox";
            this.roomPropertiesGroupBox.Size = new System.Drawing.Size(570, 320);
            this.roomPropertiesGroupBox.TabIndex = 2;
            this.roomPropertiesGroupBox.TabStop = false;
            this.roomPropertiesGroupBox.Text = "Room Properties";
            // 
            // roomNeighborsGroupBox
            // 
            this.roomNeighborsGroupBox.Controls.Add(this.westNeighborControl);
            this.roomNeighborsGroupBox.Controls.Add(this.eastNeighborControl);
            this.roomNeighborsGroupBox.Controls.Add(this.southNeighborControl);
            this.roomNeighborsGroupBox.Controls.Add(this.northNeighborControl);
            this.roomNeighborsGroupBox.Location = new System.Drawing.Point(12, 164);
            this.roomNeighborsGroupBox.Name = "roomNeighborsGroupBox";
            this.roomNeighborsGroupBox.Size = new System.Drawing.Size(535, 150);
            this.roomNeighborsGroupBox.TabIndex = 4;
            this.roomNeighborsGroupBox.TabStop = false;
            this.roomNeighborsGroupBox.Text = "Neighbors";
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Direction = Zork.Common.Directions.WEST;
            this.westNeighborControl.Location = new System.Drawing.Point(382, 53);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Neighbor = null;
            this.westNeighborControl.Room = null;
            this.westNeighborControl.Size = new System.Drawing.Size(127, 53);
            this.westNeighborControl.TabIndex = 3;
            this.westNeighborControl.Load += new System.EventHandler(this.westNeighborControl_Load);
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Direction = Zork.Common.Directions.EAST;
            this.eastNeighborControl.Location = new System.Drawing.Point(30, 53);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Neighbor = null;
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(127, 53);
            this.eastNeighborControl.TabIndex = 2;
            this.eastNeighborControl.Load += new System.EventHandler(this.eastNeighborControl_Load);
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Direction = Zork.Common.Directions.SOUTH;
            this.southNeighborControl.Location = new System.Drawing.Point(202, 91);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Neighbor = null;
            this.southNeighborControl.Room = null;
            this.southNeighborControl.Size = new System.Drawing.Size(127, 53);
            this.southNeighborControl.TabIndex = 1;
            this.southNeighborControl.Load += new System.EventHandler(this.southNeighborControl_Load);
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Direction = Zork.Common.Directions.NORTH;
            this.northNeighborControl.Location = new System.Drawing.Point(202, 19);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Neighbor = null;
            this.northNeighborControl.Room = null;
            this.northNeighborControl.Size = new System.Drawing.Size(127, 53);
            this.northNeighborControl.TabIndex = 0;
            this.northNeighborControl.Load += new System.EventHandler(this.northNeighborControl_Load);
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(12, 121);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(535, 20);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(9, 104);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(9, 54);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(538, 20);
            this.roomNameTextBox.TabIndex = 1;
            this.roomNameTextBox.TextChanged += new System.EventHandler(this.roomNameTextBox_TextChanged);
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(6, 37);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "&Name";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(12, 28);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeMessageLabel.TabIndex = 3;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(414, 28);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            this.exitMessageLabel.TabIndex = 4;
            this.exitMessageLabel.Text = "Exit Message:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(112, 25);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(287, 20);
            this.welcomeMessageTextBox.TabIndex = 5;
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "ExitMessage", true));
            this.exitMessageTextBox.Location = new System.Drawing.Point(493, 28);
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(287, 20);
            this.exitMessageTextBox.TabIndex = 6;
            // 
            // startingLocationLabel
            // 
            this.startingLocationLabel.AutoSize = true;
            this.startingLocationLabel.Location = new System.Drawing.Point(16, 72);
            this.startingLocationLabel.Name = "startingLocationLabel";
            this.startingLocationLabel.Size = new System.Drawing.Size(90, 13);
            this.startingLocationLabel.TabIndex = 7;
            this.startingLocationLabel.Text = "Starting Location:";
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.DataSource = this.roomsBindingSource1;
            this.startingLocationComboBox.DisplayMember = "Name";
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(112, 69);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(287, 21);
            this.startingLocationComboBox.TabIndex = 8;
            this.startingLocationComboBox.ValueMember = "Name";
            this.startingLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.startingLocationComboBox_SelectedIndexChanged);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.gameViewModelBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startingLocationComboBox);
            this.Controls.Add(this.startingLocationLabel);
            this.Controls.Add(this.exitMessageTextBox);
            this.Controls.Add(this.welcomeMessageTextBox);
            this.Controls.Add(this.exitMessageLabel);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.roomPropertiesGroupBox);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.roomsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.roomPropertiesGroupBox.ResumeLayout(false);
            this.roomPropertiesGroupBox.PerformLayout();
            this.roomNeighborsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitFileSeparatorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.GroupBox roomPropertiesGroupBox;
        private System.Windows.Forms.GroupBox roomNeighborsGroupBox;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.ToolStripSeparator saveFileSeparatorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Controls.RoomControl westNeighborControl;
        private Controls.RoomControl eastNeighborControl;
        private Controls.RoomControl southNeighborControl;
        private Controls.RoomControl northNeighborControl;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
    }
}

