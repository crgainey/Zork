using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        public static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string roomDecsriptionFileName = "Rooms.json";
            InitializeRoomDescriptions(roomDecsriptionFileName);

            Room perviousRoom = null;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n> ");

                if (perviousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    perviousRoom = CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing");
                        break;

                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command) == false)
                        {
                            Console.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }

        static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invaild direction");

            bool vaildMove = true;
            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    vaildMove = false;
                    break;
            }

            return vaildMove;
        }

        static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        static bool IsDirection(Commands command) => Directions.Contains(command);

        static void InitializeRoomDescriptions(string roomDescriptionFileName) => 
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomDescriptionFileName));

        static Room[,] Rooms;

        static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        enum Feilds
        {
            Name = 0,
            Description = 1
        }

        static (int Row, int Column) Location = (1, 1);
    }
}
