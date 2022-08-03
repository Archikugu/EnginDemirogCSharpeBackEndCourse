using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Donguler 
            //Birbirine benzeyen işlemleri tekrar etmek için kullanırız

            //i=i+2 || i+=2 ikişer ikişer artırma
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Dongu Bitti \n");

            string kurs1 = "Yazilim Gelistirici Kampi C#";
            string kurs2 = "Programlamaya baslangic icin temel kursu";
            string kurs3 = "Yazilim Gelistirici Kampi Java";
            string kurs4 = "Python";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //Array -dizi 
            string[] kurslar = new string[] { "Yazilim Gelistirici Kampi C#", "Programlamaya baslangic icin temel kursu", "Yazilim Gelistirici Kampi Java","C++","Python"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For dongusu bitti");

            //Dizi temelli yapıları tek tek dönmeye yarıyor foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
