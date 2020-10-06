using System;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            TestTerning1();
            TestTerning2();
            TestTerning3();


        }

        private static void TestTerning3()
        {
            Console.WriteLine("Test af Terning3");
            Terning3 t = new Terning3();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            // t.Værdi = 5;     // FEJL
        }

        private static void TestTerning2()
        {
            Console.WriteLine("Test af Terning2");
            Terning2 t = new Terning2();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 5;
            t.Skriv();

            // t.Værdi = 7; // FEJL
        }

        private static void TestTerning1()
        {
            Console.WriteLine("Test af Terning1");
            Terning1 t;
            t = new Terning1();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            t.Værdi = -1;   // FEJL - det må man ikke
        }
    }




}
