using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Hashtable<K, V>
    {
        public const double X = 128.0;
        public LinkedList<K, V>[] nodes;

        public Hashtable(int size)
        {
            nodes = new LinkedList<K, V>[size];
        }

        public Hashtable()
        {

        }

        public LinkedList<K, V>[] getNodes()
        {
            return nodes;
        }

        public void add(K key, V value)
        {
            if (nodes[hashFunction(key)] == null)
            {
                nodes[hashFunction(key)] = new LinkedList<K, V>(key, value);
            }
            else
            {
                nodes[hashFunction(key)].add(key, value);
            }
        }

        public long hashFunction(K key)
        {
            long nKey = toAscii(key);
            nKey = (nKey % nodes.Length);
            return nKey;
        }

        public long toAscii(K key)
        {
            string nKey = "" + key;
            long res = 0;
            int c = 0;
            while (c < nKey.Length)
            {
                res += (long.Parse("" + char.GetNumericValue(nKey[c]) * Math.Pow(128, nKey.Length - 1 - c)));
                c++;
            }
            return res;
        }

        public void setNodes(LinkedList<K, V>[] nodes)
        {
            this.nodes = nodes;
        }



    }
}
