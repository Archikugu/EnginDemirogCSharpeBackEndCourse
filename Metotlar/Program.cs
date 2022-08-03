using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar tekrar tekrar kullanılan kod bloklarıdır

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //Type safe - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("-----------Metotlat----------");

            //instance -- class örneği 
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Sil(urun1);

            //sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
        }
    }
}
//Don't Repeat Yourself ! - DRY - Clean Code - Best Practice
