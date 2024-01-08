using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Categorias
{
    public class CategoriaData
    {
        ConexionSql conexion = new ConexionSql();
        public SqlCommand command;
        public DataTable data;
        public SqlDataReader reader;

        public void Delete(int cod_categoria)
        {
            string query = $@"Delete From tbl_Categoria_Examen  where cod_area  = '{cod_categoria}'";

            command = new SqlCommand("sp_categoria_Delete", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_area", cod_categoria));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }

        public DataTable Read()
        {
            string query = $@"select cod_area as 'Codigo',categoria_Nombre as 'Area' From tbl_Categoria_Examen";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable ReadId(string cod_area)
        {
            string query = $@"select cod_area as 'Codigo',categoria_Nombre as 'Area'
            From tbl_Categoria_Examen where categoria_Nombre Like '%' + '{cod_area}' + '%'";

            command = new SqlCommand(query, conexion.abrirconexion());

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
        public void Update(int cod_area, string categoria_examen)
        {
            string query = $@"Update tbl_Categoria_Examen set categoria_Nombre = '{categoria_examen}' where cod_area = '{cod_area}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Insert(string Categoria_examen)
        {
            string query = $@"Insert into tbl_Categoria_Examen(categoria_Nombre) values('{Categoria_examen}')";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
