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
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Campaign campaign, Game game)
        {
            Console.WriteLine("{0}'ne {1} kampanyası ile {2} oyunu satıldı.", gamer.FirstName, campaign.CampaignName, game.Name);
        }
    }
}
