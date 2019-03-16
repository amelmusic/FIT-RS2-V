using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Skladista
    {
        public Skladista()
        {
            Izlazi = new HashSet<Izlazi>();
            Ulazi = new HashSet<Ulazi>();
        }

        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

        public ICollection<Izlazi> Izlazi { get; set; }
        public ICollection<Ulazi> Ulazi { get; set; }
    }
}
