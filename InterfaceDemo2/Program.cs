using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hund> lst = new List<Hund>();
            lst.Add(new Hund { Navn = "b", AntalBen = 4 });
            lst.Add(new Hund { Navn = "a", AntalBen = 3 });
            lst.Sort();
            
            foreach (var item in lst)
            {
                Console.WriteLine(item.Navn  + " " + item.AntalBen);
            }
        }
    }

    class Hund : IComparable<Hund>
    {

        public int AntalBen { get; set; }
        public string Navn { get; set; }

        public int CompareTo([AllowNull] Hund other)
        {
            //if (this.AntalBen > other.AntalBen)
            //    return -1;
            //if (this.AntalBen < other.AntalBen)
            //    return 1;
            //return 0;
            return this.Navn.CompareTo(other.Navn);

        }
    }
}
