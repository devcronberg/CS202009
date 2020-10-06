using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{
    /// <summary>
    /// Terning med egenskab
    /// </summary>
    public class Terning2
    {

        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set
            {

                // log
                // sikkerhed
                if (value < 1 || value > 6)
                    throw new Exception("Forkert værdi");
                værdi = value;

            }
        }

        public Terning2()
        {
            this.Ryst();
        }

        // metoder
        public void Ryst()
        {
            var tt = new Random();
            this.Værdi = tt.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[ {this.Værdi} ]");
        }

    }
}
