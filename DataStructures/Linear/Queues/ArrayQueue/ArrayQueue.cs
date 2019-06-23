using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.Queues.ArrayQueue
{
    public class ArrayQueue<T>
    {
        private T[] items;
        private int current = -1;
        private int size = 10;

        public int MaxCount => items.Length;

        public int Count => current + 1;

        public bool IsEmpty => current == 0;

        public ArrayQueue(int size)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayQueue(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current++;
        }

        public void Enqueue(T data)
        {
            if (Count < MaxCount)
            {
                var result = (new T[] { data }).Concat(items).ToArray();

                /*var result = new T[MaxCount];
                result[0] = data;

                for (int i = 0; i < Count; i++)
                {
                    result[i + 1] = items[i];
                }*/

                items = result;
                current++;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен");
            }
           
        }

        public T Dequeue()
        {
            if (!IsEmpty)
            {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
    }
}
