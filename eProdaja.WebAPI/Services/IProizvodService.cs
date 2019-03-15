using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IProizvodService
    {
        List<Proizvod> Get();
        Proizvod GetById(int id);
    }
}
