using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player 
    {
        public EventHandler<Room> LocationChanged;
        
        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get => _location;
            private set
            {
                if (_location != value)
                {
                    _location = value;
                    LocationChanged?.Invoke(this, _location);
                }
            }
        }

        public Room PreviousRoom { get; set; }

        public int NumberOfMoves { get; set; }

        public int CurrentScore { get; set; }


        public Player(World world, string startingLocation)
        {
            World = world;
            Location = world.RoomsByName[startingLocation];
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room neighbor);
            if (isValidMove)
            {
                Location = neighbor;
            }

            return isValidMove;
        }

        private Room _location;
    }
}
