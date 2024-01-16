using Capa_Datos.Data.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public class Compras_Model
    {
        ComprasData compras = new ComprasData();

        public void InsertarPedidos(string Producto, decimal SubTotal, decimal Total,string usuario)
        {
            compras.InsertPedidos(Producto,SubTotal,Total,usuario);
        }
        public void InsertarDetallePedidos(string Producto, decimal Precio, int Cantidad, decimal SubTotal, decimal Total,string usuario)
        {
            compras.InsertDetallePedidos(Producto,Precio,Cantidad,SubTotal,Total,usuario);
        }
        public Object LeerPedidos()
        {
            return compras.Read();
        }
        public Object LeerPedidosporNombre(string Proveedor, string Producto)
        {
            return compras.ReadForName(Proveedor,Producto);
        }
        public void DarDebaja(int Codigo)
        {
            compras.OffEstado(Codigo);
        }
        public void EliminarPedidos(int Codigo)
        {
            compras.Delete(Codigo);
        }
    }
}
