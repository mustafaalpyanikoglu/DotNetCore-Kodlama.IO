using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IOrderService
    {
        void sale(Game game, Gamer gamer, Campaign campaign);
    }
}
