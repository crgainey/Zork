using System;
using System.Windows.Forms;
using Zork;
using System.IO;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {
        internal GameViewModel ViewModel { get; private set; }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        #region Menu Strip Items
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu Strip

        #region Buttons
        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
        #endregion Buttons
    }
}
