using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalModel
{
    public class FacturaDetalleModel
    {
        public int ID { get; set; }
        public int Id_Invoice { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
    }
}
