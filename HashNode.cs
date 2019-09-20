using System;

namespace DataStructures
{
    public class HashNode<K,V>
    {

        private K key;
        private V value;

        private HashNode<K, V> next;
        private HashNode<K, V> prev;

        public HashNode(K key, V value)
        {
            this.key = key;
            this.value = value;
            next = null;
            prev = null;
        }

        public V getValue()
        {
            return value;
        }

        public void setElement(V value)
        {
            this.value = value;
        }

        public HashNode<K, V> getNext()
        {
            return next;
        }

        public void setNext(HashNode<K, V> next)
        {
            this.next = next;
        }

        public HashNode<K, V> getPrev()
        {
            return prev;
        }

        public void setPrev(HashNode<K, V> prev)
        {
            this.prev = prev;
        }

        public K getKey()
        {
            return key;
        }

        public void setKey(K key)
        {
            this.key = key;
        }

        public string toString()
        {
            return "" + key;
        }

    }
}
