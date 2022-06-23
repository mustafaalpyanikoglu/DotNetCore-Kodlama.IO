using System;

namespace DictionarysIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Alp", 21);
        }
    }

    class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;

        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] tempKey = _key;
            V[] tempValue = _value;
            _key = new K[_key.Length + 1];
            _value = new V[_key.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_key.Length - 1] = value;
        }
    }
}
