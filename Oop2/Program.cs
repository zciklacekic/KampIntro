using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Zafer";
            musteri1.Soyadi = "Ciklacekic";
            musteri1.TcNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "ZombieZafer";
            musteri2.VergiNo = "1234567890";


            //Gercek Musteri- Tuzel Musteri
            //SOLID 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
