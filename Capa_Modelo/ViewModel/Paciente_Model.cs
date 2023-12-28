using Capa_Datos.Data.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Paciente_Model
    {
        PacienteData paciente = new PacienteData();

        public void InsertarPacientes(string Nombre, long telefono, DateTime fecha, string sexo)
        {
            paciente.Insert(Nombre, telefono, fecha, sexo);
        }
        public Object LeerPacientes()
        {
            return paciente.Read();
        }
        public Object CargarPacientes()
        {
            return paciente.CargarDatos();
        }
        public Object LeerPacientesporId(string Codigo)
        {
            return paciente.ReadForName(Codigo);
        }
        public void ActualizarPacientes(int id, string Nombre, long telefono, DateTime fecha, string sexo, string correo)
        {
            paciente.Update(id, Nombre, fecha, telefono, sexo, correo);
        }
        public void EliminarPacientes(int id)
        {
            paciente.Delete(id);
        }
    }
}
