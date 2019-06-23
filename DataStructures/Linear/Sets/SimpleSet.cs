using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Linear.Sets
{
    /// <summary>
    /// 5 операций с множествами:
    /// 1). Union - обьединение (в 2 стороны)
    /// 2). Intersection - пересечение (в 2 стороны)
    /// 3). Difference - разность (2 разных варианта)
    /// 4). Subset - подмножество ()
    /// 5). Symetric Difference - симетричная разность
    /// 
    /// Нужно реализовать на HastTable
    /// 
    /// Все значения в коллекции не могут повторяться
    /// </summary>
    class SimpleSet<T> //: IEnumerable<T>
    {
        private List<T> items = new List<T>(); // O(m*n) в худшем случае

        public int Count => items.Count;

        public SimpleSet() { }

        public SimpleSet(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            items.Add(item);
        }

        public SimpleSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if(items.Contains(item))
            {
                return;
            }

            //foreach (var i in items)
            //{
            //    if(i.Equals(item))
            //    {
            //        return;
            //    }
            //}

            items.Add(item);
        }

        public void Remove(T item)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(item));

            items.Remove(item);
        }

        public SimpleSet<T> Union(SimpleSet<T> set)
        {
            return new SimpleSet<T>(items.Union(set.items));

            //var result = new SimpleSet<T>();

            //foreach (var item in items)
            //{
            //    result.Add(item);
            //}

            //foreach (var item in set.items)
            //{
            //    result.Add(item);
            //}

            //return result;
        }

        public SimpleSet<T> Intersection(SimpleSet<T> set)
        {
            return new SimpleSet<T>(items.Intersect(set.items));

            //var result = new SimpleSet<T>();

            //foreach (var item1 in items)
            //{
            //    foreach(var item2 in set.items)
            //    {
            //        if(item1.Equals(item2))
            //        {
            //            result.Add(item1);
            //            break;
            //        }
            //    }
            //}

            //return result;
        }


        public SimpleSet<T> Difference(SimpleSet<T> set)
        {
            return new SimpleSet<T>(items.Except(set.items));

            //var result = new SimpleSet<T>(items);

            //foreach (var item in set.items)
            //{
            //    result.Remove(item);
            //}

            //return result;
        }

        public bool Subset(SimpleSet<T> set)
        {
            return set.items.All(i => items.Contains(i));

            //foreach (var item in set.items)
            //{
            //    if (items.Contains(item))
            //        continue;
            //    else
            //        return false;
            //}

            //return true;

        }

       
        //IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //    foreach (var item in items)
        //    {
        //        yield return item;
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return items.GetEnumerator();
        //}
    }
}
