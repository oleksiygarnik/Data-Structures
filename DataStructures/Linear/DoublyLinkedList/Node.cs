using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.DoublyLinkedList
{
    class Node<T>
    {
        /// <summary>
        /// Data that stores in cell of doubly linked list
        /// </summary>
        private T data = default(T);

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                data = value;
            }
        }

        /// <summary>
        /// Previous cell of list
        /// </summary>
        public Node<T> Previous { get; set; }

        /// <summary>
        /// Next cell of list
        /// </summary>
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
