using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Linear.Stacks.SimpleStack
{
    class SimpleStack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;

        public T this[int position]
        {
            get
            {
                if (position > 0 && position < Count)
                {
                    return items[position];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (position > 0 && position < Count)
                {
                    items[position] = value != null ? // condition
                        items[position] = value :  //true
                        throw new ArgumentNullException(nameof(value)); //false
                }
            }
        }

        public void Clear()
        {
            items.Clear();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Pop()
        {
            if(!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public object Clone()
        {
            return new SimpleStack<T>()
            {
                items = new List<T>(items)
            };
        }
    }
}
