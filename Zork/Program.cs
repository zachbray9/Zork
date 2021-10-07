using System.IO;
using Newtonsoft.Json;

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
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFileName));
            game.Run();

        }

    }
}