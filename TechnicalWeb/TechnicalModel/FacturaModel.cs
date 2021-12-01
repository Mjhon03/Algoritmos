using System.Collections.Generic;

namespace TechnicalModel
{
    public class FacturaModel
    {
        public int Id { get; set; }
        public int Id_Client { get; set; }
        public string Cod { get; set; }

        ///Entity framework
        public List<FacturaDetalleModel> details { get; set; }

    }
}