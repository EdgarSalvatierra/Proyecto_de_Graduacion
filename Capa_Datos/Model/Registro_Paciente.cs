using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Model
{
    public class Registro_Paciente
    {
        public int Cod_Paciente { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha_de_Nacimiento { get; set; }

        public int Edad { get; set; }

        public string  Sexo { get; set; }

        public long Telefono { get; set; }

        public byte Estado { get; set; }


    }
}
