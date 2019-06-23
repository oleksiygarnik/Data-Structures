using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.Deques.LinkedDeque
{
    class LinkedDeque<T> : IEnumerable<T>
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
                    throw new InvalidCastException();
                else
                    return Tail.Data;
            }
        }

        public LinkedDeque()
        {
            Clear();
        }

        public LinkedDeque(T data)
        {
            SetHeadAndTail(data);
        }

        public void PushFirst(T data)
        {
            if(IsEmpty)
            {
                SetHeadAndTail(data);
            }
            else
            {
                var node = new Node<T>(data);
                node.Next = Head;
                Head.Previous = node;
                Head = node;

                Count++;
            }
        }

        public void PushLast(T data)
        {
            if (IsEmpty)
            {
                SetHeadAndTail(data);
            }
            else
            {
                var node = new Node<T>(data);
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
                Count++;
            }
        }

        public T PopFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            else if(Count == 1)
            {
                Clear();
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
            }

            return Head.Data;
        }

        public T PopLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            else if (Count == 1)
            {
                Clear();
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
                Count--;
            }

            return Tail.Data;
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
            while (current != null)
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
