using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        Game Update(Game game);

    }
}
