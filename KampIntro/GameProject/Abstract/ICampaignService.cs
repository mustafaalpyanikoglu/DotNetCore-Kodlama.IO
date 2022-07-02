using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        Campaign Update(Campaign campaign);
        public Game AppCampaign(Campaign campaign, Game game);

    }
}
