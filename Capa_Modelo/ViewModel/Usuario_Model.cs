using Capa_Datos.Data.Usuario;
using Capa_Datos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Usuario_Model
    {
        UsuarioData usuariot = new UsuarioData();

        public void InsertarUsuario(string usuario, string contraseña, string Nombre, string Apellido, long telefono, DateTime Nacimento, string Roles)
        {
            usuariot.Insertar(usuario, contraseña, Nombre, Apellido, telefono, Nacimento, Roles);
        }
        public Object LeerUsuario()
        {
            return usuariot.Read();
        }
        public bool InicioSesion(string Usuario, string Contraseña)
        {
            return usuariot.Login(Usuario, Contraseña);
        }
        public Object LeerUsuarioporId(int Codigo, string Usuario, string Nombre, string Roles)
        {
            return usuariot.ReadForId(Codigo, Usuario, Nombre, Roles);
        }
        public void ActualizarUsuario(int cod_user, string usuario, string contraseña, string Nombre, string Apellido)
        {
            usuariot.Update(cod_user, usuario, contraseña, Nombre, Apellido);
        }
        public void DardebajaUsuario(string usuario)
        {
            usuariot.Off(usuario);
        }
    }
}
