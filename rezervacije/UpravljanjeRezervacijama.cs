using rezervacije;
using System;
using System.Collections.Generic;

namespace rezervacije
{
    public class UpravljanjeRezervacijama
    {
        private readonly List<Rezervacija> _rezervacije = new List<Rezervacija>();

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            _rezervacije.Add(rezervacija);
        }

        public void ObrisiRezervaciju(string rezervacijaId)
        {
            Rezervacija zaBrisanje = null;
            foreach (var rezervacija in _rezervacije)
            {
                if (rezervacija.Id == rezervacijaId)
                {
                    zaBrisanje = rezervacija;
                    break;
                }
            }

            if (zaBrisanje != null)
            {
                _rezervacije.Remove(zaBrisanje);
                Console.WriteLine("Rezervacija uspješno obrisana.");
            }
            else
            {
                Console.WriteLine("Rezervacija s tim ID-jem nije pronađena.");
            }
        }

        public void PrikaziRezervacije()
        {
            if (_rezervacije.Count == 0)
            {
                Console.WriteLine("Nema rezervacija za prikaz.");
                return;
            }

            foreach (var rezervacija in _rezervacije)
            {
                Console.WriteLine(rezervacija);
            }
        }
    }
}
