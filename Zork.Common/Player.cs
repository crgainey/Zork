using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Player 
    {
        public World World { get; }

        [JsonIgnore]
        public Room CurrentRoom { get; set; }

        public Room PreviousRoom { get; set; }

        public int NumberOfMoves { get; set; }

        public int CurrentScore { get; set; }

        [JsonIgnore]
        public string CurrentRoomName
        {
            get 
            { 
                return CurrentRoom?.Name; 
            }
            set 
            {
                CurrentRoom = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            CurrentRoomName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = CurrentRoom.Neighbors.TryGetValue(direction, out Room neighbor);
            if (isValidMove)
            {
                CurrentRoom = neighbor;
            }

            return isValidMove;
        }

    }
}
