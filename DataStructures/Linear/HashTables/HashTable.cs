using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.HashTables
{
    class HashTable<T>
    {
        public T[] items;

        public HashTable(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            var key = GetHashCode(item);
            items[key] = item;
        }

        public bool Search(T item)
        {
            var key = GetHashCode(item);
            return items[key].Equals(item);
      

        }

        private int GetHashCode(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}
