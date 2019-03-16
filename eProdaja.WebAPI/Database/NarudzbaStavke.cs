using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

        public Narudzbe Narudzba { get; set; }
        public Proizvodi Proizvod { get; set; }
    }
}
