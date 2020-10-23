using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MinTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start program");
            string indhold = "123";
            string sti = @"c:\temp\data.txt";
            await GemFilAsync(sti, indhold);
            Console.WriteLine("Slut program");
            
        }

        static async Task GemFilAsync(string sti, string indhold)
        {
            await Task.Run(async () => {
                Console.WriteLine("Gemmer " + sti);
                Thread.Sleep(100);
                await File.AppendAllTextAsync(sti, indhold);
                Console.WriteLine("Gemt " + sti);
            });
        }
    }
}