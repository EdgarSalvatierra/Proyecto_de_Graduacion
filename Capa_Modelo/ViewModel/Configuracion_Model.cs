using Capa_Datos.Data.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Configuracion_Model
    {
        ConfiguracionData configuracion = new ConfiguracionData();
        public void InsertarEntidad(string Nombre, string Administrador, long Telefono, string ubicacion, string Ciudad)
        {
            configuracion.InsertEntidad(Nombre,Administrador,Telefono,ubicacion,Ciudad);
        }
        public string GetNombre()
        {
            return configuracion.CargarNombre();
        }
        public string GetAdministrador()
        {
            return configuracion.CargarAdministrador();
        }
        public long GetTelefono()
        {
            return configuracion.CargarTelefono();
        }
        public string GetUbicacion()
        {
            return configuracion.CargaUbicacion();
        }
        public string GetCiudad()
        {
            return configuracion.CargarCiudad();
        }
        public void ActualizarEntidad(string Nombre, string Administrador, long Telefono, string ubicacion, string Ciudad)
        {
            configuracion.Update(Nombre,Administrador,Telefono,ubicacion,Ciudad);
        }
    }
}
