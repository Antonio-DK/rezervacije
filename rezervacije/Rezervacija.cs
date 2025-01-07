using System;
using System.Collections.Generic;

namespace rezervacije
{
    public interface IRezervacijeManager
    {
        void DodajRezervaciju(Rezervacija rezervacija);
        void ObrisiRezervaciju(string rezervacijaId);
        void PrikaziRezervacije();
    }

    public class Rezervacija
    {
        public string Id { get; set; }
        public string Klijent { get; set; }
        public string Usluga { get; set; }
        public string Datum { get; set; }
        public string Vrijeme { get; set; }

        public Rezervacija(string id, string klijent, string usluga, string datum, string vrijeme)
        {
            Id = id;
            Klijent = klijent;
            Usluga = usluga;
            Datum = datum;
            Vrijeme = vrijeme;
        }

        public override string ToString()
        {
            return $"Rezervacija ID: {Id}, Klijent: {Klijent}, Usluga: {Usluga}, Datum: {Datum}, Vrijeme: {Vrijeme}";
        }
    }
}