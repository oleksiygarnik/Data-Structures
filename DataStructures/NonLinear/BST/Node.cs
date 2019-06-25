using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.NonLinear.BST
{
    class Node<T> : IComparable<T>
        where T : IComparable
    {
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

        public Node<T> Left { get;  set; }

        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if(node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                    Left = node;
                else
                    Left.Add(data);
            }
            else
            {
                if (Right == null)
                    Right = node;
                else
                    Right.Add(data);
            }
        }
        public int CompareTo(Node<T> obj)
        {
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Не совпадение типов");
            }
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
    }
}
