
namespace Zork.Builder
{
    partial class ZorkBuilder
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
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomDescriptionText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.gameAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.startingLocationLabel = new System.Windows.Forms.Label();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.startingLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neighborUserControl1 = new Zork.Builder.UserControls.NeighborUserControl();
            this.neighborUserControl2 = new Zork.Builder.UserControls.NeighborUserControl();
            this.neighborUserControl3 = new Zork.Builder.UserControls.NeighborUserControl();
            this.neighborUserControl4 = new Zork.Builder.UserControls.NeighborUserControl();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.roomsGroupBox.SuspendLayout();
            this.roomAttributesGroupBox.SuspendLayout();
            this.gameAttributesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(587, 24);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newFileToolStripMenuItem,
            openFileToolStripMenuItem,
            toolStripMenuItem3,
            this.saveFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            toolStripMenuItem4,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            newFileToolStripMenuItem.Text = "&New File";
            newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            openFileToolStripMenuItem.Text = "&Open File";
            openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFileToolStripMenuItem.Text = "&Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // roomsList
            // 
            this.roomsList.DataSource = this.roomsBindingSource;
            this.roomsList.DisplayMember = "Name";
            this.roomsList.FormattingEnabled = true;
            this.roomsList.Location = new System.Drawing.Point(7, 20);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(171, 225);
            this.roomsList.TabIndex = 0;
            this.roomsList.ValueMember = "Name";
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.deleteRoomButton);
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsList);
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(190, 280);
            this.roomsGroupBox.TabIndex = 0;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(103, 251);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(22, 251);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomAttributesGroupBox
            // 
            this.roomAttributesGroupBox.Controls.Add(this.neighborUserControl4);
            this.roomAttributesGroupBox.Controls.Add(this.neighborUserControl3);
            this.roomAttributesGroupBox.Controls.Add(this.neighborUserControl2);
            this.roomAttributesGroupBox.Controls.Add(this.neighborUserControl1);
            this.roomAttributesGroupBox.Controls.Add(this.descriptionLabel);
            this.roomAttributesGroupBox.Controls.Add(this.roomDescriptionText);
            this.roomAttributesGroupBox.Location = new System.Drawing.Point(208, 27);
            this.roomAttributesGroupBox.Name = "roomAttributesGroupBox";
            this.roomAttributesGroupBox.Size = new System.Drawing.Size(367, 423);
            this.roomAttributesGroupBox.TabIndex = 0;
            this.roomAttributesGroupBox.TabStop = false;
            this.roomAttributesGroupBox.Text = "Room Attributes";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 287);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // roomDescriptionText
            // 
            this.roomDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionText.Location = new System.Drawing.Point(6, 303);
            this.roomDescriptionText.Name = "roomDescriptionText";
            this.roomDescriptionText.Size = new System.Drawing.Size(355, 111);
            this.roomDescriptionText.TabIndex = 1;
            this.roomDescriptionText.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(6, 40);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(162, 20);
            this.welcomeMessageTextBox.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(6, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(98, 13);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome Message";
            // 
            // gameAttributesGroupBox
            // 
            this.gameAttributesGroupBox.Controls.Add(this.startingLocationLabel);
            this.gameAttributesGroupBox.Controls.Add(this.startingLocationComboBox);
            this.gameAttributesGroupBox.Controls.Add(this.welcomeLabel);
            this.gameAttributesGroupBox.Controls.Add(this.welcomeMessageTextBox);
            this.gameAttributesGroupBox.Location = new System.Drawing.Point(12, 314);
            this.gameAttributesGroupBox.Name = "gameAttributesGroupBox";
            this.gameAttributesGroupBox.Size = new System.Drawing.Size(190, 136);
            this.gameAttributesGroupBox.TabIndex = 4;
            this.gameAttributesGroupBox.TabStop = false;
            this.gameAttributesGroupBox.Text = "Game Attributes";
            // 
            // startingLocationLabel
            // 
            this.startingLocationLabel.AutoSize = true;
            this.startingLocationLabel.Location = new System.Drawing.Point(6, 74);
            this.startingLocationLabel.Name = "startingLocationLabel";
            this.startingLocationLabel.Size = new System.Drawing.Size(87, 13);
            this.startingLocationLabel.TabIndex = 5;
            this.startingLocationLabel.Text = "Starting Location";
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.DataSource = this.startingLocationBindingSource;
            this.startingLocationComboBox.DisplayMember = "Name";
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(4, 93);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(161, 21);
            this.startingLocationComboBox.TabIndex = 4;
            this.startingLocationComboBox.ValueMember = "Description";
            // 
            // startingLocationBindingSource
            // 
            this.startingLocationBindingSource.DataMember = "Rooms";
            this.startingLocationBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // neighborUserControl1
            // 
            this.neighborUserControl1.Location = new System.Drawing.Point(94, 32);
            this.neighborUserControl1.Name = "neighborUserControl1";
            this.neighborUserControl1.Size = new System.Drawing.Size(160, 57);
            this.neighborUserControl1.TabIndex = 3;
            // 
            // neighborUserControl2
            // 
            this.neighborUserControl2.Location = new System.Drawing.Point(9, 114);
            this.neighborUserControl2.Name = "neighborUserControl2";
            this.neighborUserControl2.Size = new System.Drawing.Size(160, 57);
            this.neighborUserControl2.TabIndex = 4;
            // 
            // neighborUserControl3
            // 
            this.neighborUserControl3.Location = new System.Drawing.Point(201, 114);
            this.neighborUserControl3.Name = "neighborUserControl3";
            this.neighborUserControl3.Size = new System.Drawing.Size(160, 57);
            this.neighborUserControl3.TabIndex = 5;
            // 
            // neighborUserControl4
            // 
            this.neighborUserControl4.Location = new System.Drawing.Point(112, 201);
            this.neighborUserControl4.Name = "neighborUserControl4";
            this.neighborUserControl4.Size = new System.Drawing.Size(160, 57);
            this.neighborUserControl4.TabIndex = 6;
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 462);
            this.Controls.Add(this.gameAttributesGroupBox);
            this.Controls.Add(this.roomAttributesGroupBox);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.ShowInTaskbar = false;
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.roomsGroupBox.ResumeLayout(false);
            this.roomAttributesGroupBox.ResumeLayout(false);
            this.roomAttributesGroupBox.PerformLayout();
            this.gameAttributesGroupBox.ResumeLayout(false);
            this.gameAttributesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.GroupBox roomAttributesGroupBox;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox roomDescriptionText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.GroupBox gameAttributesGroupBox;
        private System.Windows.Forms.Label startingLocationLabel;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.BindingSource startingLocationBindingSource;
        private UserControls.NeighborUserControl neighborUserControl4;
        private UserControls.NeighborUserControl neighborUserControl3;
        private UserControls.NeighborUserControl neighborUserControl2;
        private UserControls.NeighborUserControl neighborUserControl1;
    }
}

