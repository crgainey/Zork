﻿using System;
using System.ComponentModel;
//using Zork.Common;

namespace Zork.Builder
{
    internal class GameViewModel
    {
        public BindingList<Room> Rooms { get; set; }

        // change to Game?? 
        public Game Game
        {
            set
            {
                if(_game != value)
                {
                    _game = value;
                    if(_game != null)
                    {
                        //Rooms = new BindingList<Room>(_world.Rooms);
                    }
                    else
                    {
                        //Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        Game _game;
    }
}
