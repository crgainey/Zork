using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";
            string gameFilename = args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFileName;

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOutputService output = new ConsoleOutputService();

            output.WriteLine(game.WelcomeMessage);
            game.Start(input,output);

            while (game.IsRunning)
            {
                output.Write($"{game.Player.Location}\n> ");
                
                if (game.Player.PreviousRoom != game.Player.Location)
                {
                    output.WriteLine(game.Player.Location.Description);
                    game.Player.PreviousRoom = game.Player.Location;
                }

                input.ProcessInput();
            }

        }

        enum CommandLineArguments
        {
            GameFileName = 0
        }

    }
}
