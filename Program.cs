using System;
using System.Collections.Generic;
using System.Globalization;
namespace NameSorter
{
    //Klass som innehåller metoder för att hantera en lista av namn
    public class Metoder
    {
        //Lista som lagrar namn. Lista eftersom den har en,dynamisk storlek, lätt att manipulera, flexibilitet och prestanda
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

        //Metod för att validera att namnet innehåller bara bokstäver
        public string GetValidName()
        {
            Console.WriteLine("Skriv vilket namn du vill lägga till:");
            string addname = Console.ReadLine();
            //Kontrollerar att namnet endast innehåller bokstäver
            while (!addname.All(char.IsLetter))
            {
                Console.WriteLine("Ogiltlig inmatning. Ange namn som enbart inehåller bokstäver inga siffror");
                addname = Console.ReadLine();

            }
            return addname;
        }



        //Metod för att säkerställa att en matning är ja/nej
        public string ja_nej()
        {
            string input = Console.ReadLine().ToUpper();

            while (input != "JA" && input != "NEJ")
            {

                Console.WriteLine("Fel inmatning. Du kan endast svara ja/nej. Försök igen\n");
                Console.WriteLine("Vill du lägga till namn i listan? skriv ja/nej");
                input = Console.ReadLine().ToUpper();

            }
            return input;
        }



        //Metod för att lägga till namn i listan 
        public void lägga_till()
        {
            //Fråga användaren om de vill lägga till namn 
            Console.WriteLine("Vill du lägga till namn i listan? skriv ja/nej");
            string input;

            //Loop för att säkerställa att inmatningen är ja eller nej
            input = ja_nej();

            //Loop för att lägga till namn så länge användaren svarar ja 
            while (input == "JA")
            {
                string addname = GetValidName();
                //Kallar på CapitalizeFirstLetter för att omformatera namnet 
                string reformated = CapitalizeFirstLetter(addname);
                names.Add(reformated);//Lägger till det omformaterade namnet i listan
                //Frågar om användaren vill lägga till fler namn
                Console.WriteLine("Vill du fortsätta och lägga till ett namn i listan igen? skriv Ja/Nej");
                //kallar på metoden lagrar i input
                input = ja_nej();

            }
        }

        //Metod för att sortera namnen i listan 
        public void sortera()
        {
            Console.WriteLine("Sorterad och uppdaterad lista");
            names.Sort(); //sortera listan med namn
            lista(); //Skriv ut den sorterade listan
        }

        //Metod för att söka efter ett namn i listan
        public void search()
        {
            Console.WriteLine("Vill du söka efter ett namn");
            string search = Console.ReadLine(); //ta emot namnet att söka efter
            //kollar att search strängen innehåller enbart bokstäver.
            while (!search.All(char.IsLetter))
            {
                Console.WriteLine("Ogiltlig inmatning. Ange namn som enbart inehåller bokstäver inga siffror");
                search = Console.ReadLine();

            }
            //Omformatera namnet för att matcha formatet i listan
            string reformated = CapitalizeFirstLetter(search);


            //kontrollera om namnet finns i listan och ge feedback till användaren
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
            //Skapa en instans av metoder för att använda dess funktioner 
            Metoder metoder = new Metoder();
            //Skriv ut den ursprungliga listan av namn
            metoder.lista();
            Console.WriteLine();
            //Låt användaren lägga till namn
            metoder.lägga_till();
            Console.WriteLine();
            //Sortera och skriv ut den sorterade listan av namn
            metoder.sortera();
            Console.WriteLine();
            //Sök efter ett namn i listan
            metoder.search();
            Console.WriteLine();
        }
    }
}