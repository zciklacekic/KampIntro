using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constractor
        public MyList()  //const (iki tab) ile bu blok oluşturuluyor
        {
            items = new T[0];   // liste ilk new edildiğinde 0 elemanlı bir dizi oluşturmak için contructor blogu oluşturuluyor

        }
        public void Add(T item)
        {
            T[] tempArray = items; //referans değişkenini gecici bir array de tutmak için
            items = new T[items.Length + 1]; //irems dizini eleman sayısının bir fazlası ile yeniden initialize ediliyor. 
                                             //Bu sebeple yeni bos bir dizi referansı oluşuyor ancak eleman sayısı bir oncekine gore bir fazla
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items()
        {
            return items;
        }

    }
}
