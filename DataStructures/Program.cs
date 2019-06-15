using DataStructures.Linear.LinkedList.Model;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.Remove(1);
            list.Remove(3);
            list.Remove(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.InsertAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
