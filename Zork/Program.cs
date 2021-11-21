using System.IO;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork
{
    class Program
    {

        private enum CommandLineArguments
        {
            GameFileName = 0
        }

        static void Main(string[] args)
        {

            const string defaultGameFileName = "Zork.json";
            string gameFileName = args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFileName;
            //string jsonString = File.ReadAllText(gameFileName);

            //IOutputService output = new ConsoleOutputService();
            //Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            //game.Run();

            ConsoleOutputService output = new ConsoleOutputService();

            Game.StartGameFromFile(gameFileName, output);

        }

    }
}