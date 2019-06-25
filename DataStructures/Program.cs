using DataStructures.Linear.DoublyLinkedList;
using DataStructures.Linear.Stacks.ArrayStack;
using DataStructures.Linear.RingLinkedList;
using System;
using DataStructures.Linear.Queues;
using DataStructures.Linear.Deques.LinkedDeque;
using DataStructures.Linear.Sets;
using DataStructures.NonLinear.BST;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            foreach (var item in tree.PreOrder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

            foreach (var item in tree.InOrder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

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
