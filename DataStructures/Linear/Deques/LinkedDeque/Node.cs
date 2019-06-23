using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Linear.Deques.LinkedDeque
{
    class Node<T>
    {
        private T data = default(T);

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

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

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
