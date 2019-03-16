using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class VrsteProizvoda
    {
        public VrsteProizvoda()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
