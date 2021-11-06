using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.UserControls
{
    public partial class NeighborUserControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Room Room
        {
            get => _rooms;
            set
            {
                if (_rooms != value)
                {
                    {
                        _rooms = value;
                        if (_rooms != null)
                        {
                            var neighbors = new List<Room>(_viewModel.Rooms);
                            neighbors.Insert(0, NoNeighbor);
                            neighborComboBox.SelectedIndexChanged -= neighborComboBox_SelectedIndexChanged;
                            neighborComboBox.DataSource = neighbors;

                            if(_rooms.Neighbors.TryGetValue(Direction, out Room neighbor))
                            {
                                NeighborRoom = neighbor;
                            }
                            else
                            {
                                NeighborRoom = NoNeighbor;
                            }

                            neighborComboBox.SelectedIndexChanged += neighborComboBox_SelectedIndexChanged;
                        }
                        else
                        {
                            neighborComboBox.DataSource = null;
                        }
                    }
                }


            }
        }

        public NeighborUserControl()
        {
            InitializeComponent();
        }

        public Directions Direction
        {
            get => _directions;

            set
            {
                _directions = value;
                neighborTextBox.Text = value.ToString();
            }
        }

        public Room NeighborRoom 
        {
            get => (Room)neighborComboBox.SelectedItem; 
            set => neighborComboBox.SelectedItem = value; 
        }

        public NeighborUserControl(Directions directions, Room room)
        {
            Direction = directions;
            Room = room ?? throw new ArgumentNullException(nameof(room));
        }
        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_rooms != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if(selectedRoom == NoNeighbor)
                {
                    _rooms.Neighbors.Remove(Direction);
                }
                else
                {
                    _rooms.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        GameViewModel _viewModel;
        Room _rooms;
        Directions _directions;

    }
}
