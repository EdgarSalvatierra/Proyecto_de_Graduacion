using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Capa_Datos.Model;
using System.Collections;

namespace Capa_Datos.Data.Usuario
{
    public class UsuarioData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void InsertarUsuario(string usuario, string contraseña, string Roles)
        {
            command = new SqlCommand("sp_usuario_insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));

            command.Parameters.Add(new SqlParameter("@Password", contraseña));

            command.Parameters.Add(new SqlParameter("@Nom_Roles", Roles));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void InsertarDetalles(string usuario, string Nombre, string Apellido, DateTime Nacimento, long Telefono)
        {
            command = new SqlCommand("Sp_Detalles_Insert", conexion.abrirconexion());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Apellido", Apellido));

            command.Parameters.Add(new SqlParameter("@Fecha_de_Nacimiento", Nacimento));

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));

            command.Parameters.Add(new SqlParameter("@Telefono", Telefono));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            string query = $@"select us.Cod_User as 'Codigo',detalles.Nombre + ' ' + detalles.Apellido as 'Nombre',detalles.Edad,detalles.Telefono,
                           us.Usuario,us.Contraseña,rol.Nom_Roles as 'Roles de Usuario', us.Estado as 'Estado'
                           From tbl_Detalles_Usuario as detalles inner join tbl_User as us on us.Cod_User= detalles.Cod_User
                           inner join tbl_Roles as rol on rol.cod_rol = us.IdRol where us.Estado = 1";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }

        public DataTable ReadForId(string Roles, string Nombre)
        {
            string query = $@"select us.Cod_User as 'Codigo',detalles.Nombre + ' ' + detalles.Apellido as 'Nombre',detalles.Edad,detalles.Telefono,
us.Usuario,us.Contraseña,rol.Nom_Roles as 'Roles de Usuario',us.Estado as 'Estado' From tbl_Detalles_Usuario as detalles 
inner join tbl_User as us on us.Cod_User = detalles.Cod_User
inner join tbl_Roles as rol on rol.cod_rol = us.IdRol where rol.Nom_Roles Like '%' + '{Roles}' + '%' or detalles.Nombre Like '%' + '{Nombre}' + '%' and us.Estado = 1";

            command = new SqlCommand(query, conexion.abrirconexion());

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

        public void Update(int cod_user, string usuario, string contraseña, string Nombre, int Edad, long Telefono, string Roles)
        {
            command = new SqlCommand("sp_usuario_update", conexion.abrirconexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_user", cod_user));

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Edad", Edad));

            command.Parameters.Add(new SqlParameter("@Telefono", Telefono));

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));

            command.Parameters.Add(new SqlParameter("@Password", contraseña));

            command.Parameters.Add(new SqlParameter("@Nom_Roles", Roles));

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public void Off(string Usuario)
        {
            string query = $@"Update tbl_User Set Estado = 0 where Usuario = '{Usuario}'";

            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public bool Login(string Usuario, string Contraseña)
        {
            string query = $@"if(exists(select * From tbl_User where Usuario = '{Usuario}' and Contraseña = '{Contraseña}' and Estado = 1))
                            Select Cod_User From tbl_User where Usuario = '{Usuario}' and Contraseña = '{Contraseña}' and Estado = 1
                   else 
                     select '0'
               ";

            command = new SqlCommand(query, conexion.abrirconexion());

            int IdUsuario = Convert.ToInt32(command.ExecuteScalar().ToString());

            if (IdUsuario != 0)
            {
                return true;
            }
            else
            {
                conexion.cerrarconexion();
                return false;
            }
        }
        public static string ConvertirSha256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
        public string CargarUsuario(string usuario)
        {
            List<Detalle_Usuario> lista = new List<Detalle_Usuario>();

            string query = @"SELECT detalles.Nombre + ' ' + detalles.Apellido AS NombreCompleto 
                    FROM tbl_Detalles_Usuario AS detalles 
                    INNER JOIN tbl_User AS us ON us.Cod_User = detalles.Cod_User 
                    WHERE us.Usuario = @Usuario";

            using (SqlConnection connection = conexion.abrirconexion())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Verificar si la columna existe antes de intentar leerla
                            if (reader.HasRows)
                            {
                                lista.Add(new Detalle_Usuario
                                {
                                    Nombre = reader["NombreCompleto"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            return lista.FirstOrDefault()?.Nombre;
        }
    }
}
