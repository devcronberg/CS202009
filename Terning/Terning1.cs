using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{

    /// <summary>
    /// Terning med OFFENTLIGT felt (duer ikke)
    /// </summary>
    public class Terning1
    {

        // felter
        public int Værdi;

        // Konstruktør (constructor)
        public Terning1()
        {
            this.Ryst();
        }

        // metoder
        public void Ryst() {
            var tt = new Random();
            this.Værdi = tt.Next(1, 7);
        }

        public void Skriv() {
            Console.WriteLine($"[ {this.Værdi} ]");
        }


    }
}
