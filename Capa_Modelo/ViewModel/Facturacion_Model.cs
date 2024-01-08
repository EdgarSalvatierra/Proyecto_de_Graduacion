using Capa_Datos.Data.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
   public class Facturacion_Model
   {
        FacturacionData facturas = new FacturacionData();

        public void InsertarFacturas(int codigopaciente, int numeroruc, decimal SubTotal, decimal Total, DateTime Fecha_de_entrega, DateTime Hora_de_entrega)
        {
            facturas.InsertFactura(codigopaciente, numeroruc, SubTotal, Total, Fecha_de_entrega, Hora_de_entrega);
        }
        public void InsertarDetallesFacturas(decimal Precio, int numeroruc, string codigoexamen, decimal SubTotal, decimal Total)
        {
            facturas.InsertDetalles(Precio, numeroruc, codigoexamen, SubTotal, Total);
        }
        public Object LeerFacturas()
        {
            return facturas.Read();
        }
        public Object LeerFacturasporId(int numeroruc)
        {
            return facturas.ReadForId(numeroruc);
        }
        public DateTime CargarFecha(int numeroruc)
        {
            return facturas.CargarFechaEntrega(numeroruc);
        }
        public DateTime CargarHora(int numeroruc)
        {
            return facturas.CargarHoraEntrega(numeroruc);
        }
        public Object BuscarFacturas(int numeroFactura)
        {
            return facturas.BuscarporNumeroFactura(numeroFactura);
        }
        public void ActualizarFacturas(int NumeroRuc)
        {
            facturas.UpdateEstado(NumeroRuc);
        }
        public void EliminarFacturas(int Cod_Factura)
        {
            facturas.Delete(Cod_Factura);
        }
    }
}
