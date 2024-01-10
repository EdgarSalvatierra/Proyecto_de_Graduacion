using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Model
{
    public class Productos
    {
        public int Codigo { get; set; }

        public int Cod_Proveedor { get; set; }

        public ProveedoresClass oProveedor { get; set; }

        public string producto { get; set; }

        public decimal Precio { get; set; }
    }
}
