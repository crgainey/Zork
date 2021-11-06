using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork
{
    public class Room : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors{ get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        public Room()
        {
        }

        public Room(string name, string description = null, Dictionary<Directions, string> neighborNames = null)
        {
            Name = name;
            Description = description;
            NeighborNames = neighborNames;
            Neighbors = new Dictionary<Directions, Room>();
        }


        public void UpdateNeightbors(World world)
        {
            Neighbors = new Dictionary<Directions, Room>();
            foreach(var pair in NeighborNames)
            {
                (Directions direction, string name) = (pair.Key, pair.Value);
                Neighbors.Add(direction, world.RoomsByName[name]);
            }
        }

        public override string ToString() => Name;
    }
}
