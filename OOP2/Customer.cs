using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Customer
    {
        //1 Classlar içerisende özellik tutar
        //2 içerisinde operasyonlar tutar ikisi aynı yerde olmaz

        public int Id { get; set; }
        public string CustomerNumber { get; set; }


        /*Eğerki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa o nesneye ait değilmiş gibi duruyorsa orada hata yapıyoruz soyutlama hatası */

        //Yazılımlar yıllarca geliştirilir sürekli personel değişir,zamanla yazılım geliştiriciler değişir ihtiyaçlar değişir o yüzden Kodlar sürekli aynı kalmaz güncellenebilir olmalı
        //BugFree Hatasız kodlama dünyanın hiç bir yerinde yoktur

        //Customer, Product, Employee vs Entity dir onların içerinse operasyon olmaz

    }
}
