using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Dashboard
    {
        ConexionSql conexion = new ConexionSql();
        public SqlCommand command;
        public DataTable data;
        public SqlDataReader reader;

        public DateTime fechainicio;
        public DateTime fechafinal;
        public int numerodias;

        public struct revenuedate
        {
            public string date { get; set; }
            public decimal totalA { get; set; }
        }

        public int numerocli { get; private set; }

        public List<revenuedate> iblist { get; private set; }
        public int numorder { get; set; }
        public decimal totalreve { get; set; }
        public decimal totalprof { get; set; }

        //metodos 

        private void getitems()//metodo para contar los rejistros
        {

            command = new SqlCommand("select count(Cod_paciente) from tbl_Registros_de_Pacientes", conexion.abrirconexion());
            numerocli = (int)command.ExecuteScalar();
            conexion.cerrarconexion();


            command = new SqlCommand(@"select count(Cod_Facturacion) from tbl_Facturacion where Fecha_Actual between @fromDate and @todate ", conexion.abrirconexion());
            command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = fechainicio;
            command.Parameters.Add("@Todate", System.Data.SqlDbType.DateTime).Value = fechafinal;
            numorder = (int)command.ExecuteScalar();
            conexion.cerrarconexion();

        }
        private void getAnalisisfact()
        {
            iblist = new List<revenuedate>();
            totalprof = 0;
            totalreve = 0;


            command = new SqlCommand("select Fecha_actual, sum(total) from tbl_Facturacion where Fecha_Actual between @fromdate and @todate group by Fecha_Actual", conexion.abrirconexion());
            command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = fechainicio;
            command.Parameters.Add("@Todate", System.Data.SqlDbType.DateTime).Value = fechafinal;
            var reader = command.ExecuteReader();

            var resultTable = new List<KeyValuePair<DateTime, decimal>>();
            while (reader.Read())
            {
                resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));

                totalreve += (decimal)reader[1];
            }
            totalprof = totalreve * 0.7m;
            reader.Close();
            conexion.cerrarconexion();
            // por horas
            if (numerodias <= 1)
            {
                iblist = (from orderList in resultTable
                          group orderList by orderList.Key.ToString("hh tt")
                into order
                          select new revenuedate
                          {
                              date = order.Key,
                              totalA = order.Sum(amount => amount.Value)
                          }).ToList();
            }
            //agrupado por dias
            else if (numerodias < 30)
            {
                foreach (var item in resultTable)
                {
                    iblist.Add(new revenuedate()
                    {
                        date = item.Key.ToString("dd MMM"),
                        totalA = item.Value
                    });
                }
            }
            //agrupacion por semanas
            else if (numerodias < 92)
            {
                iblist = (from orderlist in resultTable
                          group orderlist by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(orderlist.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                        into order
                          select new revenuedate
                          {
                              date = "Week" + order.Key.ToString(),
                              totalA = order.Sum(amount => amount.Value)
                          }).ToList();
            }
            //por mes
            else if (numerodias < (365 * 2))
            {
                bool isYear = numerodias < 365 ? true : false;
                iblist = (from orderlist in resultTable
                          group orderlist by orderlist.Key.ToString("MMM yyyy")
                              into order
                          select new revenuedate
                          {
                              date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                              totalA = order.Sum(amount => amount.Value)
                          }).ToList();

            }

            //por año
            else
            {
                iblist = (from orderList in resultTable
                          group orderList by orderList.Key.ToString("yyyy")
                                          into order
                          select new revenuedate
                          {
                              date = order.Key,
                              totalA = order.Sum(amount => amount.Value)
                          }).ToList();
            }

        }
        public bool LoadData(DateTime fechainicio, DateTime fechafinal)
        {
            fechafinal = new DateTime(fechafinal.Year, fechafinal.Month, fechafinal.Day, fechafinal.Hour, fechafinal.Minute, 59);
            if (fechainicio != this.fechainicio || fechafinal != this.fechafinal)
            {
                this.fechainicio = fechainicio;
                this.fechafinal = fechafinal;
                this.numerodias = (fechafinal - fechainicio).Days;

                getAnalisisfact();
                getitems();
                Console.WriteLine("Refreshed data: {0} - {1}", fechainicio.ToString(), fechafinal.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", fechainicio.ToString(), fechafinal.ToString());
                return false;
            }

        }
    }
}
