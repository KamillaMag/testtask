using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using TramisTest.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // get configuration from json
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            //pass connection string to context options
            var optionsBuilder = new DbContextOptionsBuilder<TramisTestDBContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (TramisTestDBContext db = new TramisTestDBContext(options))
            {
                Receiver receiver = new Receiver { Name = "ГК Синергия", City = "Москва", Country = "Россия" };
                Product product = new Product { Name = "Электротехнические товары", GrossWeight = 13079.17, Volume = 0, Price = 0 };
                db.Receivers.Add(receiver);
                db.Products.Add(product);
                db.SaveChanges();
                Console.WriteLine("Objects successfully saved");
                var receivers = db.Receivers.ToList();
                Console.WriteLine("Receivers:");
                foreach (Receiver rec in receivers)
                {
                    Console.WriteLine($"{rec.Id} | {rec.Name} | {rec.City} | {rec.Country}");
                }
            }                  
            Console.Read();
        }
    }
}