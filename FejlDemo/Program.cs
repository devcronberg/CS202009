using System;
using System.IO;

namespace FejlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // test øæghlk eøeæklh døh tfi
            try
            {
                int tal = HentTalFraFil(@"c:\temp\tal.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if(ex.InnerException!=null)
                    Console.WriteLine("\t" + ex.InnerException.Message);
                
            }


            try
            {
                int r = LægSammen(10, 10);
                Console.WriteLine(r);
                r = LægSammen(-10, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }


        }



        static int LægSammen(int a, int b) {
            if (a < 0 || b < 0) {
                Exception e = new Exception("Må ikke være negativ");
                throw e;
            }
            return a + b;
        }

        // denne metode kan placeres i Program-klassen
        private static int HentTalFraFil(string sti)
        {
            try
            {
                string talSomStreng = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(talSomStreng);
                return tal;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Kan ikke konvertere tal fra {sti}", ex);
            }
        }

        public static void Metode1()
        {
            Metode2();
        }
        public static void Metode2()
        {
            Metode3();
        }
        public static void Metode3()
        {
            Metode4();
        }
        public static void Metode4()
        {
            string tekst = null;
            Console.WriteLine(tekst.ToUpper());
        }
    }
}
