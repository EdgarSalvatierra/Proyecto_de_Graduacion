using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Model;

namespace Capa_Datos.Data.Examenes
{
    public class ExamenesData
    {
        ConexionSql conexion = new ConexionSql();
        public SqlCommand command;
        public DataTable data;
        public SqlDataReader reader;

        public void Insertar(int cod_area, string nombre,byte[] Documento,string Extension,decimal precio)
        {
            try
            {
                string query = $@"insert into tbl_Examen(cod_categoria,nombre,documento,Extension,precio,cantidad,Estado) 
            values((Select cod_area From  tbl_Categoria_Examen where cod_area = @codarea),@nombre,@documento,@extension,@precio,1,1)";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@codarea", cod_area));

                command.Parameters.Add(new SqlParameter("@nombre", nombre));

                command.Parameters.Add(new SqlParameter("@documento", Documento));

                command.Parameters.Add(new SqlParameter("@extension", Extension));

                command.Parameters.Add(new SqlParameter("@precio", precio));

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
                string query = $@"select examen.cod_examen as 'Codigo Examen',categoria.categoria_Nombre as 'Categoria',
            examen.nombre as 'Examen',examen.extension as 'Plantilla',cast(examen.precio as integer) as 'Precio del examen' 
            From tbl_Examen as examen inner join tbl_Categoria_Examen as categoria 
            on categoria.cod_area = examen.cod_categoria where categoria.Estado = 1";

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
        public DataTable BuscarporExamen(string Examen)
        {
            try
            {
                string query = $@"select cod_examen,cod_categoria,nombre,precio from tbl_Examen where  nombre Like '{Examen}' + '%'";

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
        public DataTable CargarDatos()
        {
            try
            {
                string query = $@"Select cod_examen,nombre + '= $' + cast(precio as nvarchar) as 'Titulo' From tbl_Examen";

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
        public void Update(int cod_categoria, string nombre, decimal precio)
        {
            try
            {
                string query = $@"update tbl_Examen set nombre = @nombre, precio = @precio
            where cod_categoria = @cod_categoria";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@nombre", nombre));

                command.Parameters.Add(new SqlParameter("@precio", precio));

                command.Parameters.Add(new SqlParameter("@cod_categoria", cod_categoria));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void Delete(int codcategoria)
        {
            try
            {
                string query = $@"Delete From tbl_Examen where cod_categoria = @cod_categoria";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@cod_categoria", codcategoria));

                command.ExecuteNonQuery();

            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
    }
}
