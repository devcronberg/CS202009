using System;

namespace Hændelser
{
    class Program
    {
        static void Main(string[] args)
        {


            //System.Timers.Timer t = new System.Timers.Timer();
            //t.Enabled = true;
            //t.Interval = 500;
            //t.Elapsed += (s, e) => Console.WriteLine("Tick " + e.SignalTime);

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp");
            w.EnableRaisingEvents = true;
            w.Created += (s, e) => {
                
                Console.WriteLine("Oprettet " + e.FullPath);
                var filer = System.IO.Directory.GetFiles(@"c:\temp");
                
            };
            w.Deleted += (s, e) => Console.WriteLine("Slettet " + e.FullPath);
            w.Changed += (s, e) => Console.WriteLine(e.FullPath);
            w.Renamed += (s, e) => Console.WriteLine(e.FullPath);

            do
            {

            } while (true);

        }

   
    }
}
