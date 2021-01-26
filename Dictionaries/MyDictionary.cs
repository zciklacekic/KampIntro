using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<TKey, TValue> //Dictionary definition. Generic Key and value types assigned
    {
        TKey[] keys;
        TValue[] values;
        //declarations of parameter types
        public MyDictionary() //Construction Block
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeys = keys;        //Assigning referance addresses to temprorary arrays for holding the values before new operation.
            TValue[] _tempValues = values;

            keys = new TKey[keys.Length + 1];       //re-create key array with +1 member
            values = new TValue[values.Length + 1]; //re-create value array with +1 member

            for (int i = 0; i < _tempKeys.Length; i++) //copying old values from temparrays to newly created array
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValues[i];
            }
            //at this point new array has +1 free index and contain old values too.
            for (int j = 0; j < _tempKeys.Length; j++)  //this part is copied from a friend used for key check. If key exist, no addition will be made, if key is empty no addition will be made.
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key cannot be null.");
                }
                else if (_tempKeys[j].Equals(key))
                {
                    throw new ArgumentException("An element with the same key already exists in key array");
                }
            }

            keys[keys.Length - 1] = key;            //adding the value from Add(parameter) to key and value.
            values[values.Length - 1] = value;

        }

        public void Write(int index)                //console output for key and value of a given index
        {
            Console.WriteLine("Key : " + keys[index] + " Value : " + values[index]);
        }

        public int Count                            //to get the array length
        {
            get
            {
                return keys.Length;
            }
        }
    }
}