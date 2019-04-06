using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Database;

namespace eProdaja.WebAPI.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, Database.Proizvodi, ProizvodiSearchRequest, ProizvodiInsertRequest>
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override List<Proizvod> Get(ProizvodiSearchRequest search = null)
        {
            var query = _context.Proizvodi.AsQueryable();

            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }

            var list = query.OrderBy(x=>x.Naziv).ToList();

            return _mapper.Map<List<Proizvod>>(list);
        }
    }
}
