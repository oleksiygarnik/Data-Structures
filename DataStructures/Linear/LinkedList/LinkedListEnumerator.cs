using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.LinkedList
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;
        private int position = -1;

        public LinkedListEnumerator(Node<T> head, Node<T> tail, int count)
        {
            this.head = head;
            this.tail = tail;
            this.count = count;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= count)
                    throw new InvalidOperationException();

                var counter = 0;
                var current = head;

                while (counter != position)
                {
                    current = current.Next;
                    counter++;
                }

                return current.Data;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position < count - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
