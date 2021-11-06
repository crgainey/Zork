using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
using Zork.Builder.Forms;
using Zork;
using System.Collections.Generic;
using Zork.Builder.UserControls;

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

            _NeighborControlMap = new Dictionary<Directions, NeighborUserControl>
            {
                { Directions.NORTH, neighborNorthUserControl},
                { Directions.SOUTH, neighborSouthUserControl},
                { Directions.WEST, neighborWestUserControl},
                { Directions.EAST, neighborEastUserControl}

            };
        }

        #region Menu Strip Items
        
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog( ) == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    ViewModel.Filename = openFileDialog.FileName;
                    IsGameLoaded = true;

                    Room selectedRoom = roomsList.SelectedItem as Room;
                    foreach (var entry in _NeighborControlMap)
                    {
                        entry.Value.Room = selectedRoom;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e) => _viewModel.SaveGame(ViewModel.Filename);

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                _viewModel.SaveGame(ViewModel.Filename);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        #endregion Menu Strip

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


        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsList.SelectedItem);
                roomsList.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsList.SelectedItem != null;
            Room selectedRoom = roomsList.SelectedItem as Room;
            foreach (var entry in _NeighborControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        GameViewModel _viewModel;
        Control[] _gameDependentControls;
        ToolStripMenuItem[] _gameDependentMenuItem;
        readonly Dictionary<Directions, NeighborUserControl> _NeighborControlMap;

    }

}
