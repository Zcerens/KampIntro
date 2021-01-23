using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        

        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); //Böyle yazarsan tüm başvuruları konut kredisi üzerinden hesaplar.Tüm başvuruları konut kredisine bağlı hale getirdin.

            krediManager.Hesapla(); //gönderdiğin şeye göre çalışır(tasit,konut vs vs)
            //loggerService.Log(); // Hangi loglayıcı secılmısse onu logla
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

      
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
