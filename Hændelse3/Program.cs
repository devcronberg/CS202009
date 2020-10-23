using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hændelse3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1 = new Terning();
            //Terning t2 = new Terning();
            //if (t1 == t2) { }

            //Terning t = new Terning();
            //t.ErSekser += a => Console.WriteLine("* antal:" + a);
            //t.Rystet += (v, t) => Console.WriteLine(v);
            //for (int i = 0; i < 15; i++)
            //    t.Ryst();

            Person p1 = new Person("a", "b");
            Person p2 = new Person("a", "b");
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1.ToString());
        }
    }

    class Terning : IEquatable<Terning>
    {
        public int Værdi { get; private set; }
        public event Action<int> ErSekser;
        public event Action<int, DateTime> Rystet;
        private int antal = 0;
        public int AntalSeksere
        {
            get
            {
                return antal;
            }
        }
        public Terning()
        {
            Ryst();
        }
        public void Ryst()
        {
            this.Værdi = new Random().Next(1, 7);
            if (this.Værdi == 6)
                ErSekser?.Invoke(++antal);
            Rystet?.Invoke(this.Værdi, DateTime.Now);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Terning);
        }

        public bool Equals(Terning other)
        {
            return other != null &&
                   Værdi == other.Værdi;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Værdi);
        }

        public static bool operator ==(Terning left, Terning right)
        {
            return EqualityComparer<Terning>.Default.Equals(left, right);
        }

        public static bool operator !=(Terning left, Terning right)
        {
            return !(left == right);
        }
    }

    public class Person : IEquatable<Person>
    {
        public string Fornavn { get; private set; }
        public string Efternavn { get; private set; }

        public Person(string fornavn, string efternavn)
        {
            this.Efternavn = efternavn;
            this.Fornavn = fornavn;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   Fornavn == other.Fornavn &&
                   Efternavn == other.Efternavn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Fornavn, Efternavn);
        }

        public override string ToString()
        {
            return "Fornavn: " + Fornavn + " Efternavn: " + Efternavn;
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
