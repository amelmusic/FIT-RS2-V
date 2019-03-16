using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int ProizvodId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public Kupci Kupac { get; set; }
        public Proizvodi Proizvod { get; set; }
    }
}
