using System;
using System.Windows.Forms;
using Zork;
using System.IO;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {
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
                roomAttributesGroupBox
            };

            _gameDependentMenuItem = new ToolStripMenuItem[]
            {
                saveFileToolStripMenuItem,
                saveAsToolStripMenuItem,
                runToolStripMenuItem
                
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
            MessageBox.Show("Not yet implemented");
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }
        #endregion Buttons


        GameViewModel _viewModel;
        Control[] _gameDependentControls;
        ToolStripMenuItem[] _gameDependentMenuItem;


    }

}
