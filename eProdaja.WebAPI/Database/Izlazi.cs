using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Izlazi
    {
        public Izlazi()
        {
            IzlazStavke = new HashSet<IzlazStavke>();
        }

        public int IzlazId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public bool Zakljucen { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int? NarudzbaId { get; set; }
        public int SkladisteId { get; set; }

        public Korisnici Korisnik { get; set; }
        public Narudzbe Narudzba { get; set; }
        public Skladista Skladiste { get; set; }
        public ICollection<IzlazStavke> IzlazStavke { get; set; }
    }
}
