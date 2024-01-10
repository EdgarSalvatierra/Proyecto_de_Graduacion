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
            Proveedor.InsertarProveedor(Nombre, Casa_Comercial);
        }
        public void InsertarProducto(string Producto, decimal Precio, string Nombre)
        {
            Proveedor.InsertarProducto(Producto, Precio, Nombre);
        }
        public Object LeerProveedor()
        {
            return Proveedor.Read();
        }
        public Object LeerProveedorporId(string buscar)
        {
            return Proveedor.Search(buscar);
        }
        public Object CargarProductos()
        {
            return Proveedor.CargarProducto();
        }
        public string CargarProveedor(int Codigo)
        {
            return Proveedor.CargarProveedor(Codigo);
        }
        public string CargarCasa(int Codigo)
        {
            return Proveedor.CargarCasaComercial(Codigo);
        }
        public decimal CargarPrecio(int Codigo)
        {
            return Proveedor.CargarPrecio(Codigo);
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
