using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList<K, V>
    {

        private HashNode<K, V> first;

        public LinkedList(K key, V value)
        {
            first = new HashNode<K, V>(key, value);
        }

        public HashNode<K, V> getFirst()
        {
            return first;
        }

        public void setFirst(HashNode<K, V> first)
        {
            this.first = first;
        }

        public void add(K key, V value)
        {
            HashNode<K, V> newHashNode = new HashNode<K,V>(key, value);
            HashNode<K, V> actual = first;
            if (first == null)
            {
                first = newHashNode;
            }
            else
            {
                while (actual.getNext() != null)
                {
                    actual = actual.getNext();
                }
                actual.setNext(newHashNode);
                newHashNode.setPrev(actual);
            }
        }

        public void delete(V value)
        {
            if (first.getValue().Equals(value))
            {
                first = first.getNext();
            }
            else
            {
                HashNode<K, V> actual = first;
                while (actual.getNext() != null)
                {
                    if (actual.getValue().Equals(value))
                    {
                        actual.getNext().setPrev(actual.getPrev());
                        actual.getPrev().setNext(actual.getNext());
                        actual.setNext(null);
                        actual.setPrev(null);
                    }
                    else
                    {
                        actual = actual.getNext();
                    }
                }
            }
        }


    }
}
