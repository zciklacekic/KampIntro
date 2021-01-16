using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Zafer Ciklacekic";
            kurs1.IzlenmeOrani = "34";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Diren Ciklacekic";
            kurs2.IzlenmeOrani = "18";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Doruk Ciklacekic";
            kurs3.IzlenmeOrani = "18";

            //Kurs[] kurslar = new Kurs[]

            Console.WriteLine(kurs1)
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
