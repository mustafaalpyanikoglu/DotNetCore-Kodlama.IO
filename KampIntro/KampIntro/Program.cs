using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu.");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu.");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu.");
            }

            if(sistemeGirisYapmisMi)
            {
                Console.WriteLine("Sisteme giriş yapıldı.");
            }
            else
            {
                Console.WriteLine("Hata!");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
