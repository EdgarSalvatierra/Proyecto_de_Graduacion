using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Proveedores
{
    public class ProveedorData
    {
        ConexionSql conexion = new ConexionSql();

        SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Cod_Proveedor)
        {
            command = new SqlCommand("Sp_Proveedor_Delete", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("Cod_Proveedor", Cod_Proveedor));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Insertar(string Nombre, string Casa_Comercial)
        {
            command = new SqlCommand("Sp_Proveedor_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Casa_Comercial", Casa_Comercial));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();

        }
        public DataTable Read()
        {
            command = new SqlCommand("Sp_Proveedor_Read", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = command;

            DataTable data = new DataTable();

            dataAdapter.Fill(data);

            return data;
        }
        public DataTable ReadId(int Cod_Proveedor)
        {
            command = new SqlCommand("Sp_Proveedor_ReadId", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Proveedor", Cod_Proveedor));

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
        public void Update(int Cod_Proveedor, string Nombre, string Casa_Comercial)
        {
            command = new SqlCommand("Sp_Proveedor_Update", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Proveedor", Cod_Proveedor));

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Casa_Comercial", Casa_Comercial));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
