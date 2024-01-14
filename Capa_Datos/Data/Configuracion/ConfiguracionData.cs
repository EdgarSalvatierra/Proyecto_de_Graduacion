using Capa_Datos.Data.Conexion;
using Capa_Datos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Data.Configuracion
{
    public class ConfiguracionData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void InsertEntidad(string Nombre, string Administrador, long Telefono, string ubicacion, string Ciudad)
        {
            try
            {
                string query = $@"Insert into tbl_Informacion_Entidad(Codigo_Configuracion,Nombre,Administrador_Actual,Telefono,Ubicacion,Ciudad,Fecha_Actualizacion)
                           values(1,@Nombre,@Administrador,@Telefono,@ubicacion,@ciudad,GetDate())";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                command.Parameters.Add(new SqlParameter("@Administrador", Administrador));

                command.Parameters.Add(new SqlParameter("@Telefono", Telefono));

                command.Parameters.Add(new SqlParameter("@ubicacion", ubicacion));

                command.Parameters.Add(new SqlParameter("@ciudad", Ciudad));

                command.ExecuteNonQuery();
            }
            finally
            {
               conexion.cerrarconexion();
            }
        }
        public string CargarNombre()
        {
            try
            {
                List<Informacion_Entidad> lista = new List<Informacion_Entidad>();

                string query = $@"select Nombre From tbl_Informacion_Entidad";

                command = new SqlCommand(query, conexion.abrirconexion());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Informacion_Entidad
                    {
                        Nombre = reader["Nombre"].ToString()
                    });
                }
                return lista.FirstOrDefault()?.Nombre;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public string CargarAdministrador()
        {
            try
            {
                List<Informacion_Entidad> lista = new List<Informacion_Entidad>();

                string query = $@"select Administrador_Actual From tbl_Informacion_Entidad";

                command = new SqlCommand(query, conexion.abrirconexion());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Informacion_Entidad
                    {
                        Administrador_Actual = reader["Administrador_Actual"].ToString()
                    });
                }
                return lista.FirstOrDefault()?.Administrador_Actual;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public long CargarTelefono()
        {
            try
            {
                List<Informacion_Entidad> lista = new List<Informacion_Entidad>();

                string query = $@"select Telefono From tbl_Informacion_Entidad";

                command = new SqlCommand(query, conexion.abrirconexion());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Informacion_Entidad
                    {
                        Telefono = Convert.ToInt64(reader["Telefono"])
                    });
                }
                return lista.FirstOrDefault().Telefono;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public string CargaUbicacion()
        {
            try
            {
                List<Informacion_Entidad> lista = new List<Informacion_Entidad>();

                string query = $@"select Ubicacion From tbl_Informacion_Entidad";

                command = new SqlCommand(query, conexion.abrirconexion());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Informacion_Entidad
                    {
                        ubicacion = reader["Ubicacion"].ToString()
                    });
                }
                return lista.FirstOrDefault()?.ubicacion;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public string CargarCiudad()
        {
            try
            {
                List<Informacion_Entidad> lista = new List<Informacion_Entidad>();

                string query = $@"select Ciudad From tbl_Informacion_Entidad";

                command = new SqlCommand(query, conexion.abrirconexion());

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Informacion_Entidad
                    {
                        ciudad = reader["Ciudad"].ToString()
                    });
                }

                return lista.FirstOrDefault()?.ciudad;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void Update(string Nombre, string Administrador, long Telefono, string ubicacion, string Ciudad)
        {
            try
            {
                string query = $@"declare @Codigo int;
                            
                           set @Codigo = (Select Codigo From tbl_Informacion_Entidad where Fecha_Actualizacion = @Fecha_Actualizacion) 

                           Update tbl_Informacion_Entidad set Nombre = @Nombre, Administrador = @Administrador, Telefono = @Telefono, 
                           Ubicacion = @ubicacion,Ciudad = @ciudad where Codigo = @Codigo";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                command.Parameters.Add(new SqlParameter("@Administrador", Administrador));

                command.Parameters.Add(new SqlParameter("@Telefono", Telefono));

                command.Parameters.Add(new SqlParameter("@ubicacion", ubicacion));

                command.Parameters.Add(new SqlParameter("@ciudad", Ciudad));

                command.ExecuteNonQuery();
            }
            finally 
            {
                conexion.cerrarconexion();
            }
        }
    }
}
