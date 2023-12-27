using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Conexion
{
    public class ConexionSql
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=DBLaboratory;Integrated Security=True");

        public SqlConnection abrirconexion()
        {
            con.Open();

            return con;
        }
        public SqlConnection cerrarconexion()
        {
            con.Close();

            return con;
        }
    }
}
