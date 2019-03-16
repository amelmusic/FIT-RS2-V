using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Narudzbe
    {
        public Narudzbe()
        {
            Izlazi = new HashSet<Izlazi>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }

        public Kupci Kupac { get; set; }
        public ICollection<Izlazi> Izlazi { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
