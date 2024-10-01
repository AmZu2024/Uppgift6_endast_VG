using System;
using System.Collections.Generic;
namespace NameSorter
{
    public class Metoder
    {
        List<string> names = new List<string> { "Anna", "John", "Alice", "Bo" };
        // Metod för att omformatera så att alla namn man lägger till eller söker efter har stor första bokstav resterande lower
        public string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input; // Om strängen är tom eller null, returnera den som den är.

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

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
            Console.WriteLine("Skriv vilket namn du vill lägga till:");
            string addname = Console.ReadLine();
            //Kallar på CapitalizeFirstLetter för att omformatera till uppercase på första resterande lowercase
            string reformated = CapitalizeFirstLetter(addname);
            
            names.Add(reformated);
        }
        //Metod för name sort 
        public void sortera()
        {
            Console.WriteLine("Sorterad lista");
            names.Sort();
            lista();
        }

        //Metod för name search
        public void search()
        {
            Console.WriteLine("Vill du söka efter ett namn");
            string search = Console.ReadLine();
            string reformated = CapitalizeFirstLetter(search);
            if (names.Contains(reformated))
            {
                Console.WriteLine($"{reformated} finns i listan");
            }
            else
            {
                Console.WriteLine($"{reformated} finns ej listan");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Metoder metoder = new Metoder();
            metoder.lista();
            metoder.lägga_till();
            metoder.sortera();
            metoder.search();
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