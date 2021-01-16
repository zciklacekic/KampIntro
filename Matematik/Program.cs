using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(2,3);
            dortIslem.Topla(15, 13);
            dortIslem.Cikar(15, 13);
            dortIslem.Carp(2, 3);
            dortIslem.Bol(15, 5);
        }
    }
}
