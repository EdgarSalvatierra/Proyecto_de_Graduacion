using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Roles
{
    public class RolesData
    {
        ConexionSql conexion = new ConexionSql();

        SqlCommand command;

        SqlDataReader reader;

        public void Delete(int cod_rol)
        {
            command = new SqlCommand("Sp_Roles_Delete", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_rol", cod_rol));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Insertar(string Nom_Roles)
        {
            command = new SqlCommand("Sp_Roles_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Nom_Roles", Nom_Roles));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            command = new SqlCommand("Sp_Roles_Read", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = command;

            DataTable data = new DataTable();

            dataAdapter.Fill(data);

            return data;
        }
        public DataTable ReadId(int cod_rol)
        {
            command = new SqlCommand("Sp_Roles_ReadId", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_rol", cod_rol));

            DataTable data = new DataTable();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                data.Load(reader);
            }
            else
            {
                conexion.cerrarconexion();
            }
            conexion.cerrarconexion();

            return data;
        }
        public void Update(int cod_rol, string Nom_Roles)
        {
            command = new SqlCommand("Sp_Roles_Update", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_rol", cod_rol));

            command.Parameters.Add(new SqlParameter("@Nom_Roles", Nom_Roles));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
