using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly IProizvodService _proizvodService;
        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }

        [HttpGet]
        public ActionResult<List<Proizvod>> Get()
        {
            return _proizvodService.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Proizvod> GetById(int id)
        {
            return _proizvodService.GetById(id);
        }

        [HttpPost]
        public Proizvod InsertProizvod(Proizvod proizvod)
        {
            return new Proizvod { Name = proizvod.Name, ProizvodID = -1 };
        }

        [HttpPut("{id}")]
        public Proizvod UpdateProizvod(int id, [FromBody]Proizvod proizvod)
        {
            return null;//new Proizvod { Name = proizvod.Name, ProizvodID = id };
        }
    }
}