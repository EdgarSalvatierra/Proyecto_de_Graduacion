using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Model
{
    internal class Facturacion_list
    {
        public int Codigo { get; set; }

        public int CodigoPaciente { get; set; }

        public Registro_Paciente oPaciente { get; set; }

        public int Cod_Usuario { get; set; }

        public DateTime  Fecha_de_Entrega { get; set; }

        public DateTime HoradeEntrega { get; set; }
    }
}
