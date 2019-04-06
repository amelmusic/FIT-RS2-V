using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.WebAPI.Database;

namespace eProdaja.WebAPI.Services
{
    public class BaseCRUDService<T, TInternal, TSearch, TInsert> : BaseService<T, TInternal, TSearch>
        , ICRUDService<T, TSearch, TInsert> where TInternal : class where TSearch : class
    {
        public BaseCRUDService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual T Insert(TInsert insert)
        {
            var entity = _mapper.Map<TInternal>(insert);

            _context.Set<TInternal>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
