using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.WebAPI.Services
{
    public class ProizvodService : IProizvodService
    {
		//demo for singletone IoC
        string tmp = null;
        public ProizvodService()
        {
            if (string.IsNullOrWhiteSpace(tmp))
            {
                tmp = Guid.NewGuid().ToString();
            }
        }
        
        public List<Proizvod> Get()
        {
            var list = new List<Proizvod>()
            {
                new Proizvod() { ProizvodID = 1, Name = "Monitor"}
                ,new Proizvod() { ProizvodID = 2, Name = "Laptop"}
            };

            return list;
        }

        public Proizvod GetById(int id)
        {
            return new Proizvod() { ProizvodID = id, Name = "test" };
        }
    }
}
