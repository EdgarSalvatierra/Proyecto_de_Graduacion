using Capa_Datos.Data.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Roles_Model
    {
        RolesData roles = new RolesData();
        public void InsertarRol(string Nom_Roles)
        {
            roles.Insertar(Nom_Roles);
        }
        public Object LeerRol()
        {
            return roles.Read();
        }
        public void ReadId(int cod_rol)
        {
            roles.ReadId(cod_rol);
        }
        public void ActualizarRol(int cod_rol, string Nom_Roles)
        {
            roles.Update(cod_rol, Nom_Roles);
        }
        public void EliminarRoles(int cod_rol)
        {
            roles.Delete(cod_rol);
        }
    }
}
