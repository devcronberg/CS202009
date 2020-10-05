using System;
using System.Collections;
using System.Collections.Generic;

namespace ListerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList a = new ArrayList();
            //a.Add("Mikkel");
            //a.Add("Mathias");
            ////a.Remove("Mikkel");
            //a.Insert(1, "Marie");
            //a.Add(1);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> a = new List<string>();
            a.Add("Mikkel");
            a.Add("Mathias");
            a.Insert(1,"Maria");            
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            //a.Sort();
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            string na = a[0];
            Console.WriteLine(na);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Stack<int> s = new Stack<int>();
            s.Push(5);
            s.Push(8);
            s.Push(10);
            int y = s.Pop();

            Queue<bool> q = new Queue<bool>();
            q.Enqueue(true);
            q.Enqueue(false);
            q.Enqueue(true);
            bool p = q.Dequeue();

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("111111xxxx", 6);
            d.Add("222222xxxx", 54);
            int r = d["222222xxxx"];
            Console.WriteLine();
            foreach (var item in d.Keys)
            {
                Console.WriteLine(item);
            }

        }
    }
}
