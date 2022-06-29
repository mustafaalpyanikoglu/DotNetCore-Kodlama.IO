using GameApplication.Adapters;
using GameApplication.Concrete;
using GameApplication.Entities;
using System;

namespace GameApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MermisServiceAdapter());
            gamerManager.OpenAccount(new Gamer { BirthYear = new DateTime(2001), FirstName = "Mustafa Alp", LasterName = "Yanıkoğlu" });
        }
    }
}
