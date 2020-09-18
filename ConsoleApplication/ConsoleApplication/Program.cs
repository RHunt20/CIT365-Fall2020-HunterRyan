using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter your name, then press ENTER");

            var name = Console.ReadLine();

            Console.WriteLine("Please enter in your location, then press ENTER");

            var location = Console.ReadLine();

            Console.WriteLine($"My name is {name}, I am from {location}.");
              
            
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyy"));

            
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(today.Year, 12, 25, 0, 0, 0);

            if (today > christmas)
            {
                christmas = christmas.AddYears(1);
            }

            Console.WriteLine($"There are {(christmas - today).Days} days till Christmas!");
            Console.ReadLine();

        }
    }
}