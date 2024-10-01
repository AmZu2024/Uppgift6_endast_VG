using System;
using System.Collections.Generic;
namespace NameSorter
{
    public class Metoder
    {
        List<string> names = new List<string> { "Anna", "John", "Alice", "Bo" };
       
        //Metod for writing out names:
        public void lista()
        {
            foreach (string name in names)
            {
                 Console.WriteLine(name);
            }
        }
        //Metod för att lägga till namn i listan 
        public void lägga_till()
        {
            string addname = Console.ReadLine();
            names.Add(addname);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Metoder metoder = new Metoder();
            metoder.lägga_till();
            metoder.lista();
            /*
            List<string> names = new List<string> { "Anna", "John", "Alice", "Bo" };
            Console.WriteLine("Original List");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Sort();
            Console.WriteLine("\nSorted list");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }

            */
        }
    }
}