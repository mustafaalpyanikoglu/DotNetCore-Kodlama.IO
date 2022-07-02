using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public Campaign Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
            return campaign;
        }

        public Game AppCampaign(Campaign campaign, Game game)
        {
            game.Price = game.Price - (game.Price * campaign.Sale);
            //Console.WriteLine("{0} oyununa {1} kampanyası uygulandı.", game.Name, campaign.CampaignName);
            return game;
        }

    }
}
