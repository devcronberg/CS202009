using System;
using System.Linq;
using System.Net.Http.Headers;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mappe = new System.IO.DirectoryInfo(@"c:\git");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Har fundet {filer.Length} i {mappe.Name}");

            // Query syntax
            // Method syntax --

            //// var res1 = from fil in filer where fil.Length > 100_000 orderby fil.Name select fil;
            //var a = filer.Where(i => i.Length > 100_000);
            //var res2 = a.OrderBy(i => i.Name).ToList();

            //var r = filer.Where(i => i.Length > 100000)
            //    .Select(i => new { i.Length, i.Name })
            //    .ToList();

            //foreach (var item in r)
            //{
            //    Console.WriteLine(item.Name);
            //}

            int[] tal = { 4, 1, 74, 1, 158, 1, 3, 54, 24, 4 };
            var r = tal.Average();      


            //var r2 = tal.OrderBy(i => i);



            //var grupper = filer.GroupBy(i => i.Extension);
            //foreach (var gruppe in grupper.OrderBy(i=>i.Key))
            //{
            //    Console.WriteLine(gruppe.Key);
            //    foreach (var item in gruppe.OrderBy(i=>i.Name))
            //    {
            //        Console.WriteLine("\t" + item.Name);
            //    }
            //}

            var res = filer.Where(i => i.Length > 100000).Skip(5).Take(10).ToList();



            }
    }

    //class MinFil {
    //    public string Navn { get; set; }
    //    public long Længde { get; set; }
    //}
}
