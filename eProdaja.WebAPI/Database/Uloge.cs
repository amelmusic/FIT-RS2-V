using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
