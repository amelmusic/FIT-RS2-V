using AutoMapper;
using eProdaja.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class BaseService<T, TInternal, TSearch> : IService<T, TSearch> where TInternal : class where TSearch : class
    {
        protected readonly eProdajaContext _context;
        protected readonly IMapper _mapper;
        public BaseService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<T> Get(TSearch search = null)
        {
            var list = _context.Set<TInternal>().ToList();

            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var entity = _context.Set<TInternal>().Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
