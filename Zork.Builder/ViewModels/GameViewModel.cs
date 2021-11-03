using System;
using System.ComponentModel;
//using Zork.Common;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Player> Players { get; set; }

        public Game Game { get; set; }

        Game _game;
    }
}
