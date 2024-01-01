using Capa_Datos.Data.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Proveedor_Model
    {
        ProveedorData Proveedor = new ProveedorData();

        public void InsertarProveedor(string Nombre, string Casa_Comercial)
        {
            Proveedor.Insertar(Nombre, Casa_Comercial);
        }
        public void LeerProveedor()
        {
            Proveedor.Read();
        }
        public void LeerProveedorporId(int Cod_Proveedor)
        {
            Proveedor.ReadId(Cod_Proveedor);
        }
        public void ActualizarProveedor(int Cod_Proveedor, string Nombre, string Casa_Comercial)
        {
            Proveedor.Update(Cod_Proveedor, Nombre, Casa_Comercial);
        }
        public void EliminarProveedor(int Cod_Proveedor)
        {
            Proveedor.Delete(Cod_Proveedor);
        }
    }
}
