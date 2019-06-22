using DataStructures.Linear.LinkedList.Model;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Name = "Ford", Number = "AA5089BA" };
            Car car1 = new Car { Name = "Nissan", Number = "AA5070AA" };
            Car car2 = new Car { Name = "Ford", Number = "AA5089BB" };
            Car car3 = new Car { Name = "Porshe", Number = "AA5089BB" };

            var list = new LinkedList<Car>();
            list.Add(car);
            list.Add(car1);
            list.Add(car2);


            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.Remove(car2);
            list.InsertAfter(car1, car3);
            list.AppendHead(car3);

            //list.Remove(3);
            //list.Remove(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //list.AppendHead(7);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //list.InsertAfter(4, 8);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            Console.ReadLine();


        }
    }
}
