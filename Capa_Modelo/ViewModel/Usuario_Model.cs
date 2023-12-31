﻿using Capa_Datos.Data.Usuario;
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

        public void InsertarUsuario(string usuario, string contraseña, string Roles)
        {
            usuariot.InsertarUsuario(usuario,contraseña,Roles);
        }
        public void InsertarDetalles(string usuario,string Nombre, string Apellido, DateTime Nacimento, long Telefono)
        {
            usuariot.InsertarDetalles(usuario,Nombre,Apellido,Nacimento,Telefono);
        }
        public Object LeerUsuario()
        {
            return usuariot.Read();
        }
        public string CargarElUsuario(string Usuario)
        {
            return usuariot.CargarUsuario(Usuario);
        }
        public bool InicioSesion(string Usuario, string Contraseña)
        {
            return usuariot.Login(Usuario, Contraseña);
        }
        public Object LeerUsuarioporId(string Nombre, string Roles)
        {
            return usuariot.ReadForId(Nombre, Roles);
        }
        public void ActualizarUsuario(int cod_user, string usuario, string contraseña, string Nombre, int Edad,long Telefono,string Roles)
        {
            usuariot.Update(cod_user, usuario, contraseña, Nombre, Edad,Telefono,Roles);
        }
        public void DardebajaUsuario(string usuario)
        {
            usuariot.Off(usuario);
        }
    }
}
