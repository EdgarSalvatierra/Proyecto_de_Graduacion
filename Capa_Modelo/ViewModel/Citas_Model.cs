using Capa_Datos.Data.Citas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Citas_Model
    {
        CitasData citas = new CitasData();

        public void InsertarCitas(string nombre,string apellido,DateTime Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora)
        {
            citas.Insertar(nombre, apellido,Nacimiento, telefono, motivo, fecha, hora);
        }
        public Object LeerCitas()
        {
            return citas.Read();
        }
        public Object Search(string Paciente, long Telefono)
        {
            return citas.Buscador(Paciente, Telefono);
        }
        public void ActualizarCitas(int cod_cita, string nombre, DateTime Nacimiento, long telefono, string motivo, DateTime fecha, DateTime hora)
        {
            citas.Update(nombre, Nacimiento, telefono, motivo, fecha, hora, cod_cita);
        }
        public void EliminarCitas(int cod_cita)
        {
            citas.Delete(cod_cita);
        }
    }
}
