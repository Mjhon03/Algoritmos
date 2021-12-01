using System.Collections.Generic;
using TechnicalDataAccess;
using TechnicalModel;

namespace TechnicalCore
{

    public class FacturaCore
    {
        FacturaDataAccess facturaDataAccess = new FacturaDataAccess();
        public IList<FacturaModel> GetFacturas()
        {
            // TODO: Obtener DataTable con las facturas
            // TODO: Construir una lista del modelo Factura con los datos obtenidos
            return new List<FacturaModel>();
        }

        public FacturaModel GetFactura(int id)
        {
            // TODO: Obtener DataTable con las facturas
            // TODO: Construir una lista del modelo Factura con los datos obtenidos
            return null;
        }
        public FacturaModel AddFactura(FacturaModel model)
        {
            string result = facturaDataAccess.InsertarFactura(model);
            if (result == "Correcto")
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        // Get Factura
        // Add Factura
        // Update Factura
        // Delete Factura
    }
}