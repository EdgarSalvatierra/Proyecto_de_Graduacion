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
            string query = $@"Delete From tbl_Reservacion_Citas where cod_cita = '{cod_cita}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Insertar(string nombre, DateTime Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora)
        {

            command = new SqlCommand("Sp_Reservacion_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@nombre_completo", nombre));

            command.Parameters.Add(new SqlParameter("@Fecha_de_Nacimiento", Nacimiento.Date));

            command.Parameters.Add(new SqlParameter("@telefono", telefono));

            command.Parameters.Add(new SqlParameter("@motivo", motivo));

            command.Parameters.Add(new SqlParameter("@fecha_realizacion", fecha.Date));

            command.Parameters.Add(new SqlParameter("@hora_realizacion", hora.TimeOfDay));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            string query = $@"Select cod_cita as 'Codigo',nombre_completo as 'Nombre',Fecha_de_Nacimiento as 'Fecha de Nacimiento',
             telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' From tbl_Reservacion_Citas";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable Buscador(int Codigo, string Paciente, long Telefono)
        {
            string query = "";

            if (Codigo != 0)
            {
                query = $@"Select cod_cita as 'Codigo',nombre_completo as 'Nombre',Fecha_de_Nacimiento as 'Fecha de Nacimiento',
                        telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' 
                        From tbl_Reservacion_Citas where cod_cita Like '%' + '{Codigo}' + '%' ";
            }
            else if (Paciente != "")
            {
                query = $@"Select cod_cita as 'Codigo',nombre_completo as 'Nombre',Fecha_de_Nacimiento as 'Fecha de Nacimiento',
                        telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' 
                        From tbl_Reservacion_Citas where nombre_completo Like '%' + '{Paciente}' + '%' ";
            }
            else if (Telefono != 9)
            {
                query = $@"Select cod_cita as 'Codigo',nombre_completo as 'Nombre',Fecha_de_Nacimiento as 'Fecha de Nacimiento',
                        telefono as 'Telefono',motivo as 'Motivo',fecha_realizacion as 'Fecha de Cita',hora_de_realizacion as 'Hora de Cita' 
                        From tbl_Reservacion_Citas where telefono Like '%' + '{Telefono}' + '%' ";
            }
            else
            {
                conexion.cerrarconexion();
            }

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public void Update(string nombre, DateTime fecha_de_Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora, int cod_cita)
        {
            string sql = $@"Update tbl_Reservacion_Citas set nombre_completo = '{nombre}', Fecha_de_Nacimiento = '{fecha_de_Nacimiento}', telefono = '{telefono}', motivo = '{motivo}'
             ,fecha_realizacion = '{fecha.Date}', hora_de_realizacion = '{hora.TimeOfDay}' where cod_cita = '{cod_cita}'";

            command = new SqlCommand(sql, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
