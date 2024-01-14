using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Citas
{
    public class CitasData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;
        public DataTable data;
        public SqlDataReader reader;


        public void Delete(int cod_cita)
        {
            try
            {
                string query = $@"Delete From tbl_Reservacion_Citas where cod_cita = '{cod_cita}'";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void Insertar(string nombre,string apellido,DateTime Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora)
        {
            try
            {
                command = new SqlCommand("Sp_Reservacion_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@nombre", nombre));

                command.Parameters.Add(new SqlParameter("@Fecha_de_Nacimiento", Nacimiento));

                command.Parameters.Add(new SqlParameter("@telefono", telefono));

                command.Parameters.Add(new SqlParameter("@motivo", motivo));

                command.Parameters.Add(new SqlParameter("@fecha_realizacion", fecha));

                command.Parameters.Add(new SqlParameter("@hora_realizacion", hora.TimeOfDay));

                command.Parameters.Add(new SqlParameter("@apellido", apellido));

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
                string query = $@"Select cod_cita as 'Codigo',nombre  + ' ' + apellido as 'Nombres', Fecha_de_Nacimiento as 'Fecha de Nacimiento',
             telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' From tbl_Reservacion_Citas
             where Estado = 1";

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
        public DataTable Buscador(string Paciente, long Telefono)
        {
            try
            {
                string query = $@"Select cod_cita as 'Codigo',nombre + ' ' + apellido as 'Nombre',Fecha_de_Nacimiento as 'Fecha de Nacimiento',
                        telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' 
                        From tbl_Reservacion_Citas where nombre Like  '{Paciente}' + '%' or Telefono Like '%' + '{Telefono}' + '%'";

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
        public void Update(string nombre, DateTime fecha_de_Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora, int cod_cita)
        {
            try
            {
                string sql = $@"Update tbl_Reservacion_Citas set nombre_completo = '{nombre}', Fecha_de_Nacimiento = '{fecha_de_Nacimiento}', telefono = '{telefono}', motivo = '{motivo}'
             ,fecha_realizacion = '{fecha.Date}', hora_de_realizacion = '{hora.TimeOfDay}' where cod_cita = '{cod_cita}'";

                command = new SqlCommand(sql, conexion.abrirconexion());

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
    }
}
