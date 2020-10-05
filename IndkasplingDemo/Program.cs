using System;

namespace IndkasplingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Mikkel", 17);

            //p.SetAlder(15);
            //Console.WriteLine(p.GetAlder());'
            p.Alder = 15;
            Console.WriteLine(p.Alder);

            // Reflection
            var m = p.GetType().GetMethods();

        }
    }

    class Person {

        // Offentlige felter
        private string navn;
        private int alder;

        //public void SetAlder(int value) {
        //    // log
        //    // sikkerhed
        //    if (value < 0 || value > 110)
        //        throw new Exception("Fejl");
        //    this.alder = value;
        //}

        //public int GetAlder() {
        //    // log
        //    // sikkerhed
        //    return this.alder;
        //}

        public int Alder {
            get {
                // log
                // sikkerhed
                return this.alder;
            }
            set {
                // log
                // sikkerhed
                if (value < 0 || value > 110)
                    throw new Exception("Fejl");
                this.alder = value;
            }
        }

        public string NavnMedStort() {
            return this.navn.ToUpper();
        }

        public Person()
        {
            this.navn = "";
            this.alder = 0;
        }

        public Person(string navn, int alder)
        {
            // log
            // sikkerhed
            if (navn == null || alder < 0 || alder > 110)
                throw new Exception("Fejl");
            this.navn = navn;
            this.alder = alder;
        }

    }

    class Hund {

        private int alder;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

    }
}