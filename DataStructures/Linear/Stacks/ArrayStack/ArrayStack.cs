using System;

namespace DataStructures.Linear.Stacks.ArrayStack
{
    class ArrayStack<T> : ICloneable
    {
        private T[] items;

        private int current = -1;
        private int size = 10;

        public int MaxCount => items.Length;

        public int Count => current + 1;

        public bool IsEmpty => Count == 0;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if(current < size-1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен");
            }
        }

        public T Pop()
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
                throw new NullReferenceException("Стек пуст");
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
                throw new NullReferenceException("Стек пуст");
            }
        }

        public object Clone()
        {
            T[] newItems = (T[])this.items.Clone();
            return new ArrayStack<T>()
            {
                items = newItems,
                current = this.current,
                size = this.size,
            };

        }
    }
}
