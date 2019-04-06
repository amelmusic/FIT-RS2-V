using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.WebAPI.Database;

namespace eProdaja.WebAPI.Services
{
    public class VrsteProizvodaService : BaseService<Model.VrsteProizvoda, Database.VrsteProizvoda, object>
    {
        public VrsteProizvodaService(eProdajaContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        
    }
}
