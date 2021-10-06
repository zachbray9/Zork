using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zork
{
    class Game
    {
        public World World { get; }

        public static Game Load(string fileName)
        {
            Game game = JsonConvert.DeserializeObject<Game>(fileName);
            return game;
        }
    }
}
