using GameApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{
    interface IGamerService
    {
        void OpenAccount(Gamer gamer);
        void UpdateAccount(Gamer gamer);
        void DeleteAccount(Gamer gamer);
    }
}
