using System;
using System.Linq;

namespace Delegate3
{

    // public delegate void DelegateVoid();
    // public delegate void DelegateStringVoid(string txt);
    // public delegate int DelegateIntIntInt(int a, int b);

    // Action = returnerer void
    // Func = returnerer en værdi

    // Predicate = returnerer en bool med et argument

    class Program
    {
        static void Main(string[] args)
        {
            Action d1 = new Action(Console.Beep);
            d1.Invoke();

            Action<string> d2 = Console.WriteLine;
            d2.Invoke("*");

            Func<int, int, int> d3 = System.Math.Max;
            Console.WriteLine(d3(10, 5));

            //Func<string, bool> d4 = Test;
            //Console.WriteLine(d4("test"));

            //Predicate<string> d5 = Test;
            //Console.WriteLine(d5("test"));
            int[] ar = { 5, 1, 74, 1, 45, 4, 33, 3 };
            var re = System.Array.FindAll(ar, Test);



        }

        static bool Test(int r)
        {
            return r % 2 == 0;

        }

        //public static Func<int, int, int> Findtf() {
            
        //}
    }
}
