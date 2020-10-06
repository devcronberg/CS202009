using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace Poly2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fugl f = new Fugl();
            //Kæledyr k = f;
            //Object o = f;

            //Console.WriteLine(o is Fugl);
            //Console.WriteLine(o is Hund);

            //Hund z = o as Hund;
            //Console.WriteLine(z.HundeRegisterId);

            List<Kæledyr> dyr = new List<Kæledyr>();
            dyr.Add(new Hund { Navn = "a" });
            dyr.Add(new Hund { Navn = "b", HundeRegisterId = "zz" });
            dyr.Add(new Fugl { Navn = "c", HåndTam = true });
            dyr.Add(new Fugl { Navn = "d" });
            dyr.Add(new Skildpade { Navn = "e" });

            foreach (var item in dyr)
                Console.WriteLine(item);


        }
    }

    internal abstract class Kæledyr
    {
        public string Navn { get; set; }
        public abstract string Kendelyd();

        public void Test()
        {
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
        public override string ToString()
        {
            return "Jeg er en fugl og hedder " + Navn + " og " + (this.HåndTam ? "er" : "er ikke") + " håndtam";
        }

    }

    internal class Skildpade : Kæledyr
    {
        public override string Kendelyd()
        {
            return "...!!!";
        }
        public override string ToString()
        {
            return "Jeg er en Skildpade og hedder " + Navn;
        }

    }

    internal class Hund : Kæledyr
    {
        public string HundeRegisterId { get; set; }
        public override string Kendelyd()
        {
            return "Vov";
        }


        public override string ToString()
        {
            return "Jeg er en hund og hedder " + Navn + " og har id " + this.HundeRegisterId;
        }
    }
}
