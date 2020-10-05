using System;

namespace ArgsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            string sti = args[0];
            Console.WriteLine("**** " + sti);
        }
    }
}
