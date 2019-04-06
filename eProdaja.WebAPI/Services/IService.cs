using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IService<T, TSearch> where TSearch : class
    {
        List<T> Get(TSearch search = null);

        T GetById(int id);
    }
}
