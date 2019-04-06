using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{

    public class BaseCRUDController<T, TSearch, TInsert> : BaseController<T, TSearch> where TSearch : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert> _service;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }
    }
}