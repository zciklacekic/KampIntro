using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> countries = new MyDictionary<string, string>();

            countries.Add("TR", "Turkey");              //add function
            countries.Add("DE", "Germany");
            countries.Add("UA", "Ukraine");
            countries.Add("EG", "Egypt");

            Console.WriteLine(countries.Count);         //count property
            for (int i = 0; i < countries.Count; i++)   
            {
                countries.Write(i);                     //print value function
            }
        }
    }
}