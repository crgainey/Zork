using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomsForm : Form
    {
        public AddRoomsForm()
        {
            InitializeComponent();
        }

        public string RoomName
        {
            get
            {
                return roomTextBox.Text;
            }
        }
    }
}
