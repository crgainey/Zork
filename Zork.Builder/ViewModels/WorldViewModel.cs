using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
//using Zork.Common;

namespace Zork.Builder.ViewModels
{
    internal class WorldViewModel
    {
        public BindingList<Room> Rooms { get; set; }
    }
}
