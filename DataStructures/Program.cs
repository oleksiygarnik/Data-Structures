using DataStructures.Linear.DoublyLinkedList;
using DataStructures.Linear.Stacks.ArrayStack;
using DataStructures.Linear.RingLinkedList;
using System;
using DataStructures.Linear.Queues;
using DataStructures.Linear.Deques.LinkedDeque;
using DataStructures.Linear.Sets;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSet<int> set1 = new SimpleSet<int>() { 1, 2, 3, 4, 5 };
            SimpleSet<int> set2 = new SimpleSet<int>() { 4, 5, 6, 7, 8 };

            var subset = new SimpleSet<int>() { 1, 2, 3 };

            if (set1.Subset(subset))
            {
                Console.WriteLine("YRA");
            }
            foreach (var item in set1.SymmetricDifference(set2))
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
