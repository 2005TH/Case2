using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Case2;
using Øvelse;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using static Case2.H;

enum Valg
{
    Lærer,
    Elev,
    Fag
}
class Program
{
    static void Main(string[] args)
    {
        bool løkke;
        løkke = false;

        H1 h1 = new H1();
        FagModel[] fag = h1.Fag;
        PersonModel[][] alleelever = h1.AlleElever;

        while (løkke == false)
        {
            Console.Clear();
            Console.WriteLine("Vælg en af fælgende valgmuligheder.");
            Console.WriteLine("Hvis du ikke indtaster nogle at valgmulighederne, vil du starte forfra.\n");
            Console.WriteLine($"" + Valg.Lærer +" (1)");
            Console.WriteLine($"" + Valg.Elev + "  (2)");
            Console.WriteLine($"" + Valg.Fag + "   (3)");
            Console.WriteLine("Exit  (4)");
            Console.Write("Indtast: ");
            string Funktion = Console.ReadLine();

            if (Funktion == "1")
            {
                Console.Clear();
                Console.WriteLine("Hvis Læreren ikke findes vil du blive smidt tilbage til menuen.");
                Console.WriteLine("\nDer skal være stort bogstav efter hvert mellemrum.");
                Console.Write("Skriv det fulde navn på den lærer du vil søge på: ");
                string lærenavn = Console.ReadLine();
                foreach (FagModel Fag in fag)
                {
                    if (Fag.Lærer.Fornavn + " " + Fag.Lærer.Efternavn == lærenavn)
                    {
                        Console.WriteLine($"\nFag: {Fag.FagNavn}");

                        PersonModel[]? elever = null;
                        if (Fag.FagNavn == "Studieteknik")
                        {
                            elever = h1.StudieTeknikElever;
                        }
                        if (Fag.FagNavn == "Grundlæggende programmering")
                        {
                            elever = h1.GrundlæggendeProgrammeringElever;
                        }
                        if (Fag.FagNavn == "OOP")
                        {
                            elever = h1.OOPElever;
                        }
                        if (Fag.FagNavn == "Computerteknologi")
                        {
                            elever = h1.ComputerteknologiElever;
                        }
                        if (Fag.FagNavn == "Clientsideprogrammering")
                        {
                            elever = h1.ClientsideprogrammeringElever;
                        }
                        if (Fag.FagNavn == "Netværk")
                        {
                            elever = h1.NetværkElever;
                        }
                        if (elever != null)
                        {
                            foreach (PersonModel elev in elever)
                            {
                                Console.WriteLine($"Elev: {elev.Fornavn} {elev.Efternavn}");
                            }
                        }
                    }
                }
                Console.Write("\nTryk på en tast for at fortsætte");
                Console.ReadKey();
            }
            if (Funktion == "2")
            {
                Console.Clear();
                Console.WriteLine("Hvis eleven ikke findes vil du blive smidt tilbage til menuen.");
                Console.WriteLine("\nDer skal være stort bogstav efter hvert mellemrum.");
                Console.Write("Skriv det fulde navn på den elev du vil søge på: ");
                string elevnavn = Console.ReadLine();
                int c = 0;
                if (alleelever.Length > 0)
                {
                    foreach (PersonModel[] item in alleelever)
                    {
                        var Elev = item.FirstOrDefault(x => x.Fornavn + " " + x.Efternavn == elevnavn);
                        if (Elev != null)
                        {
                            FagModel Fag = null;
                            if (c == 0)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Studieteknik");
                            }
                            if (c == 1)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Grundlæggende Programmering");
                            }
                            if (c == 2)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Database programmering");
                            }
                            if (c == 3)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "OOP");
                            }
                            if (c == 4)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Computerteknologi");
                            }
                            if (c == 5)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Clientsideprogrammering");
                            }
                            if (c == 6)
                            {
                                Fag = fag.FirstOrDefault(y => y.FagNavn == "Netværk");
                            }
                            if (Fag != null)
                            {
                                Console.WriteLine($"Fag: {Fag.FagNavn}");
                                Console.WriteLine($"Lærer: {Fag.Lærer.Fornavn} {Fag.Lærer.Efternavn}");
                            }
                        }
                        c++;
                    }
                    Console.Write("\nTryk på en tast for at fortsætte");
                    Console.ReadKey();
                }
            }
            if (Funktion == "3")
            {
                Console.Clear();
                Console.WriteLine("Hvis Faget ikke findes vil du blive smidt tilbage til menuen.");
                Console.WriteLine("\nDer skal være stort bogstav efter hvert mellemrum.");
                Console.Write("Skriv det fag du vil søge på: ");
                string fagnavn = Console.ReadLine();
                foreach (FagModel Fag in fag)
                {
                    if (Fag.FagNavn == fagnavn)
                    {
                        Console.WriteLine($"Læren: {Fag.Lærer.Fornavn} {Fag.Lærer.Efternavn}");
                        break;
                    }
                }
                PersonModel[]? elever = null;
                if (fagnavn == "Studieteknik")
                {
                    elever = h1.StudieTeknikElever;
                }
                if (fagnavn == "Grundlæggende Programmering")
                {
                    elever = h1.GrundlæggendeProgrammeringElever;
                }
                if (fagnavn == "OOP")
                {
                    elever = h1.OOPElever;
                }
                if (fagnavn == "Computerteknologi")
                {
                    elever = h1.ComputerteknologiElever;
                }
                if (fagnavn == "Clientsideprogrammering")
                {
                    elever = h1.ClientsideprogrammeringElever;
                }
                if (fagnavn == "Netværk")
                {
                    elever = h1.NetværkElever;
                }
                if (elever != null)
                {
                    foreach (PersonModel elev in elever)
                    {
                        Console.WriteLine($"Elev: {elev.Fornavn} {elev.Efternavn}");
                    }
                }
                if (elever == null)
                {
                    Console.WriteLine("Det er ikke et fag vi underviser i, prøv igen");
                }

                Console.Write("\nTryk på en tast for at fortsætte");
                Console.ReadKey();
            }
            if (Funktion == "4")
            {
                Environment.Exit(0);
            }
        }
    }
}