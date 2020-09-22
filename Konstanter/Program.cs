using System;

namespace Konstanter
{
    class Program
    {
        static void Main(string[] args)
        {
            string person1Navn = "Mathias";
            int person1Alder = 12;
            Køn person1Køn = Køn.Mand;

            string person2Navn = "Lene";
            int person2Alder = 53;
            Køn person2Køn = Køn.Kvinde;

            Console.WriteLine(person2Køn);

            DayOfWeek ugeDag = DayOfWeek.Sunday;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("3315");

            switch (person1Køn)
            {
                case Køn.Kvinde:
                    break;
                case Køn.Mand:
                    break;
                default:
                    break;
            }

            switch (ugeDag)
            {
                case DayOfWeek.Sunday:


                    break;
                case DayOfWeek.Monday:


                    break;
                case DayOfWeek.Tuesday:


                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
        }
    }




}
