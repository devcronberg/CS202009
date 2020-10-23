using System;

namespace Hændelser2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Timers.Timer t = new System.Timers.Timer();
            t.Enabled = true;
            t.Interval = 1500;
            t.Elapsed += (s, e) => Console.Beep();
            t.Elapsed += (s, e) => Console.WriteLine("*");

            Console.ReadKey();


        }


    }


}
