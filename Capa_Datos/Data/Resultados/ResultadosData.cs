using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Resultados
{
    public class ResultadosData
    {
        ConexionSql conexion = new ConexionSql();
        public SqlCommand command;


        public DataTable Read()
        {
            string query = $@"select Id, nombre, tbl_Categoria_Examen.categoria_Nombre as Categoria, precio 
from Resultado_Examenes inner join tbl_Categoria_Examen on Resultado_Examenes.Categoria = tbl_Categoria_Examen.cod_area";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }

        public void InsertarResultados(string Nombre, string NombrePaciente, byte[] Documento, string Extension, int Categoria, decimal Precio)
        {
            SqlCommand comando = new SqlCommand("insert into Resultado_Examenes values (@nombre, @nombrepaciente, @documento, @extension, @categoria, @precio)", conexion.abrirconexion());

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@nombrepaciente", NombrePaciente);
            comando.Parameters.AddWithValue("@documento", Documento);
            comando.Parameters.AddWithValue("@extension", Extension);
            comando.Parameters.AddWithValue("@categoria", Categoria);
            comando.Parameters.AddWithValue("@precio", Precio);
            comando.ExecuteNonQuery();


            conexion.cerrarconexion();

        }
    }
}
