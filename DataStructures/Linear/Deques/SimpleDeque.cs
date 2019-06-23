using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Linear.Deques
{
    class SimpleDeque<T> // need to continue 
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public SimpleDeque() { }

        public void PushBack(T data)
        {
            items.Insert(0, data);
        }

        public void PushFront(T data)
        {
            items.Add(data);
        }

        public T PeekBack()
        {
            return items.First();
        }

        public T PeekFront()
        {
            return items.Last();
        }

        public T PopBack()
        {
            var item = items.First();
            items.Remove(item);
            return item;
        }

        public T PopFront()
        {
            var item = items.Last();
            items.Remove(item);
            return item;
        }
    }
}
