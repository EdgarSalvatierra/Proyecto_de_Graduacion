using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Paciente
{
    public class PacienteData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Id)
        {
            string query = $@"Delete From tbl_Registros_de_Pacientes where Cod_paciente = '{Id}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Codigo", Id));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }

        public void Insert(string Nombre, long telefono, DateTime FechadeNacimiento, string sexo)
        {
            string query = $@"Insert into tbl_Registros_de_Pacientes(Nombre,Fecha_de_Nacimiento,Edad,Sexo,Telefono,Estado) 
             values('{Nombre}','{FechadeNacimiento}', DATEDIFF(YEAR, CONVERT(date, '{FechadeNacimiento}'), GETDATE()),'{sexo}','{telefono}',1)";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            string query = $@"Select Cod_paciente as 'Codigo',Nombre as 'Paciente',Fecha_de_Nacimiento as 'Fecha de Nacimiento',Edad as 'Edad',Sexo as 'Sexo',Telefono as 'Telefono'
                           From tbl_Registros_de_Pacientes where Estado = 1";

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
            string query = "Select Cod_paciente,Nombre From tbl_Registros_de_Pacientes";

            command = new SqlCommand(query, conexion.abrirconexion());

            DataTable data = new DataTable();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                data.Load(reader);
            }

            conexion.cerrarconexion();

            return data;
        }
        public DataTable ReadForName(string Codigo)
        {
            string query = $@"select Cod_paciente as 'Codigo',Nombre,Fecha_de_Nacimiento as 'Fecha de Nacimiento',Sexo,Telefono From tbl_Registros_de_Pacientes where Nombre Like '%' + '{Codigo}' + '%'";

            command = new SqlCommand(query, conexion.abrirconexion()); ;

            DataTable data = new DataTable();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                data.Load(reader);
            }
            conexion.cerrarconexion();

            return data;
        }
        public void Update(int Id, string Nombre, DateTime date, long telefono, string sexo, string correo)
        {
            string query = $@"Update tbl_Registros_de_Pacientes set Nombre = '{Nombre}',Fecha_de_Nacimiento = '{date.Date}',Sexo = '{sexo}', Telefono = '{telefono} where Cod_paciente = '{Id}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
