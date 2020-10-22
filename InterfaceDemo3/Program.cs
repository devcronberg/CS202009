using System;
using System.Net;
using System.Security.Cryptography;

namespace InterfaceDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(new TilfældighedsGeneratorRandomOrg());
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Ryst();
            t.Skriv();

        }
    }

    class TilfældighedsGeneratorRandomOrg : ITilfældighedsGenerator
    {
        public int Next(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }

            
        }
    }







    class Terning {
        
        public int Værdi { get; private set; }
        private ITilfældighedsGenerator rnd;

        public Terning()
        {
            rnd = new TilfældighedsGeneratorRandom();
            Ryst();

        }
        public Terning(ITilfældighedsGenerator g)
        {
            rnd = g;
            Ryst();
        }
        public void Ryst() {
            Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" +  this.Værdi + "]");
        }

    }

    public interface ITilfældighedsGenerator {
        int Next(int min, int max);
    }

    public class TilfældighedsGeneratorRandom : ITilfældighedsGenerator
    {
        private Random rnd;
        public TilfældighedsGeneratorRandom()
        {
            rnd = new Random();
        }

        public int Next(int min, int max) {
            return rnd.Next(min, max);
        }
    }

    public class TilfældighedsGeneratorTest : ITilfældighedsGenerator
    {
        public int Next(int min, int max)
        {
            return 6;
        }
    }
}
