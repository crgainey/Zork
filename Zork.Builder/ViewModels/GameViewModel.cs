using System;
using System.ComponentModel;
//using Zork.Common;
using Zork;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public bool IsGameLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game Game 
        {
            set
            {
                if(_game != value)
                {
                    _game = value;
                    if(_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        Game _game;
    }
}
