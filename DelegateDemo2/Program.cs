using System;

namespace DelegateDemo2
{

    public class Hund { }

    public delegate void DelegateVoid();
    public delegate void DelegateStringVoid(string txt);
    public delegate int DelegateIntIntInt(int a, int b);
    
    public delegate void DelegateHundVoid(Hund a);


    public class Program
    {
        static void Main(string[] args)
        {
            //DelegateStringVoid a = new DelegateStringVoid(M1);
            DelegateStringVoid a = M1;

            //a.AddMethod(GemIFil);
            a += GemIFil;
            //a.Invoke("*");
            if (a != null)
                a("*");





            return;

            // Direkte
            M1("*");
            // Inddirekte
            a.Invoke("*");

            DelegateVoid b = new DelegateVoid(Console.Beep);

            Console.Beep();
            b.Invoke();

            DelegateIntIntInt c = new DelegateIntIntInt(Plus);
            Console.WriteLine(Plus(10, 10));
            Console.WriteLine(c.Invoke(10, 10));
        }

        static void GemIFil(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\f.txt", txt);
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static void M1(string x)
        {
            Console.WriteLine("I M1 med " + x);
        }

        static void Gem(string a, DelegateStringVoid f)
        {
            // gemmer
            f.Invoke("Færdig med at gemme a " + a);
        }
    }
}
