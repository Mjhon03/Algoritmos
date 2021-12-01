using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalDataAccess;
using TechnicalModel;

namespace TechnicalCore
{
    public class ClienteCore
    {
        ClienteDataAccess clienteDataAccess = new ClienteDataAccess();

        public IList<ClienteModel> GetClientes()
        {
            DataTable dt = clienteDataAccess.GetClientes();
            // TODO: Obtener DataTable con los clientes
            List<ClienteModel> listaCliente = new List<ClienteModel>();
            listaCliente = (from DataRow dr in dt.Rows
                           select new ClienteModel()
                           {
                               ID = Convert.ToInt32(dr["ID"]),
                               Name = dr["Name"].ToString(),
                               Last_Name = dr["Last_Name"].ToString(),
                               Document_ID = dr["Document_ID"].ToString()
                           }).ToList();
            // TODO: Construir una lista del modelo cliente con los datos obtenidos
            return listaCliente;
        }

        public ClienteModel UpdateCliente(ClienteModel model)
        {
            throw new NotImplementedException();
        }

        public ClienteModel AddCliente(ClienteModel model)
        {
            string result = clienteDataAccess.InsertarCliente(model);
            if(result == "Correcto")
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public ClienteModel DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public ClienteModel GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        // Get Cliente
        // Add Cliente
        // Update Cliente
        // Delete Cliente
    }
}
