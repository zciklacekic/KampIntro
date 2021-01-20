using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Zafer";
            musteri1.Soyadi = "Ciklacekic";
            musteri1.TC = 12345678901;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Salih";
            musteri2.Soyadi = "Ucar";
            musteri2.TC = 22345678901;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Hamza";
            musteri3.Soyadi = "Kamiloglu";
            musteri3.TC = 22345678901;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            int secim = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("1.Ekle");
                Console.WriteLine("2.Cikar");
                Console.WriteLine("3.Liste");
                Console.WriteLine("0.Cikis");
                secim = Convert.ToInt32(Console.ReadLine());
            }
            while ((secim < 0) | (secim>3));
            switch (secim)
            {
                case 1: 
                    musteriManager.MusteriEkle(musteriler);
                    break;
                case 2: 
                    musteriManager.MusteriSil(musteriler);
                    break;
                case 3: 
                    musteriManager.MusteriList(musteriler);
                    break;
                default:
                    break;
            }


           
            

            //var silId = Console.ReadLine("Musteri Id :");
            //var approve = Console.ReadLine("Emin misiniz ? (Y/N) : ");
            //if (approve.ToUpper = "Y")
            //{
            //    musteriManager.MusteriSil(silId);
            //}

            

        }
    }
}