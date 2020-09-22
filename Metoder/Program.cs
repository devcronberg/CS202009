using System;
using System.Data;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test1();
            //Test2(5);
            //string res1 = Test3();
            //Console.WriteLine(res1);
            //string res2 = Test3(5);
            //Console.WriteLine(res2);

            //int res3 = LægSammen(5, 5);
            //Console.WriteLine(res3);
            //F1();

            //Hund h = new Hund();
            //h.SigNoget();

            //Console.WriteLine();

            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a);
            //int res4 = LægSammen(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(res4);
            Metode1("", 1, true, "DK");
            Metode1(navn: "Mikkel", erSmart: true, land: "DK", alder: 17);

            Skriv(@"C:\git");
        }

        static void Skriv(string sti) {

            string[] filer = System.IO.Directory.GetFiles(sti);
            for (int i = 0; i < filer.Length; i++)
                Console.WriteLine(filer[i]);
            string[] mapper = System.IO.Directory.GetDirectories(sti);
            for (int i = 0; i < mapper.Length; i++)
                Skriv(mapper[i]);
        
        }

        static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }
        private static double Gange(double a, double b) => a * b;

        private static int LægSammen(int tal1, int tal2)
        {
            tal1 = 100;
            return tal1 + tal2;
        }

        private static int LægSammen(int tal1, int tal2, int tal3)
        {            
            return tal1 + tal2 + tal3;
        }

        static void Test0(int a , bool b = true, double c = 0)
        {
            Console.WriteLine("I Metode " + a + " "  + b);
        }

        static void Test1()
        {
            if (DateTime.Now.Second % 2 == 0)
                return;
            Console.WriteLine("I Test1");
        }

        static void Test2(int antal)
        {
            for (int i = 0; i < antal; i++)
                Console.WriteLine("I Test2");
        }

        static string Test3()
        {
            return "*";
        }

        static string Test3(int antal)
        {
            if (antal < 3)
                return new string('*', antal);
            else
                return "?";
        }


        static void F1()
        {
            Console.WriteLine("I F1()");
            F2();
        }
        static void F2()
        {
            Console.WriteLine("I F2()");
            F3();
        }
        static void F3()
        {
            Console.WriteLine("I F3()");
            F4();
        }
        static void F4()
        {
            Console.WriteLine("I F4()");
            F5();
        }
        static void F5()
        {
            Console.WriteLine("I F5()");

        }

    }

    class Hund {
        public void SigNoget() {
            Console.WriteLine("Vov");
        }
    }
}
