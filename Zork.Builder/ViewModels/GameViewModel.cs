using System;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using Zork;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public string Filename { get; set; }

        public string StartingLocation 
        { 
            get => _game.StartingLocation;
            set => _game.StartingLocation = value; 
        }

        public string WelcomeMessage
        {
            get => _game.WelcomeMessage;
            set => _game.WelcomeMessage = value;
        }

        public bool IsGameLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }


        public Game Game 
        {
            get => _game;
            set
            {
                if(_game != value)
                {
                    _game = value;
                    if(_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        StartingLocation = _game.StartingLocation;
                        WelcomeMessage = _game.WelcomeMessage;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        StartingLocation = null;
                        WelcomeMessage = null;
                    }
                }
            }
        }
        public GameViewModel(Game game = null) => Game = game;

        public void SaveGame(string filename)
        {
            if (!IsGameLoaded)
            {
                throw new InvalidOperationException("No game loaded.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }


        Game _game;
    }
}
