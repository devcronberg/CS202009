using System;
using System.Collections.Immutable;
using System.Net;
using System.Linq;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 10;

            int[] a = new int[3];
            string[] b = new string[10];
            bool[] c = new bool[2];


            a[1] = 10;
            a[2] = 22;
            
            //Console.WriteLine(a[2]);

            int[] d = { 9, 7, 10, 6 };

            for (int i = 0; i < d.Length; i++)
                Console.WriteLine(d[i]);

            foreach (int item in d)
                Console.WriteLine(item);

            System.Array.ForEach(d, i => Console.WriteLine(i));

            int[] w = (int[])d.Clone();

            Console.WriteLine(w.Length);

            Console.WriteLine();
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            //DateTime z = new DateTime(2020, 10, 1);
            //Console.WriteLine(z);
            //z = z.AddDays(1);
            //Console.WriteLine(z);

            System.Array.Sort(d);
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(FindMindste(d));

            Console.WriteLine();

            int[] p = { 10, 5, 1 };
            Console.WriteLine(string.Join(" ", p));
            int mm = FindMindste(p);
            Console.WriteLine(mm);
            Console.WriteLine(string.Join(" ", p));

            Console.WriteLine();

            int[] p1 = { 1, 5, 1 };
            int[] p2 = { 8, 4, 6, 3, 2, 54, 7, 7 };
            Console.WriteLine(string.Join(" ", p1));
            Console.WriteLine(string.Join(" ", p2));
            p1 = p2;
            

        }

        static int FindMindste(int[] array) {

            //int t = int.MaxValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < t)
            //        t = array[i];
            //}
            //return t;
            //int[] tmp = (int[])array.Clone();
            //System.Array.Sort(tmp);
            //return tmp[0];
            return array.Min();
        
        }

    }
}
