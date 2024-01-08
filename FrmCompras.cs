using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Capa_Modelo.ViewModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class FrmCompras : Form
    {
        Compras_Model compras = new Compras_Model();
        public FrmCompras()
        {
            InitializeComponent();
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            DtgCompras.DataSource = compras.LeerPedidos();
        }
        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            string Producto = TxtBuscarCompra.Text.ToString();

            string Proveedor = TxtBuscarCompra.Text.ToString();

            DtgCompras.DataSource = compras.LeerPedidosporNombre(Proveedor,Producto);
        }
        private void TxtBuscarCompra_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarCompra.Text == "Buscar Compra")
            {
                TxtBuscarCompra.Text = "";

                TxtBuscarCompra.ForeColor = Color.Black;
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgCompras.DataSource = compras.LeerPedidos();
        }
        private void BtnDardebaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgCompras.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgCompras.SelectedRows[0];

                    int Codigo = Convert.ToInt32(data.Cells[0].Value);

                    compras.DarDebaja(Codigo);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ICNCompra_Click(object sender, EventArgs e)
        {
            FrmNuevaCompra compras = new FrmNuevaCompra();

            compras.Show();
        }
    }
}
