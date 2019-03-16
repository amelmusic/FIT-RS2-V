using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class JediniceMjere
    {
        public JediniceMjere()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int JedinicaMjereId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
