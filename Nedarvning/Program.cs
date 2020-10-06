using System;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            Barn b = new Barn(5);
            b.Test();
        }
    }

    class Mor {
        private int tal1;
        public int tal2;
        protected int tal3;

        public void SetTal1() { }
        public void Test() {
            Console.WriteLine("I mors Test");
        }

        public Mor()
        {
            Console.WriteLine("Nu fødes mor");
        }

        public Mor(int tal)
        {
            this.tal1 = tal;
            Console.WriteLine("Nu fødes mor +");
        }
    }

    class Barn : Mor {

        public Barn()
        {
            Console.WriteLine("Nu fødes barn");
            
        }

        public Barn(int tal) : base(tal)
        {   
            
            Console.WriteLine("Nu fødes barn + ");
        }

    }

    class Terning {

        protected Random rnd;
    
    }

    class LudoTerning : Terning {
        public LudoTerning()
        {
            
        }
    }
}
