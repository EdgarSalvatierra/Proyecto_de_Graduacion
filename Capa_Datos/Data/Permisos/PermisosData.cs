using Capa_Datos.Data.Conexion;
using Capa_Datos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Permisos
{
    public class PermisosData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public bool Codificar(string Usuario, string Contraseña, string nombre)
        {
            List<Permiso> lista = new List<Permiso>();

            string query = $@"declare @IdUser int;
            set @IdUser  = (select Cod_User From tbl_User where Usuario = '{Usuario}' and Contraseña = '{Contraseña}')

            select p.IdRol, p.Modulo From tbl_Permiso as p inner join tbl_Roles as rol 
            on p.IdRol = rol.cod_rol inner join tbl_User as us on us.IdRol = rol.cod_rol
            where us.Cod_User = @IdUser";

            command = new SqlCommand(query, conexion.abrirconexion());

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Permiso
                {
                    oRoles = new Rol { cod_rol = Convert.ToInt32(reader["IdRol"]) },
                    Modulo = reader["Modulo"].ToString()
                });
            }
            return lista.Any(m => m.Modulo == nombre);
        }
    }
}
