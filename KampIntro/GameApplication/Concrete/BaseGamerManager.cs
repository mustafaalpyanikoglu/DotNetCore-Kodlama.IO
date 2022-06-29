using GameApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication.Concrete
{
    abstract class BaseGamerManager : IGamerService
    {
        public void DeleteAccount(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli hesap silindi");
        }

        public virtual void OpenAccount(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli hesap kaydoldu");
        }

        public void UpdateAccount(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli hesap güncellendi");
        }
    }
}
