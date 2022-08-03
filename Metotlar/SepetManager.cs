using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Sil(Urun urun)
        {
            Console.WriteLine("Sepetten Silindi : " + urun.Adi);
        }
        //Hatali kullanım
        //public void Ekle2(string urunAdi,string aciklma,double fiyat ,int stokAdedi)
        //{
        //    Console.WriteLine("Sepete Eklendi : " + urunAdi);
        //}
    }
}
