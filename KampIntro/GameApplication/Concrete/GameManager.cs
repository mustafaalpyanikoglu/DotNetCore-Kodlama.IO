using GameApplication.Abstract;
using GameApplication.Adapters;
using GameApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication.Concrete
{
    public class GameManager:IGameService
    {
        private IGameService _gameService;
        public GameManager()
        {
            _gameService = new BaseGameManager();
        }

        public void AddGame(Game game)
        {
            _gameService.AddGame(game);
        }

        public void DeleteGame(Game game)
        {
            _gameService.DeleteGame(game);
        }

        public void UpdateGame(Game game)
        {
            _gameService.UpdateGame(game);
        }
    }
}
