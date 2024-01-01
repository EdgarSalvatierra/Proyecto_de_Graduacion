using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Compras
{
    public class ComprasData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Cod_Pedidos)
        {
            command = new SqlCommand("Ms_Pedidos_Detalles_Delete", conexion.abrirconexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Pedidos", Cod_Pedidos));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Insert(string Nom_Producto, decimal Precio, int Cantidad, decimal SubTotal, decimal Total, string Proveedor)
        {
            command = new SqlCommand("Ms_Pedidos_Detalle_Pedidos_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Nom_Producto", Nom_Producto));

            command.Parameters.Add(new SqlParameter("@Precio", Precio));

            command.Parameters.Add(new SqlParameter("@Cantidad", Cantidad));

            command.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));

            command.Parameters.Add(new SqlParameter("@Total", Total));

            command.Parameters.Add(new SqlParameter("@Nom_Proveedor", Proveedor)););

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            command = new SqlCommand("Ms_Pedidos_Detalles_Read", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }
        public void Update(int Cod_Pedidos, string Nom_Producto, decimal Precio, int Cantidad, decimal SubTotal, decimal Total)
        {
            command = new SqlCommand("Ms_Pedidos_Detalles_Update", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Pedidos", Cod_Pedidos));

            command.Parameters.Add(new SqlParameter("@Nom_Producto", Nom_Producto));

            command.Parameters.Add(new SqlParameter("@Precio", Precio));

            command.Parameters.Add(new SqlParameter("@Cantidad", Cantidad));

            command.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));

            command.Parameters.Add(new SqlParameter("@Total", Total));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
