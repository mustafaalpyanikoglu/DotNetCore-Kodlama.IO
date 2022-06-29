using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApplication.Adapters;
using GameApplication.Entities;


namespace GameApplication.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Campaign campaign, Game game);
    }
}
