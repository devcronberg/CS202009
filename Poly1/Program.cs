using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Poly1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kæledyr k = new Kæledyr();
            //k.Navn = "a";
            //Console.WriteLine(k.Kendelyd());


            //Fugl f = new Fugl();
            //f.Navn = "b";
            //f.HåndTam = false;
            //Console.WriteLine(f.Kendelyd());

            //Hund h = new Hund();
            //h.Navn = "c";
            //h.HundeRegisterId = "1";
            //Console.WriteLine(h.Kendelyd());

            //Console.WriteLine(k);
            //Console.WriteLine(f);
            //Console.WriteLine(h);

            A a = new A { Navn = "aa", Id = 5654, ErGod = true };
            Console.WriteLine(a);
            //a.Gem(@"c:\temp\data.txt");

            //A a = A.Hent(@"c:\temp\data.txt");

            //List<A> lst = new List<A> { new A { Navn = "a" }, new A { Navn = "b" } };
            //System.IO.File.WriteAllText(@"c:\temp\data.txt", Newtonsoft.Json.JsonConvert.SerializeObject(lst, Newtonsoft.Json.Formatting.Indented));

            List<A> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<A>>(System.IO.File.ReadAllText(@"c:\temp\data.txt"));


        }
    }

    internal class Kæledyr
    {
        public string Navn { get; set; }
        public virtual string Kendelyd()
        {
            return "?";
        }

        public override string ToString()
        {
            return "Jeg er et dyr og hedder " + Navn;
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
            return "Jeg er en fugl og hedder " + Navn + " og " + (this.HåndTam?"er":"er ikke") + " håndtam";
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

    class A {

        public int Id { get; set; }
        public string Navn { get; set; }
        public bool ErGod { get; set; }

        public void Gem(string fil) {
            System.IO.File.WriteAllText(fil, Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented));
        }

        public static A Hent(string fil) {
            string data = System.IO.File.ReadAllText(fil);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<A>(data);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
