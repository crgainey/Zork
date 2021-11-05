using System;
using System.Windows.Forms;
using Zork;
using System.IO;
using Newtonsoft.Json;
using Zork.Builder.Forms;
using System.Reflection;
using System.Linq;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        bool IsGameLoaded
        {
            get
            {
                return _viewModel.IsGameLoaded;
            }
            set
            {
                _viewModel.IsGameLoaded = value;

                foreach(var control in _gameDependentControls)
                {
                    control.Enabled = _viewModel.IsGameLoaded;
                }

                foreach(var menuItem in _gameDependentMenuItem)
                {
                    menuItem.Enabled = _viewModel.IsGameLoaded;
                }
            }
        }

        GameViewModel ViewModel 
        {
            get => _viewModel;
            
            set
            {
                if(_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }

            } 
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _gameDependentControls = new Control[]
            {
                roomsGroupBox,
                roomAttributesGroupBox,
                gameAttributesGroupBox
            };

            _gameDependentMenuItem = new ToolStripMenuItem[]
            {
                saveFileToolStripMenuItem,
                saveAsToolStripMenuItem,
                
            };

            IsGameLoaded = false;
        }

        #region Menu Strip Items
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    IsGameLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu Strip

        #region Buttons
        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomsForm addRoomsForm = new AddRoomsForm())
            {
                if (addRoomsForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Room room in ViewModel.Rooms)
                    {
                        if (room.Name.Equals(addRoomsForm.RoomName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Room already exists.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    {
                        Room room = new Room(addRoomsForm.RoomName);
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsList.SelectedItem != null;
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsList.SelectedItem);
                roomsList.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        #endregion Buttons


        GameViewModel _viewModel;
        Control[] _gameDependentControls;
        ToolStripMenuItem[] _gameDependentMenuItem;

    }

}
