using Capa_Datos.Data.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Categoria_Model
    {
        CategoriaData categorias = new CategoriaData();

        public void InsertarCategoria(string categoria_examen)
        {
            categorias.Insert(categoria_examen);
        }
        public Object LeerCategoria()
        {
            return categorias.Read();
        }
        public Object LeerCategoriaporId(string cod_area)
        {
            return categorias.ReadId(cod_area);
        }
        public void ActualizarCategoria(int cod_area, string categoria_examen)
        {
            categorias.Update(cod_area, categoria_examen);
        }
        public void EliminarCategoria(int cod_area)
        {
            categorias.Delete(cod_area);
        }
    }
}
