using GameApplication.Abstract;
using GameApplication.Concrete;
using GameApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication.Concrete
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _memberCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _memberCheckService = gamerCheckService;
        }
        public override void OpenAccount(Gamer Gamer)
        {
            if(_memberCheckService.CheckIfRealPerson(Gamer))
            {
                base.OpenAccount(Gamer);
            }
            else
            {
                throw new Exception("Not a valid member");
            }
        }
    }
}
