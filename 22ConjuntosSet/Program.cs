using System;
using System.Collections.Generic;

namespace ConjuntosSet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashSet

            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook"));    //true

            //foreach(string p in set)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region SortedSet

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new SortedSet<int>(a);   // instancia c com os elementos do a
            c.UnionWith(b);         // união com os elementos do b (sem repetir elementos)
            PrintCollection(c);     // printa o resultado

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            c.IntersectWith(b);     // intersecção (elementos que existem dos 2 conjuntos)
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);        // diferença = elementos de a - elementos de b
            PrintCollection(e);

            #endregion
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
