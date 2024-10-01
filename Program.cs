﻿using System;
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
            Console.WriteLine("Skriv vilket namn du vill lägga till:");
            string addname = Console.ReadLine();
            names.Add(addname);
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
            if (names.Contains(search))
            {
                Console.WriteLine($"{search} finns i listan");
            }
            else
            {
                Console.WriteLine($"{search} finns ej listan");
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