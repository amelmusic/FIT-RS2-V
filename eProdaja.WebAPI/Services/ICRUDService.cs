using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface ICRUDService<T, TSearch, TInsert> : IService<T, TSearch> where TSearch : class
    {
        T Insert(TInsert insert);
    }
}
