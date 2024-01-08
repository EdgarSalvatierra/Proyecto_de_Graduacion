using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Model
{
     public class Informacion_Entidad
    {
        public int Codigo { get; set; }

        public int Codigo_Configuracion { get; set; }

        public Configuracion oconfig { get; set; }

        public string Nombre { get; set; }

        public string  Administrador_Actual { get; set; }

        public long Telefono { get; set; }

        public string ubicacion { get; set; }

        public string ciudad { get; set; }
    }
}
