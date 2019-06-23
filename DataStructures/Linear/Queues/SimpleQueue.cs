using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Linear.Queues
{
    class SimpleQueue<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public SimpleQueue() { }

        public SimpleQueue(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = items.Last();
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return items.Last();
        }

    }
}
