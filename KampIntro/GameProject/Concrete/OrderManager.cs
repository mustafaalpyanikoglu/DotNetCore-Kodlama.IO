using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        private ICampaignService _CampaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _CampaignService = campaignService;
        }
        public void sale(Game game, Gamer gamer,Campaign campaign)
        {
            _CampaignService.Add(campaign);
            _CampaignService.AppCampaign(campaign, game);
            Console.WriteLine("{0}'ne {1} kampanyası ile {2} oyunu satıldı.Fiyatı= {3}",gamer.FirstName, campaign.Name, game.Name,game.Price);
        }

    }
}
