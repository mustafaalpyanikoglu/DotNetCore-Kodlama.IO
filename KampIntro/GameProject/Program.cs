using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer= new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IdentityNumber = 12345
            };
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer);
            Game game = new Game { Id = 1, Name = "Valorant", Price = 1000.0 };
            Campaign campaign = new Campaign { Id = 1, Name = "Beleş", Sale = 0.5 };
            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.sale(game, gamer, campaign);


        }
    }
}
