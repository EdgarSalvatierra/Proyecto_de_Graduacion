using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Model
{
    public class Permiso
    {
        public int IdPermiso { get; set; }

        public Rol oRoles { get; set; }

        public string Modulo { get; set; }
    }
}
