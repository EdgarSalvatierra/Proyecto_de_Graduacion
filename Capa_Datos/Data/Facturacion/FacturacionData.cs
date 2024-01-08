using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Model;
using System.Collections;

namespace Capa_Datos.Data.Facturacion
{
    public class FacturacionData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Cod_Factura)
        {
            command = new SqlCommand("Ms_Facturas_Detalles_Delete", conexion.abrirconexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Factura", Cod_Factura));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void InsertFactura(int codigopaciente, int numeroruc, decimal SubTotal, decimal Total, DateTime Fecha_de_entrega, DateTime Hora_de_entrega)
        {
            command = new SqlCommand("Facturacion_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_paciente", codigopaciente));

            command.Parameters.Add(new SqlParameter("@cod_Facturacion", numeroruc));

            command.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));

            command.Parameters.Add(new SqlParameter("@Total", Total));

            command.Parameters.Add(new SqlParameter("@Fecha_de_Entrega", Fecha_de_entrega.Date));

            command.Parameters.Add(new SqlParameter("@Hora_de_Entrega", Hora_de_entrega.TimeOfDay));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void InsertDetalles(decimal Precio, int numeroruc, string codigoexamen, decimal SubTotal, decimal Total)
        {
            string query = $@"declare @IsValue int; 
                            SET @Isvalue = (SELECT cod_examen FROM tbl_Examen WHERE nombre = '{codigoexamen}'  );
                            insert into  tbl_Detalle_Facturacion(Cod_Factura,Cod_Examen,Precio,Cantidad,SubTotal,Total) values('{numeroruc}',@IsValue,'{Precio}',1,'{SubTotal}','{Total}')";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable BuscarporNumeroFactura(int numeroFactura)
        {
            string query = $@"Select fact.Cod_Facturacion,pacientes.Nombre,Convert(date,fact.Fecha_Actual) as 'Fecha',fact.SubTotal,fact.Total,
            Convert(date,fact.Fecha_de_Entrega) as 'Fecha de Entrega',fact.Hora_de_Entrega as 'Hora de Entrega' From tbl_Facturacion as fact inner join tbl_Registros_de_Pacientes as pacientes
            on pacientes.Cod_paciente = fact.cod_paciente where fact.Cod_Facturacion Like '%' + '{numeroFactura}' + '%' and fact.Estado = 1";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable Read()
        {
            string query = $@"Select fact.Cod_Facturacion as 'Codigo',pacientes.Nombre,Convert(date,fact.Fecha_Actual) as 'Fecha',fact.SubTotal,fact.Total,
            Convert(date,fact.Fecha_de_Entrega) as 'Fecha de Entrega',fact.Hora_de_Entrega as 'Hora de Entrega',fact.Estado From tbl_Facturacion as fact inner join tbl_Registros_de_Pacientes as pacientes
            on pacientes.Cod_paciente = fact.cod_paciente where fact.Estado = 1";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public DataTable ReadForId(int NumeroRuc)
        {
            string sql = $@"Select examen.nombre as 'Examenes',examen.precio as 'Precio'
From tbl_Facturacion as facturas inner join tbl_Detalle_Facturacion as detalles 
on  detalles.Cod_Factura = facturas.Cod_Facturacion inner join tbl_Registros_de_Pacientes as pacientes
on pacientes.Cod_paciente = facturas.cod_paciente inner join tbl_Examen as examen
on detalles.Cod_Examen = examen.cod_examen where facturas.Cod_Facturacion = '{NumeroRuc}'";

            command = new SqlCommand(sql, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public void UpdateEstado(int NumeroRuc)
        {
            string query = $@"Update tbl_Facturacion set Estado = 0 where Cod_Facturacion = '{NumeroRuc}' ";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DateTime CargarFechaEntrega(int NumeroRuc)
        {
            List<Facturacion_list> lista = new List<Facturacion_list>();

            string query = $@"select Fecha_de_Entrega From tbl_Facturacion where  Cod_Facturacion = @NumeroRuc";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.Parameters.Add(new SqlParameter("@NumeroRuc", NumeroRuc));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Verificar si la columna existe antes de intentar leerla
                    if (reader.HasRows)
                    {
                        lista.Add(new Facturacion_list
                        {
                           Fecha_de_Entrega = Convert.ToDateTime(reader["Fecha_de_Entrega"])
                        });
                    }
                }
            }
            conexion.cerrarconexion();

            return lista.FirstOrDefault().Fecha_de_Entrega;
        }
        public DateTime CargarHoraEntrega(int NumeroRuc)
        {
            List<Facturacion_list> lista = new List<Facturacion_list>();

            string query = $@"select Hora_de_Entrega From tbl_Facturacion where  Cod_Facturacion = @NumeroRuc";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.Parameters.Add(new SqlParameter("@NumeroRuc", NumeroRuc));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Verificar si la columna existe antes de intentar leerla
                    if (reader.HasRows)
                    {
                        lista.Add(new Facturacion_list
                        {
                            HoradeEntrega = Convert.ToDateTime(reader["Hora_de_Entrega"].ToString())
                        });
                    }
                }
            }
            conexion.cerrarconexion();

            return lista.FirstOrDefault().HoradeEntrega;
        }
    }
}
