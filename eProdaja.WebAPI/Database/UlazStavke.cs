using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class UlazStavke
    {
        public int UlazStavkaId { get; set; }
        public int UlazId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public Proizvodi Proizvod { get; set; }
        public Ulazi Ulaz { get; set; }
    }
}
