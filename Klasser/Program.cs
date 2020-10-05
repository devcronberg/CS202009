using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {


            // Hund h = new Hund("Fido", 3);
            Hund h = new Hund("fido", 4);
            Console.WriteLine(h.Navn);
            Console.WriteLine(h.AntalBen);

            return;
            Terning t1 = new Terning();
            Terning t2 = new Terning();
            t1 = t2;



            //Bæger b = new Bæger();
            //b.Skriv();

            //return;

            LudoTerning t;
            
            t = new LudoTerning();
            t.Ryst();
            t.Skriv();
            return;
            t.ErSekser += Sekser;
            //t.Værdi = -2;
            //t.Skriv();


            
            for (int i = 0; i < 10; i++)
            {
                t.Ryst();
                t.Skriv(); 
            }

            

            //t.Værdi = -1;
            //t.Skriv();

            //Terning q = new Terning();
            //q.Værdi = 2;
            //q.Skriv();


        }

        static void Sekser() {
            Console.Beep(500, 500);
            Console.WriteLine("HURRA");
        }
    }

    internal class Person { 
    
    
    }

    public class Terning {

        // constructor
        public Terning()
        {
            this.værdi = 1;
        }

        // data (felter)
        private int værdi;
        public string Farve;

        // Egenskaber
        public int Værdi {
            get {
                return this.værdi;
                }
            set {
                if (value < 1 || value > 6)
                    throw new Exception("Forkert værdi");

                this.værdi = value;
            }
        }

        // Metoder
        //public void SætVærdi(int v) {
        //    if (v < 1 || v > 6)
        //        throw new Exception("Forkert værdi");
        //    this.Værdi = v;
        //}

        public virtual void Skriv() {
            Console.WriteLine("[ " + this.Værdi + " ]");
        }

        public void Ryst()
        {
            Random r = new Random();
            int v = r.Next(1, 7);
            this.Værdi = v;
            if (this.Værdi == 6)
                ErSekser?.Invoke();
        }

        // Hændelser
        public Action ErSekser;




    }

    class LudoTerning : Terning
    {
        public override void Skriv()
        {
            if (this.Værdi == 3)
                Console.WriteLine("[ G ]");
            else if (this.Værdi == 5)
                Console.WriteLine("[ S ]");
            else
                base.Skriv();
        }
    }

    class Bæger {
        public Terning[] Terninger;
        public Bæger()
        {
            Terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                Terninger[i] = new Terning();
            }
            Ryst();
        }

        public void Skriv() {
            foreach (var terning in Terninger)
            {
                terning.Skriv();
            }
        }

        public void Ryst()
        {
            foreach (var terning in Terninger)
            {
                terning.Ryst();
            }
        }
    }


    class Halsbånd {
        public int Id;
        public string Mærke;
    }

    class Hund {
        public string Navn;
        public int AntalBen;


        // Default constrctor
        //public Hund() : this("", 4) {
        //    //// log
        //    //// sikkerhed
        //    //// initialiser
        //    //Navn = "";
        //    //AntalBen = 4;
        //    //Console.WriteLine("Jeg fødes");
        //}

        // Custom
        public Hund(string navn, int antalBen)
        {
            // log
            // sikkerhed
            // initialiser
            Navn = navn;
            AntalBen = antalBen;
            Console.WriteLine("Jeg fødes");
        }

    }
}
