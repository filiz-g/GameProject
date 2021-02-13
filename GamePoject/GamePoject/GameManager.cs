using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + ":" + "Oyun Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + ":" + "Oyun Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + ":" + "Oyun Güncellendi.");
        }
    }
}
