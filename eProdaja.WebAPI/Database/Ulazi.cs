using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Ulazi
    {
        public Ulazi()
        {
            UlazStavke = new HashSet<UlazStavke>();
        }

        public int UlazId { get; set; }
        public string BrojFakture { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }

        public Dobavljaci Dobavljac { get; set; }
        public Korisnici Korisnik { get; set; }
        public Skladista Skladiste { get; set; }
        public ICollection<UlazStavke> UlazStavke { get; set; }
    }
}
