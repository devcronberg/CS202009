using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{
    public class Terning3a
    {
        public int Værdi { get; private set; }
        private Random tt;

        public Terning3a()
        {
            tt = new Random();
            this.Ryst();
        }

        // metoder
        public void Ryst()
        {            
            this.Værdi = this.tt.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[ {this.Værdi} ]");
        }
    }
}
