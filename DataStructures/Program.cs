using DataStructures.Linear.DoublyLinkedList;
using DataStructures.Linear.Stacks.ArrayStack;
using DataStructures.Linear.RingLinkedList;
using System;
using DataStructures.Linear.Queues;
using DataStructures.Linear.Deques.LinkedDeque;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedDeque<int> deque = new LinkedDeque<int>();

            deque.PushFirst(1);
            deque.PushFirst(2);
            deque.PushFirst(3);
            deque.PushFirst(4);
            deque.PushFirst(5);
            deque.PushLast(6);
            deque.PushLast(7);
            deque.PushLast(8);
            deque.PushLast(9);
            deque.PushLast(10);

            Console.WriteLine(deque.Last);

            foreach (var item in deque)
            {
                Console.Write(item + " ");
            }
            //RingLinkedList<int> list = new RingLinkedList<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //list.Remove(5);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //list.Remove(5);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //foreach (var item in list.Reverse())
            //{
            //    Console.Write(item + " ");
            //}



            //Car car = new Car { Name = "Ford", Number = "AA5089BA" };
            //Car car1 = new Car { Name = "Nissan", Number = "AA5070AA" };
            //Car car2 = new Car { Name = "Ford", Number = "AA5089BB" };
            //Car car3 = new Car { Name = "Porshe", Number = "AA5089BB" };

            //var list = new LinkedList<Car>();
            //list.Add(car);
            //list.Add(car1);
            //list.Add(car2);


            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //list.Remove(car2);
            //list.InsertAfter(car1, car3);
            //list.AppendHead(car3);

            ////list.Remove(3);
            ////list.Remove(7);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();


            Console.ReadLine();


        }
    }
}
