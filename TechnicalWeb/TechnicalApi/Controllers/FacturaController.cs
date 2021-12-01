using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TechnicalCore;
using TechnicalModel;

namespace TechnicalApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FacturaController : ApiController
    {
        // GET: api/Sample
        public IEnumerable<FacturaModel> Get()
        {
            var facturaCore = new FacturaCore();
            return facturaCore.GetFacturas();
        }

        // GET: api/Sample/5
        public FacturaModel Get(int id)
        {
            var facturaCore = new FacturaCore();
            return facturaCore.GetFactura(id);
        }

        // POST: api/Sample
        public FacturaModel Post([FromBody] FacturaModel model)
        {
            var facturaCore = new FacturaCore();
            return facturaCore.AddFactura(model);
        }

       
    }
}
