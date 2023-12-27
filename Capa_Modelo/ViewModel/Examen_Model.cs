using Capa_Datos.Data.Examenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Examen_Model
    {
        ExamenesData examenes = new ExamenesData();

        public void InsertarExamenes(int cod_area, string nombre, decimal precio)
        {
            examenes.Insertar(cod_area, nombre, precio);
        }
        public Object LeerExamen()
        {
            return examenes.Read();
        }
        public Object BuscarporExamen(string Examen)
        {
            return examenes.BuscarporExamen(Examen);
        }
        public Object Cargar()
        {
            return examenes.CargarDatos();
        }
        public void ActualizarExamen(int cod_categoria, string nombre, decimal precio)
        {
            examenes.Update(cod_categoria, nombre, precio);
        }
        public void EliminarExamen(int codcategoria)
        {
            examenes.Delete(codcategoria);
        }
    }
}
