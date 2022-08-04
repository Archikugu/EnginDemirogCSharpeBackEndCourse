using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerin birbirinin alternatifi ama kod içeriği farklı olan durumlar için kullanılır

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            //basvuruManager.BasvuruYap(tasitKrediManager);

            ILoggerService databaseLoggerServive = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new FileLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers /*new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }*/);

            //Yazilimda surdurebilirlik saglar

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
