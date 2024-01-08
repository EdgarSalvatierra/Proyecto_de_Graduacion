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

        public void InsertarPacientes(string Nombre, string Apellido, long telefono, DateTime FechadeNacimiento, string sexo)
        {
            paciente.Insert(Nombre,Apellido ,telefono, FechadeNacimiento, sexo);
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
        public int CargarEdad(string Nombre)
        {
            return paciente.CargarPacienteEdad(Nombre);
        }
        public string CargarSexo(string Nombre)
        {
            return paciente.CargarPacienteSexo(Nombre);
        }
        public long CargarTelefono(string Nombre)
        {
            return paciente.CargarPacienteTelefono(Nombre);
        }
        public void ActualizarEstado(DateTime Numero)
        {
            paciente.UpdateEstado(Numero);
        }
        public void EliminarPacientes(int id)
        {
            paciente.Delete(id);
        }
    }
}
