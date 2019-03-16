using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class IzlazStavke
    {
        public int IzlazStavkaId { get; set; }
        public int IzlazId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }

        public Izlazi Izlaz { get; set; }
        public Proizvodi Proizvod { get; set; }
    }
}
