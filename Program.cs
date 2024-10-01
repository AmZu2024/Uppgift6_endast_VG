using System;
using System.Collections.Generic;
using System.Globalization;
namespace NameSorter
{
    //Klass som innehåller metoder för att hantera en lista av namn
    public class Metoder
    {
        //Lista som lagrar namn 
        List<string> names = new List<string> { "Anna", "John", "Alice", "Bo" };
        // Metod för att omformatera så att första bokstaven blir stor och resterande små
        public string CapitalizeFirstLetter(string input)
        {
            //Kontrollera om strängen är tom eller null
            if (string.IsNullOrEmpty(input))
                return input; // Returnera oförändrad

            //Omformatera strängen och returnera den
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        //Metod för att skriva ut namnen i listan 
        public void lista()
        {
            //Iterera genom namnen och skriva ut varje namn
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        //Metod för att lägga till namn i listan 
        public void lägga_till()
        {
            //Fråga användaren om de vill lägga till namn 
            Console.WriteLine("Vill du lägga till namn i listan? skriv ja/nej");
            string input = Console.ReadLine().ToUpper();

            //Loop för att säkerställa att inmatningen är ja eller nej
            while (input !="JA" && input !="NEJ")
            {
                Console.WriteLine("Fel inmatning. Du kan endast svara ja/nej. Försök igen\n");
                Console.WriteLine("Vill du lägga till namn i listan? skriv ja/nej");
                input = Console.ReadLine().ToUpper();
            }

            //Loop för att lägga till namn så länge användaren svarar ja 
            while (input == "JA")
            {
                Console.WriteLine("Skriv vilket namn du vill lägga till:");
                string addname = Console.ReadLine();

                //Kontrollerar att namnet endast innehåller bokstäver
                while (!addname.All(char.IsLetter))
                {
                    Console.WriteLine("Ogiltlig inmatning. Ange namn som enbart inehåller bokstäver inga siffror");
                    addname = Console.ReadLine();
   
                }
                //Kallar på CapitalizeFirstLetter för att omformatera namnet 
                string reformated = CapitalizeFirstLetter(addname);
                names.Add(reformated);//Lägger till det omformaterade namnet i listan

                //Frågar om användaren vill lägga till fler namn
                Console.WriteLine("Vill du fortsätta och lägga till ett namn i listan igen? skriv Ja/Nej");
                input = Console.ReadLine().ToUpper();

                //Loop för att säkerställa att inmatningen är ja eller nej
                while (input != "JA" && input != "NEJ")
                {
                    Console.WriteLine("Fel inmatning. Du kan endast svara ja/nej. Försök igen\n");
                    Console.WriteLine("Vill du lägga till namn i listan? skriv ja/nej");
                    input = Console.ReadLine().ToUpper();
                }

            }
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
        }
    }
}