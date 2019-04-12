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
    public class ProizvodService : BaseCRUDService<Model.Proizvod, ProizvodSearchRequest, Proizvodi, ProizvodUpsertRequest, ProizvodUpsertRequest>
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Proizvod> Get(ProizvodSearchRequest search)
        {
            var query = _context.Set<Proizvodi>().AsQueryable();

            if(search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }

            query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }
    }
}
