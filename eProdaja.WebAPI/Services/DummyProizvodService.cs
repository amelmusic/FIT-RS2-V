using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.WebAPI.Services
{
    public class DummyProizvodService : IProizvodService
    {
        public List<Proizvod> Get()
        {
            throw new NotImplementedException();
        }

        public Proizvod GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
