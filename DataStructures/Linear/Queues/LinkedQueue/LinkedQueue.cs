using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.Queues
{
    class LinkedQueue<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                else
                    return Head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                else
                    return Tail.Data;
            }
        }



        public LinkedQueue()
        {
            Clear();
        }

        public LinkedQueue(T data)
        {
            SetHeadAndTail(data);
        }

        public void Enqueue(T data)
        {
            if(IsEmpty)
            {
                SetHeadAndTail(data);
                return;
            }
            else
            {
                var node = new Node<T>(data);

                var tmpNode = Tail;
                Tail.Next = node;
                Tail = node;
                Count++;
            }
        }


        public T Dequeue()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var item = Head;
                Head = Head.Next;
                Count--;
                return item.Data;
            }
        }

        public T Peek()
        {
            return IsEmpty ? throw new InvalidOperationException() : Head.Data;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var node = new Node<T>(data);

            Head = node;
            Tail = node;
            Count = 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
