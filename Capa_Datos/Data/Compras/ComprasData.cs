﻿using Capa_Datos.Data.Conexion;
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
            try
            {
                command = new SqlCommand("Ms_Pedidos_Detalles_Delete", conexion.abrirconexion());

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Codigo", Cod_Pedidos));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void InsertPedidos(string Producto, decimal SubTotal, decimal Total,string Usuario)
        {
            try
            {
                command = new SqlCommand("Sp_Pedidos_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Producto", Producto));

                command.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));

                command.Parameters.Add(new SqlParameter("@Total", Total));

                command.Parameters.Add(new SqlParameter("@Usuario", Usuario));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void InsertDetallePedidos(string Producto,decimal Precio,int Cantidad,decimal SubTotal,decimal Total,string Usuario)
        {
            try
            {
                command = new SqlCommand("Ms_Pedidos_Detalle_Pedidos_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Producto", Producto));

                command.Parameters.Add(new SqlParameter("@Precio", Precio));

                command.Parameters.Add(new SqlParameter("@Cantidad", Cantidad));

                command.Parameters.Add(new SqlParameter("@SubTotal", SubTotal));

                command.Parameters.Add(new SqlParameter("@Total", Total));

                command.Parameters.Add(new SqlParameter("@Usuario", Usuario));

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
                command = new SqlCommand("Ms_Pedidos_Detalles_Read", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

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
        public DataTable ReadForName(string Proveedor, string Producto)
        {
            try
            {
                command = new SqlCommand("Ms_Pedidos_Detalles_ReadForName", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@proveedor", Proveedor));

                command.Parameters.Add(new SqlParameter("@Nom_Producto", Producto));

                DataTable data = new DataTable();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    data.Load(reader);
                }

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void OffEstado(int CodigoPedidos)
        {
            try
            {
                string query = $@"Update tbl_Pedidos set Estado = 0 where Cod_Pedidos = '{CodigoPedidos}'";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
    }
}
