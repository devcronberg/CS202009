using System;
using System.Collections.Generic;

namespace LambaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 1, 4, 15, 3, 61, 74 };
            //Predicate<int> p = (int a) => { return a % 2 == 0; };
            //Predicate<int> p = (a) => { return a % 2 == 0; };
            Predicate<int> p = a => a % 2 == 0;
            //var r = System.Array.FindAll(a, p);
            var r = System.Array.FindAll(a, a => a % 2 == 0);

            // Action t = () => { Console.WriteLine("I Test1"); };
            Action t = () => Console.WriteLine("I Test1");
            t();

            //Action<string> t1 = (string a) => { Console.WriteLine("I Test2 med " + a); };
            Action<string> t1 = a => Console.WriteLine("I Test2 med " + a);
            t1("*");

            //Func<int, int, int> t2 = (int a, int b) => { return a + b; };
            Func<int, int, int> t2 = (a, b) => a + b;
            Console.WriteLine(t2(5,1));

            //Action<int> t3 = Test2;
            Action<int> t3 = q => {
                Console.WriteLine(q);
                Console.WriteLine("*");
                Console.WriteLine(q);
            };
            t3(1);

            List<int> tal = new List<int> { 5, 5, 1, 7, 3, 312, 5 };

            tal.ForEach(a => Console.WriteLine(a));

            foreach (var item in tal) 
                Console.WriteLine(item);

            Maskine m = new Maskine();
            m.LogMetode = q => Console.WriteLine(q);
            m.LogMetode += q => System.IO.File.AppendAllText(@"c:\temp\t.log", q);
            m.Start();
            m.Stop();
        }

        //static void Test1()
        //{
        //    Console.WriteLine("I Test1");
        //}

        //static void Test2(string a)
        //{
        //    Console.WriteLine("I Test2 med " + a);
        //}

        //static int Plus(int a, int b)
        //{
        //    return a + b;
        //}

        //static bool ErLige(int a)
        //{
        //    return a % 2 == 0;
        //}

        static void Test2(int a) {
            Console.WriteLine(a);
            Console.WriteLine("*");
            Console.WriteLine(a);
        }
    }

    class Maskine
    {

        public Action<string> LogMetode;

        public void Start()
        {
            Log("Nu starter jeg");
        }
        public void Stop()
        {
            Log("Nu stopper jeg");
        }

        private void Log(string txt)
        {
            if (LogMetode != null)
                LogMetode.Invoke(DateTime.Now.ToLongTimeString() + " " + txt);
        }

    }
}
