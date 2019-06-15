using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.LinkedList.Model
{
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// First elem int list
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Last elem in list
        /// </summary>
        public Item<T> Tail { get; private set; }

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
        /// Add new item to list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if(Count != 0)
            {
                var item = new Item<T>(data);

                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Delete item from list by value
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

                while(current.Next != null)
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
        /// Append new item in head of list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
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
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
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
        /// Delete all items in list
        /// </summary>
        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);

            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + "elements";
        }
    }
}
