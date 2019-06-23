using System;

namespace DataStructures.Linear.Stacks.LinkedStack
{
    class LinkedStack<T>
    {
        public Node<T> Head { get; set; }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            SetHead(data);
        }

        public void Push(T data)
        {
            if(!IsEmpty)
            {
                var node = new Node<T>(data);

                node.Previous = Head;
                Head = node;
                Count++;
            }
            else
            {
                SetHead(data);
            }
        }

        public T Pop()
        {
            if(!IsEmpty)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        private void SetHead(T data)
        {
            var node = new Node<T>(data);

            Head = node;
            Count = 1;
        }
    }
}
