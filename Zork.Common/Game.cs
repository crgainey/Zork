using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public World World { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        public IOutputService Output { get; set; }

        public IInputService Input { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }
        [JsonIgnore]
        public bool IsRunning { get; set; }


        public static Game Load(string filename, IInputService input, IOutputService output)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = new Player(game.World, game.StartingLocation);
            game.Output = output;
            return game;

        }

        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }

        public void Start(IInputService input, IOutputService output)
        {
            Assert.IsNotNull(input);
            Input = input;
            Input.InputRecieved += InputRecievedHandler;

            Assert.IsNotNull(output);
            Output = output;

            IsRunning = true;
        }

        private void InputRecievedHandler(object sender, string commandString)
        {
            Commands command = Commands.UNKNOWN;
            command = ToCommand(commandString);
            switch (command)
            {
                case Commands.QUIT:
                    Player.NumberOfMoves++;
                    Output.WriteLine(ExitMessage);
                    IsRunning = false;
                    break;

                case Commands.LOOK:
                    Player.NumberOfMoves++;
                    Output.WriteLine(Player.Location.Description);
                    break;

                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    Directions direction = (Directions)command;
                    if (Player.Move(direction) == false)
                    {
                        Player.NumberOfMoves++;
                        Output.WriteLine("The way is shut!");
                    }
                    break;
                case Commands.SCORE:
                    Player.NumberOfMoves++;
                    Output.WriteLine($"Your score would be {Player.CurrentScore}, in {Player.NumberOfMoves} move(s).");
                    break;
                case Commands.REWARD:
                    Player.NumberOfMoves++;
                    Player.CurrentScore++;
                    Output.WriteLine($"Your score is now {Player.CurrentScore}.");
                    break;

                default:
                    Output.WriteLine("Unknown command.");
                    break;
            }
        }

        static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
    
}
