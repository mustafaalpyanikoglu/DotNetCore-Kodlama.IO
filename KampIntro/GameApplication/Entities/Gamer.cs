
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LasterName { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
