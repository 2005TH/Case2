using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Case2;

class Program
{

    static void Main(string[] args)
    {
        bool løkke;
        løkke = false;

        while (løkke == false)
        {
            
            Console.Clear();
            Console.WriteLine("Vælg en af fælgende valgmuligheder.");
            Console.WriteLine("Hvis du ikke indtaster nogle at valgmulighederne, vil du starte forfra.\n");
            Console.WriteLine("Lærer (1)");
            Console.WriteLine("Elev  (2)");
            Console.WriteLine("Fag   (3)");
            Console.WriteLine("Exit  (4)");
            Console.Write("Indtast: ");
            string Funktion = Console.ReadLine();

            if (Funktion == "1")
            {
                Console.Clear();
                Console.Write("Skriv det fulde navn på den lærer du vil søge på: ");
                string lærenavn = Console.ReadLine().ToLower();
                if (lærenavn == "lærenavn")
                {
                    Console.WriteLine("\nLæren underviser i Dissefag");
                    Console.WriteLine("Fag");
                    Console.WriteLine("Elever som har faget");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Der er ikke en lære med dette navn");
                    Console.ReadKey();
                }
            }
            if (Funktion == "2")
            {
                Console.Clear();
                Console.Write("Skriv det fulde navn på den elev du vil søge på: ");
                string elevnavn = Console.ReadLine().ToLower();
                if (elevnavn == "elevnavn")
                {
                    Console.WriteLine("\nEleven har disse fag");
                    Console.WriteLine("Fag");
                    Console.WriteLine("Denne lærer underviser faget");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Der er ikke en elev med dette navn");
                    Console.ReadKey();
                }
            }
            if (Funktion == "3")
            {
                Console.Clear();
                Console.Write("Skriv det fag du vil søge på: ");
                string fagnavn = Console.ReadLine().ToLower();
                if (fagnavn == "fagnavn")
                {
                    Console.WriteLine("\nDette fag bliver undervist af");
                    Console.WriteLine("Læren");
                    Console.WriteLine("Disse elever har faget");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Det er ikke et fag der bliver undervist i");
                    Console.ReadKey();
                }
            }
            if (Funktion == "4")
            {
                Environment.Exit(0);
            }
        }
    }
}