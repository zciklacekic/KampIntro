using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Zafer","Salih","Huseyin","Suleyman" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "Ilker"; Dizi 4 elemanlı oluşturuldugu için 5. elemanı ekleyemeyiz.
            //Console.WriteLine(isimler[4]);
            List<string> isimler2 = new List<string> {"Zafer","Salih","Huseyin","Suleyman"};
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
