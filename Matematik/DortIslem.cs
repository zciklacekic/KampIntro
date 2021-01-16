using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " +sonuc);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuc : " + sonuc);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuc : " + sonuc);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuc : " + sonuc);
        }
    }
}
