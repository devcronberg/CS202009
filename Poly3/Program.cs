using System;
using System.Collections.Generic;

namespace Poly3
{
    class Program
    {
        static void Main(string[] args)
        {



            //Hund h = new Hund();
            //h.Navn = "Fido";
            //Fugl f = new Fugl() { Navn = "PipHans" };

            //h.SigNoget();
            //f.SigNoget();

            Dyr d;
            d = new Fugl();

            Hund f = d as Hund;

            List<Dyr> lst = new List<Dyr>();
            lst.Add(new Fugl() { Navn = "a" });
            lst.Add(new Hund() { Navn = "b" });

            foreach (var item in lst)
                item.SigNoget();






        }
    }

    abstract class Dyr
    {
        public string Navn { get; set; }
 

        public abstract void SigNoget();
    }

    class Hund : Dyr
    {

        public override void SigNoget()
        {
            Console.WriteLine("Vov");
        }

    }
    class Fugl : Dyr
    {
        public bool HåndTam { get; set; }
        public override void SigNoget()
        {
            Console.WriteLine("Pip");
        }
    }
}
