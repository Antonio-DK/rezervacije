using System;

namespace rezervacije
{
    class Program
    {
        static void Main(string[] args)
        {
            UpravljanjeRezervacijama manager = new UpravljanjeRezervacijama();
            string izbor;

            do
            {
                Console.WriteLine("\n1. Dodaj rezervaciju");
                Console.WriteLine("2. Obrisi rezervaciju");
                Console.WriteLine("3. Prikazi rezervacije");
                Console.WriteLine("4. Izlaz");
                Console.Write("Odaberite opciju: ");

                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        Console.Write("Unesite ID rezervacije: ");
                        string id = Console.ReadLine();
                        Console.Write("Unesite ID klijenta: ");
                        string klijent = Console.ReadLine();
                        Console.Write("Unesite ID usluge: ");
                        string usluga = Console.ReadLine();
                        Console.Write("Unesite datum (YYYY-MM-DD): ");
                        string datum = Console.ReadLine();
                        Console.Write("Unesite vrijeme (HH:MM): ");
                        string vrijeme = Console.ReadLine();

                        manager.DodajRezervaciju(new Rezervacija(id, klijent, usluga, datum, vrijeme));
                        Console.WriteLine("Rezervacija uspješno dodana.");
                        break;

                    case "2":
                        Console.Write("Unesite ID rezervacije za brisanje: ");
                        string idZaBrisanje = Console.ReadLine();
                        manager.ObrisiRezervaciju(idZaBrisanje);
                        break;

                    case "3":
                        Console.WriteLine("\nTrenutne rezervacije:");
                        manager.PrikaziRezervacije();
                        break;

                    case "4":
                        Console.WriteLine("Izlaz iz programa.");
                        break;

                    default:
                        Console.WriteLine("Nepoznata opcija. Pokušajte ponovno.");
                        break;
                }

            } while (izbor != "4");
        }
    }
}