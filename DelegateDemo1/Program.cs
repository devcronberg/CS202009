using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace DelegateDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tal = new int[] { 5, 1, 4, 5, 3 };

            //int[] r = System.Array.FindAll(tal, F);

            //Gem(6, MinF);

            Maskine m = new Maskine();
            m.LogMetode = Console.WriteLine;
            m.LogMetode += MinLogTilConsole;
            m.Start();
            m.Stop();

        }

        public static void MinLogTilConsole(string txt) {
            Console.WriteLine(txt);
            Console.Beep();
        }

        public static void MinLogTilFil(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log1.txt", txt + "\r\n");
        }


        class Maskine {

            public Action<string> LogMetode;

            public void Start() {
                Log("Nu starter jeg");
            }
            public void Stop() {
                Log("Nu stopper jeg");
            }

            private void Log(string txt) {
                if (LogMetode != null)
                    LogMetode.Invoke(DateTime.Now.ToLongTimeString() + " " + txt);
            }

        }

        static void MinF() {
            Console.WriteLine("FEJL");
        }
        static bool F(int t) {
            return t % 2==0;
        }

        static void Gem(int a, Action fejlFukt)
        {
            try
            {
                Console.WriteLine("Gemmer");
                throw new Exception();
            // gemmer a

            }
            catch (Exception)
            {
                fejlFukt.Invoke();            
            }

        }
    }
}
