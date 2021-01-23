using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
   
            IKrediManager tasitKrediManager = new TasitKrediManager();
   
            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            basvuruManager.BasvuruYap(new KonutKrediManager(), new List<ILoggerService> { new FileLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
