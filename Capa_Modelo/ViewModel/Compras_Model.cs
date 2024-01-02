using Capa_Datos.Data.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    internal class Compras_Model
    {
        ComprasData compras = new ComprasData();
        public void InsertarPedidos(string Nom_Producto, decimal Precio, int Cantidad, decimal SubTotal, decimal Total, string Proveedor)
        {
            compras.Insert(Nom_Producto,Precio,Cantidad,SubTotal,Total,Proveedor);
        }
        public Object LeerPedidos()
        {
            return compras.Read();
        }
        public Object LeerPedidosporNombre(string Proveedor, string Producto)
        {
            return compras.ReadForName(Proveedor,Producto);
        }
        public void EliminarPedidos(int Codigo)
        {
            compras.Delete(Codigo);
        }
    }
}
