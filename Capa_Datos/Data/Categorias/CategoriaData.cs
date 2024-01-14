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
            try
            {
                command = new SqlCommand("sp_categoria_Delete", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@cod_area", cod_categoria));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable Read()
        {
            try
            {
                string query = $@"select cod_area as 'Codigo',categoria_Nombre as 'Area' From tbl_Categoria_Examen";

                command = new SqlCommand(query, conexion.abrirconexion());

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = command;

                DataTable data = new DataTable();

                adapter.Fill(data);

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable ReadId(string cod_area)
        {
            try
            {
                string query = $@"select cod_area as 'Codigo',categoria_Nombre as 'Area'
                From tbl_Categoria_Examen where categoria_Nombre Like  '{cod_area}' + '%'";

                command = new SqlCommand(query, conexion.abrirconexion());

                DataTable data = new DataTable();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    data.Load(reader);
                }

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void Update(int cod_area, string categoria_examen)
        {
            try
            {
                string query = $@"Update tbl_Categoria_Examen set categoria_Nombre = @categoria_examen where cod_area = @cod_area";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@categoria_examen", categoria_examen));

                command.Parameters.Add(new SqlParameter("@cod_area", cod_area));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void Insert(string Categoria_examen)
        {
            try
            {
                string query = $@"Insert into tbl_Categoria_Examen(categoria_Nombre) values(@Categoria_examen)";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Categoria_examen", Categoria_examen));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
    }
}
