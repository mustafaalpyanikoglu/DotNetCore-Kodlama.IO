using GameApplication.Abstract;
using GameApplication.Adapters;
using GameApplication.Entities;
using GameApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameApplication.Concrete
{
    public class BaseGameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun eklendi.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun silindi.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi.");
        }
    }
}
