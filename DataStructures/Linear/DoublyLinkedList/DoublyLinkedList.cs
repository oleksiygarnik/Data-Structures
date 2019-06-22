using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.DoublyLinkedList
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Head or first element of list
        /// </summary>
        public Node<T> Head { get; set; }

        /// <summary>
        /// Tail or last element of list
        /// </summary>
        public Node<T> Tail { get; set; }

        /// <summary>
        /// Count elements in list
        /// </summary>
        public int Count { get; set; }

        public DoublyLinkedList() { }

        public DoublyLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add new element to doubly linked list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Count != 0)
            {
                var node = new Node<T>(data);

                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Delete some element in list
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            if (Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Head.Previous = null;
                    Count--;
                    return;
                }

                if(Tail.Data.Equals(data))
                {
                    Tail = Tail.Previous;
                    Tail.Next = null;
                    return;
                }

                var current = Head;

                while(current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        Count--;
                        return;
                    }

                    current = current.Next;
       
                }
            }
        }


        /// <summary>
        /// Returns new list with reverse values 
        /// </summary>
        /// <returns></returns>
        public DoublyLinkedList<T> Reverse()
        {
            var result = new DoublyLinkedList<T>();

            var current = Tail;

            while(current!=null)
            {
                result.Add(current.Data);

                current = current.Previous;
            }

            return result;
        }

        /// <summary>
        /// Append new Node in head of list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var node = new Node<T>(data)
            {
                Next = Head,
                Previous = null
            };

            Head.Previous = node;
            Head = node;
        }
        /// <summary>
        /// Set firstly Head and Tails to list
        /// </summary>
        /// <param name="data"></param>
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
