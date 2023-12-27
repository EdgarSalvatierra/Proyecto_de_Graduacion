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

        public void Insertar(string usuario, string contraseña, string Nombre, string Apellido, long telefono, DateTime Nacimento, string Roles)
        {
            string query = $@"declare @cod_usuario int declare @IdRol int
             set @IdRol = (select Nom_Roles From tbl_Roles where  Nom_Roles = @Nom_Roles)
             insert into tbl_User(Usuario,Contraseña,IdRol)
             values('{usuario}',{contraseña},@IdRol)

            set @cod_usuario = @@IDENTITY

            insert into tbl_Detalles_Usuario(Cod_User,Nombre,Apellido,Fecha_de_Nacimiento,Telefono)
            values(@cod_usuario,'{Nombre}','{Apellido}','{Nacimento.Date}','{telefono}')";


            command = new SqlCommand(query, conexion.abrirconexion());

            command.ExecuteNonQuery();

            conexion.cerrarconexion();
        }
        public DataTable Read()
        {
            string query = $@"select Codigo_Usuario as 'Codigo',detalles.Fecha_de_Nacimiento as 'Nacimiento',detalles.Nombre + ' ' + detalles.Apellido as 'Nombre Completo',detalles.Edad,detalles.Telefono,
                           us.Usuario,us.Contraseña,rol.Nom_Roles as 'Roles de Usuario', us.Estado as 'Estado'
                           From tbl_Detalles_Usuario as detalles inner join tbl_User as us on us.Cod_User= detalles.Cod_User
                           inner join tbl_Roles as rol on rol.cod_rol = us.IdRol";

            command = new SqlCommand(query, conexion.abrirconexion());

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable data = new DataTable();

            adapter.Fill(data);

            conexion.cerrarconexion();

            return data;
        }

        public DataTable ReadForId(int Codigo, string Usuario, string Nombre, string Roles)
        {
            string query = $@"select Codigo_Usuario as 'Codigo',detalles.Fecha_de_Nacimiento as 'Nacimiento',detalles.Nombre,detalles.Apellido,detalles.Edad,detalles.Telefono,
us.Usuario,us.Contraseña,rol.Nom_Roles as 'Roles de Usuario'
From tbl_Detalles_Usuario as detalles 
inner join tbl_User as us on us.Cod_User = detalles.Cod_User
inner join tbl_Roles as rol on rol.cod_rol = us.IdRol

where us.Cod_User Like '%'+ '{Codigo}'+ '%' or us.Usuario Like '%' + '{Usuario}' + '%' 
or detalles.Nombre Like '%' + '{Nombre}' + '%' or rol.Nom_Roles Like '%' + '{Roles}' + '%'";

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
       
        public void Update(int cod_user, string usuario, string contraseña, string Nombre, string Apellido)
        {
            command = new SqlCommand("sp_usuario_update", conexion.abrirconexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@cod_user", cod_user));

            command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

            command.Parameters.Add(new SqlParameter("@Apellido", Apellido));

            command.Parameters.Add(new SqlParameter("@Usuario", usuario));

            command.Parameters.Add(new SqlParameter("@Password", contraseña));

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
            string query = $@"if(exists(select * From tbl_User where Usuario = '{Usuario}' and Contraseña = '{Contraseña}'))
                            Select Cod_User From tbl_User where Usuario = '{Usuario}' and Contraseña = '{Contraseña}'
                   else 
                     select '0'
               ";

            command = new SqlCommand(query,conexion.abrirconexion());

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
    }
}
