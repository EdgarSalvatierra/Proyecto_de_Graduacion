﻿using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Capa_Datos.Model;

namespace Capa_Datos.Data.Proveedores
{
    public class ProveedorData
    {
        ConexionSql conexion = new ConexionSql();

        SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Cod_Proveedor)
        {
            command = new SqlCommand("Sp_Proveedor_Delete", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("Cod_Proveedor", Cod_Proveedor));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void InsertarProveedor(string Nombre, string Casa_Comercial)
        {
            try
            {
                command = new SqlCommand("Sp_Proveedor_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                command.Parameters.Add(new SqlParameter("@Casa_Comercial", Casa_Comercial));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void InsertarProducto(string Producto, decimal Precio, string Nombre)
        {
            try
            {
                command = new SqlCommand("Sp_Producto_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Producto", Producto));

                command.Parameters.Add(new SqlParameter("@Precio", Precio));

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable CargarListaComercial()
        {
            try
            {
                command = new SqlCommand("Sp_Cargar_Proveedor_ok", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                dataAdapter.SelectCommand = command;

                DataTable data = new DataTable();

                dataAdapter.Fill(data);

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable CargarProducto(int casacomercial)
        {
            try
            {
                command = new SqlCommand("Sp_Cargar_Producto_Comercial", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Codigo", casacomercial));

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
        public decimal CargarPrecio(int Codigo)
        {
            try
            {
                List<Productos> lista = new List<Productos>();

                string query = $@"Select Precio From tbl_Producto where Codigo = @Codigo";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Codigo", Codigo));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verificar si la columna existe antes de intentar leerla
                        if (reader.HasRows)
                        {
                            lista.Add(new Productos
                            {
                                Precio = Convert.ToDecimal(reader["Precio"])
                            });
                        }
                    }
                }
                return lista.FirstOrDefault().Precio;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public string CargarProveedor(int Codigo)
        {
            List<ProveedoresClass> lista = new List<ProveedoresClass>();

            string query = $@"Select Nombre From tbl_Proveedor as proveedor
                            inner join tbl_Producto as product on proveedor.Cod_Proveedor = product.Cod_Proveedor
                            where product.Codigo = @Codigo";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.Parameters.Add(new SqlParameter("@Codigo", Codigo));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Verificar si la columna existe antes de intentar leerla
                    if (reader.HasRows)
                    {
                        lista.Add(new ProveedoresClass
                        {
                            Proveedor = reader["Nombre"].ToString()
                        });
                    }
                }
            }

            conexion.cerrarconexion();

            return lista.FirstOrDefault()?.Proveedor;
        }
        public string CargarCasaComercial(int Codigo)
        {
            List<ProveedoresClass> lista = new List<ProveedoresClass>();

            string query = $@"Select Casa_Comercial From tbl_Proveedor as proveedor
                            inner join tbl_Producto as product on proveedor.Cod_Proveedor = product.Cod_Proveedor
                            where product.Codigo = @Codigo";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.Parameters.Add(new SqlParameter("@Codigo", Codigo));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Verificar si la columna existe antes de intentar leerla
                    if (reader.HasRows)
                    {
                        lista.Add(new ProveedoresClass
                        {
                            Casa_Comercial = reader["Casa_Comercial"].ToString()
                        });
                    }
                }
            }
            conexion.cerrarconexion();

            return lista.FirstOrDefault()?.Casa_Comercial;
        }
        public DataTable Read()
        {
            try
            {
                command = new SqlCommand("Sp_Proveedor_Read", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                dataAdapter.SelectCommand = command;

                DataTable data = new DataTable();

                dataAdapter.Fill(data);

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable Search(string buscador)
        {
            command = new SqlCommand("Sp_Proveedor_ReadId", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Proveedor", Convert.ToInt32(buscador)));

            command.Parameters.Add(new SqlParameter("@Casacomercial", buscador));

            command.Parameters.Add(new SqlParameter("@Proveedor", buscador));

            command.Parameters.Add(new SqlParameter("@Producto", buscador));

            DataTable data = new DataTable();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                data.Load(reader);
            }
            else
            {
                conexion.cerrarconexion();
            }

            conexion.cerrarconexion();

            return data;
        }
        public void Update(int Cod_Proveedor, string Nombre, string Casa_Comercial)
        {
            command = new SqlCommand("Sp_Proveedor_Update", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Cod_Proveedor", Cod_Proveedor));

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Casa_Comercial", Casa_Comercial));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
    }
}
