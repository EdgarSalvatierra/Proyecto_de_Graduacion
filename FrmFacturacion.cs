using Capa_Modelo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class FrmFacturacion : Form
    {
        Facturacion_Model Facturacion = new Facturacion_Model();

        ErrorProvider error = new ErrorProvider();
        public FrmFacturacion()
        {
            InitializeComponent();
        }
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
           DtgFactura.DataSource = Facturacion.LeerFacturas();
        }
        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBuscarFactura.Text))
            {
                if (int.TryParse(TxtBuscarFactura.Text, out _))
                {
                    int CodigoFactura = Convert.ToInt32(TxtBuscarFactura.Text);

                    DtgFactura.DataSource = Facturacion.BuscarFacturas(CodigoFactura);
                }
                else
                {
                    MessageBox.Show("Buscar con el numero de factura", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error.SetError(TxtBuscarFactura, "No hay registro");
                MessageBox.Show("el registro no existe", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgFactura.DataSource = Facturacion.LeerFacturas();
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (DtgFactura.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgFactura.SelectedRows[0];

                int numeroruc = Convert.ToInt32(data.Cells[0].Value);

                string Nombre = data.Cells[1].Value.ToString();

                decimal SubTotal = Convert.ToDecimal(data.Cells[3].Value);

                decimal Total = Convert.ToDecimal(data.Cells[4].Value);

                DateTime date = Convert.ToDateTime(data.Cells[5].Value);

                TimeSpan hora = TimeSpan.Parse(data.Cells[6].Value.ToString());

                Frmservicio2 frmNuevo = new Frmservicio2(numeroruc, Nombre, SubTotal, Total, date, hora);

                frmNuevo.Show();
            }
        }
        private void ICNServicio_Click(object sender, EventArgs e)
        {
            FrmNuevoServicio servicio = new FrmNuevoServicio();

            servicio.Show();
        }

        private void DtgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
