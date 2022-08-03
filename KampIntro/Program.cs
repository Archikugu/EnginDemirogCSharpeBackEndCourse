using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler Veri Tutucudur
            //Değişkenler aslında programlamanin en temel konusudur ve biz veriyi onunla yönetiriz.

            //Verileri türlerine göre ayırıyoruz
            //String - Metinsel ifadeleri tutmamızı sağlar

            //Type safety - tip güvenliği  - hangi veri türünü girersen çıktısı da o veri türü olmak zorunda 
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            //Don't Repeat Yourself! - Kendini asla tekrar etme
            //Console.WriteLine("Kategori"); !! Hatalı projede bir yeri değiştirmek zorunda kalırsak tek bir noktadan değiştiremiyoruz 
            //KategoriEtiketi burada değer tutucu yani takma isim alias

            //İnt - Tam sayı veri tiplerini tutar
            int ogrenciSayisi = 32000;

            //Double - Decimal Ondalıklı sayıları tutar.
            double faizOrani = 1.45;

            //Bool - Mantıksal veri tipidir True or False değerini alır.
            bool sistemeGirisYapilmisMi=true;

            //Şart Blokları

            if (sistemeGirisYapilmisMi == true)
            {
                Console.WriteLine("Sisteme giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");

            }
            else
            {
                Console.WriteLine("Eşittir oku");
            }

            









        }
    }
}
