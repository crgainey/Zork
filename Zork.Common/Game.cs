using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);

        }

        public void Run()
        {
            Console.WriteLine(WelcomeMessage);

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{Player.CurrentRoom}\n> ");

                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                    Player.PreviousRoom = Player.CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Player.NumberOfMoves++;
                        Console.WriteLine("Thank you for playing");
                        break;

                    case Commands.LOOK:
                        Player.NumberOfMoves++;
                        Console.WriteLine(Player.CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if (Player.Move(direction) == false)
                        {
                            Player.NumberOfMoves++;
                            Console.WriteLine("The way is shut!");
                        }
                        break;
                    case Commands.SCORE:
                        Player.NumberOfMoves++;
                        Console.WriteLine($"Your score would be {Player.CurrentScore}, in {Player.NumberOfMoves} move(s).");
                        break;
                    case Commands.REWARD:
                        Player.NumberOfMoves++;
                        Player.CurrentScore++;
                        Console.WriteLine($"Your score is now {Player.CurrentScore}.");
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
    
}
