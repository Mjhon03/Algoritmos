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
    // No usar este controlador, solo es de ejemplo y no es permitido para la prueba
    // Importante usar CORS ya que la aplicacion y el api pueden no correr en el mimsmo servidor
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SampleController : ApiController
    {
        // GET: api/Sample
        public IEnumerable<ClienteModel> Get()
        {
            var clienteCore = new ClienteCore();
            return clienteCore.GetClientes();
        }

        // GET: api/Sample/5
        public ClienteModel Get(int id)
        {
            var clienteCore = new ClienteCore();
            return clienteCore.GetCliente(id);
        }

        // POST: api/Sample
        public ClienteModel Post([FromBody]ClienteModel model)
        {
            var clienteCore = new ClienteCore();
            return clienteCore.AddCliente(model);
        }

        // PUT: api/Sample/5
        public ClienteModel Put(int id, [FromBody]ClienteModel model)
        {
            var clienteCore = new ClienteCore();
            return clienteCore.UpdateCliente(model);
        }

        // DELETE: api/Sample/5
        public ClienteModel Delete(int id)
        {
            var clienteCore = new ClienteCore();
            return clienteCore.DeleteCliente(id);
        }
    }
}
