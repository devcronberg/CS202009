using System;

namespace TypeKonv
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte a = 255;
            //int b = 10;


            //a = Convert.to
            //Console.WriteLine(a);

            double a = 4030.75;
            int b = (int)a;

            //string r = "23342,135";
            //double y = Convert.ToDouble(r);

            Console.WriteLine("Indtast dato");
            string i = Console.ReadLine();
            DateTime d = Convert.ToDateTime(i);
            TimeSpan t = d - DateTime.Now.Date;

            Console.WriteLine("Der er " + t.Days  + " dage");
            



        }
    }
}
