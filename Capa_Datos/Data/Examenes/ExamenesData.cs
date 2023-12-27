using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Examenes
{
    public class ExamenesData
    {
        ConexionSql conexion = new ConexionSql();
        public SqlCommand command;
        public DataTable data;
        public SqlDataReader reader;

        public void Insertar(int cod_area, string nombre, decimal precio)
        {
            string query = $@"insert into tbl_Examen(cod_categoria,nombre,precio) 
            values((Select cod_area From  tbl_Categoria_Examen where cod_area = '{cod_area}'),'{nombre}','{precio}')";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            string query = $@"select examen.cod_examen as 'Codigo Examen',categoria.categoria_Nombre as 'Categoria',
            examen.nombre as 'Examen',cast(examen.precio as integer) as 'Precio del examen'
            From tbl_Examen as examen inner join tbl_Categoria_Examen as categoria 
            on categoria.cod_area = examen.cod_categoria";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable BuscarporExamen(string Examen)
        {
            string query = $@"select cod_examen,cod_categoria,nombre,precio from tbl_Examen where  nombre Like '%' + '{Examen}' + '%'";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable CargarDatos()
        {
            string query = $@"Select cod_examen,nombre + '= $' + cast(precio as nvarchar) as 'Titulo' From tbl_Examen";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public void Update(int cod_categoria, string nombre, decimal precio)
        {
            string query = $@"update tbl_Examen set nombre = '{nombre}', precio = '{precio}'
            where cod_categoria = '{cod_categoria}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Delete(int codcategoria)
        {
            string query = $@"Delete From tbl_Examen where cod_categoria = '{codcategoria}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
