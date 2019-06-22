using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.LinkedList
{
    public class Node<T> 
    {
        /// <summary>
        /// Data that stores in cell of linked list
        /// </summary>
        private T data = default(T);

        /// <summary>
        /// Next cell of list
        /// </summary>
        public Node<T> Next { get; set; }

        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

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
