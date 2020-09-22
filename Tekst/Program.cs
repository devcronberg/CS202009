using System;

namespace Tekst
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char a = 'A';
                Console.WriteLine(Convert.ToInt32(a));

                int b = 42;
                char c = Convert.ToChar(b);
                Console.WriteLine(c);

                string d = "aa";
                Console.WriteLine(d);

                string e = "bb";
                string f = d + " " + e;
                Console.WriteLine(f);
                f = f.ToUpper();
                Console.WriteLine(f);

                string sti = "sdlkfjgsdlækfjg\r\ndæjdlæfkjsdf\r\nssdklfj";
                Console.WriteLine(sti);

                string navn = "Mathias";
                string res1 = "Hej - mit navn er " + navn;
                string res2 = $"Hej - mit navn er {navn.ToUpper()} ";

                Console.WriteLine(res1);
                Console.WriteLine(res2);

                navn = "Børge";

                double løn = 654654;
                string res3 = $"{navn} tjener {løn.ToString("n2"),-20}";
                Console.WriteLine(res3);

                string t = "mathias";
                Console.WriteLine(t);
                //t = null;
                //if (t != null)
                //{
                //    t = t.ToUpper();
                //}

                t = t?.ToUpper();

                Console.WriteLine(t);

                Console.WriteLine();
                Console.WriteLine();
            }
            {
                // Stopur
                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                s.Start();
                for (int i = 0; i < 50_000_000; i++)
                {
                    sb.Append("*");
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }

        }
    }
}
