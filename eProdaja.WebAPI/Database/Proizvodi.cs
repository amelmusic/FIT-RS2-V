using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Proizvodi
    {
        public Proizvodi()
        {
            IzlazStavke = new HashSet<IzlazStavke>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Ocjene = new HashSet<Ocjene>();
            UlazStavke = new HashSet<UlazStavke>();
        }

        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public int JedinicaMjereId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Status { get; set; }

        public JediniceMjere JedinicaMjere { get; set; }
        public VrsteProizvoda Vrsta { get; set; }
        public ICollection<IzlazStavke> IzlazStavke { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<UlazStavke> UlazStavke { get; set; }
    }
}
