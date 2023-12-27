using Capa_Datos.Data.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public  class Permiso_Model
    {
        PermisosData permiso = new PermisosData();

        public bool GetPermisos(string Usuario, string contraseña, string Nombre)
        {
            return permiso.Codificar(Usuario, contraseña, Nombre);
        }
    }
}
