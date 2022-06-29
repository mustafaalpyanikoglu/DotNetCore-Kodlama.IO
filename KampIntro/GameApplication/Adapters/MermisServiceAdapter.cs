using GameApplication.Abstract;
using GameApplication.Entities;
using MermisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication.Adapters
{
    public class MermisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(),
            //    gamer.LasterName.ToUpper(), gamer.BirthYear.Year);
            return true;
        }
    }
}
