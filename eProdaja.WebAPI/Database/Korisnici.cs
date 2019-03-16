using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            Izlazi = new HashSet<Izlazi>();
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Ulazi = new HashSet<Ulazi>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }

        public ICollection<Izlazi> Izlazi { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Ulazi> Ulazi { get; set; }
    }
}
