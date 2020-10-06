using System;

namespace AbstraktDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            Console.WriteLine(h.Kendelyd());
            h.Test();
        }
    }

    internal abstract class Kæledyr
    {
        public string Navn { get; set; }
        public abstract string Kendelyd();

        public void Test() {
            Console.WriteLine("Test");
        }
    }

    internal class Fugl : Kæledyr
    {
        public bool HåndTam { get; set; }

        public override string Kendelyd()
        {
            return "Pip";
        }
    }

    internal class Hund : Kæledyr
    {
        public string HundeRegisterId { get; set; }
        public override string Kendelyd()
        {
            return "Vov";
        }
    }
}
