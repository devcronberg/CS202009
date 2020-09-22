using System;
using System.Linq;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Int32 a = new System.Int32();
            int b = new int();
            int c = 1;
            
            a = 1;
            b = 1;

            bool d = false;

            bool e = false;

            if (c==1)
            {
                int f = 100;
                Console.WriteLine(f);
            }
            else
            {
                bool f = true;
            }

            System.Int32 g = new System.Int32();
            g = 400;

            Console.WriteLine(g.ToString());

            System.DateTime h = new DateTime();
            Console.WriteLine(h);

            Console.WriteLine(DateTime.IsLeapYear(2018));


            int l = 10;
            decimal k = 0.1M;
            decimal n = k + k + k + k + k + k + k + k + k + k;
            Console.WriteLine(n);

            int o = 10;
            o += 1;

            o = 1;
            o++;
            if (o == 1) {
                Console.WriteLine("o = 1");
            }
            Console.WriteLine(o);

            //checked
            //{
            //    int p = int.MaxValue;
            //    Console.WriteLine(p);
            //    p++;
            //    Console.WriteLine(p);
            //}


            double q = 0.34534545398479348;
            Console.WriteLine(q);
            string w = q.ToString("P2");
            Console.WriteLine(w);


            bool s = true;
            Console.WriteLine(s);

            DateTime x = new DateTime(2020, 9, 10);
            DateTime y = DateTime.Now;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            Console.WriteLine(x);
            x = x.AddMinutes(200);
            Console.WriteLine(x);

            Console.WriteLine(x.ToString("MMMM yy"));


            DateTime z1 = DateTime.Now;
            DateTime z2 = new DateTime(2020, 9, 1);
            TimeSpan z3 = z1 - z2;

            TimeSpan z4 = new TimeSpan(15, 0, 0);
            TimeSpan z5 = new TimeSpan(17, 25, 0);
            TimeSpan z6 = z5 - z4;
            Console.WriteLine(z6.TotalMinutes);


        }
    }
}
