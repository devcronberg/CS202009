using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace demo
{
    class Program
    {

        static void Main(string[] args)
        {

            PeopleContext c = new PeopleContext();
            var res = c.People.Sum(i => i.Height);
            Console.WriteLine(res);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.PersonId + " " + item.LastName);
            //}

            //var p = c.People.Where(i => i.PersonId == 2).FirstOrDefault();
            //p.LastName = "!!!!";
            //c.SaveChanges();

            //Person p = new Person();
            //p.FirstName = "a";
            //p.LastName = "b";
            //c.People.Add(p);
            //c.SaveChanges();
            //Console.WriteLine(p.PersonId);

            //var p = c.People.Where(i => i.PersonId == 201).FirstOrDefault();
            //c.People.Remove(p);
            //c.SaveChanges();

            //var r = c.People.GroupBy(i => i.IsHealthy);
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item.Key);
            //}
        }
    }

    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"I'm {FirstName} {LastName} with id {PersonId} born {DateOfBirth.ToShortDateString()}. I'm {(IsHealthy ? "healthy" : "not healthy")}, a {(Gender == 1 ? "woman" : "man")} and {Height} cm.";
        }

    }

    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
            // Enable logging to console
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());

        }

        // For logging...
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
    }
}