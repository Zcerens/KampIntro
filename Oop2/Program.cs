using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ceren SAHIN
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ceren";
            musteri1.Soyadi = "SAHIN";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri != Tüzel Müşeri
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //Musteri classı hem GercekMusterinin referasını tutar,
            Musteri musteri4 = new TuzelMusteri(); //hem de TuzelMusteri de referans tutar

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
               
        }
    }
}
