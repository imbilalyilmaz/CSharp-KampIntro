using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0]; 
            values = new V[0];   
        }

        public void Add(K key, V value)
        {
            
            
            K[] tempK = keys;
            keys = new K[keys.Length+1];
            for (int i = 0; i < tempK.Length; i++)
            {
                tempK[i] = keys[i];
            }
            keys[keys.Length - 1] = key;


            V[] tempV = values;
            values = new V[values.Length+1];
            for (int i = 0; i < tempV.Length; i++)
            {
                tempV[i] = values[i];
            }
            values[values.Length - 1] = value;


        }

    }
}
