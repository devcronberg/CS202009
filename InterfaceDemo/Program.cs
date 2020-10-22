using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund();
            UBåd u = new UBåd();
            
            IDatabaseFunktioner i;
            i = new UBåd();

            List<IDatabaseFunktioner> lst = new List<IDatabaseFunktioner>();
            lst.Add(new UBåd());
            lst.Add(new Hund());
            lst.Add(new Kat());
            foreach (var item in lst)
            {
                item.Skriv();
            }


            GemAlt(h);
            IDatabaseFunktioner o = FindTilfældigtObject();
            

        }

        static void GemAlt(IDatabaseFunktioner obj) {
            obj.Gem();
        }

        static IDatabaseFunktioner FindTilfældigtObject()
        {

            if (DateTime.Now.Second % 2 == 0) {
                return new Hund();
            } else {
                return new UBåd();
            }

        }

    }

    class Kat : IDatabaseFunktioner {
        public void Gem() { }
        public bool Hent(int id)
        {
            return false;
        }

        public void Skriv() { }

        
    }
    class Hund : IDatabaseFunktioner {
        public void Gem() { }
        public bool Hent(int id) {
            return false;
        }

        public void Skriv() { }

        public void SigNoget() { }
    }



    class UBåd : IDatabaseFunktioner
    {

        public void Dyk() { }

        public void Gem()
        {
            
        }

        public bool Hent(int id)
        {
            return false;
        }

        public void Skriv()
        {
            
        }
    }

    public interface IDatabaseFunktioner {

        void Gem();
        bool Hent(int id);
        void Skriv();

    }
}
