using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.RingLinkedList
{
    class RingLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Head or first element of list
        /// </summary>
        public Node<T> Head { get; set; }

        /// <summary>
        /// Count elements in list
        /// </summary>
        public int Count { get; set; }

        public RingLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public RingLinkedList(T data)
        {
            SetHead(data);
        }

        /// <summary>
        /// Add new element to doubly linked list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Head == null)
            {
                SetHead(data);
            }
            else
            {
                var node = new Node<T>(data);

                node.Next = Head;
                node.Previous = Head.Previous;
                Head.Previous.Next = node;
                Head.Previous = node;

                Count++;
            }
        }

        /// <summary>
        /// Delete some element in list
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            void RemoveItem(Node<T> current)
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
            }

            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    RemoveItem(Head);

                    Head = Head.Next; 
                    return;
                }

                var current = Head.Next;

                for (int i = Count; i > 0; i--)
                {
                    if(current != null && current.Data.Equals(data))
                    {
                        RemoveItem(current);
                        return;
                    }

                    current = current.Next;
                }
            }
        }

        private void SetHead(T data)
        {
            var node = new Node<T>(data);

            Head = node;
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;

            for(int i = Count; i > 0; i--)
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
