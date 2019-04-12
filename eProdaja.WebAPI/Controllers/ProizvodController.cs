using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    public class ProizvodController : BaseCRUDController<Model.Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest>
    {
        public ProizvodController(ICRUDService<Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest> service) : base(service)
        {
        }
    }
}
