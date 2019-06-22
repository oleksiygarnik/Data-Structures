using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.LinkedList.Model
{
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// First elem int list
        /// </summary>
        public Node<T> Head { get; private set; }

        /// <summary>
        /// Last elem in list
        /// </summary>
        public Node<T> Tail { get; private set; }

        /// <summary>
        /// Count of elements in list
        /// </summary>
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add new Node to list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if(Count != 0)
            {
                var Node = new Node<T>(data);

                Tail.Next = Node;
                Tail = Node;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Delete Node from list by value
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            if (Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while(current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Append new Node in head of list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var Node = new Node<T>(data)
            {
                Next = Head
            };

            Head = Node;
            Count++;
        }

        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current!= null)
                {
                    if (current.Data.Equals(target))
                    {
                        var Node = new Node<T>(data);
                        Node.Next = current.Next;
                        current.Next = Node;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Delete all Nodes in list
        /// </summary>
        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
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
            return new LinkedListEnumerator<T>(Head, Tail, Count);

            /*Alternative and more simple way of implement GetEnumerator. 
            Then isn't neccessary creating class LinkedListEnumerator.

            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }*/
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return "Linked List" + Count + "elements";
        }
    }

    
}
