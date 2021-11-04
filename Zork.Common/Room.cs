using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors{ get; private set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        public Room(string name, string description = null)
        {
            Name = name;
            Description = description;
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
