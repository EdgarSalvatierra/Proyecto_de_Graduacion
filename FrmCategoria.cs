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
using static iTextSharp.tool.xml.html.HTML;

namespace Proyecto_de_Graduacion
{
    public partial class FrmCategoria : Form
    {
        Categoria_Model categoria = new Categoria_Model();
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;

            TxtCategoria.Enabled = false;

            DtgCategoria.DataSource = categoria.LeerCategoria();
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgCategoria.DataSource = categoria.LeerCategoria();
        }
        private void DtgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnNuevoExamen.Enabled = false;

            BtnCancelar.Enabled = true;

            BtnEditar.Enabled = true;

            BtnGuardar.Enabled = true;

            txtid.Text = DtgCategoria.CurrentRow.Cells[0].Value.ToString();

            TxtCategoria.Text = DtgCategoria.CurrentRow.Cells[1].Value.ToString();

            TxtCategoria.Enabled = true;
        }

        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            string categoria_nombre = TxtBuscarFactura.Text;

            DtgCategoria.DataSource = categoria.LeerCategoriaporId(categoria_nombre);
        }

        private void BtnNuevoExamen_Click(object sender, EventArgs e)
        {
            txtid.Clear();

            TxtCategoria.Clear();

            TxtCategoria.Enabled = true;

            BtnNuevoExamen.Enabled = false;

            BtnEditar.Enabled = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TxtCategoria.Text))
                {
                    string Categoria = TxtCategoria.Text;

                    categoria.InsertarCategoria(TxtCategoria.Text);

                    MessageBox.Show("Guardardo exitosamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtid.Clear();

                    TxtCategoria.Clear();

                    DtgCategoria.DataSource = categoria.LeerCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnNuevoExamen.Enabled = true;

            BtnNuevoExamen.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnCancelar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;

            TxtCategoria.Enabled = false;

            txtid.Clear();

            TxtCategoria.Clear();

            TxtBuscarFactura.Clear();

            BtnGuardar.Enabled = false;

            BtnEditar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
