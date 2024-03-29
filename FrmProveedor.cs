﻿using Capa_Modelo.ViewModel;
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
    public partial class FrmProveedor : Form
    {
        Proveedor_Model proveedor = new Proveedor_Model();

        ErrorProvider Provider = new ErrorProvider();
        public FrmProveedor()
        {
            InitializeComponent();
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            DtgProveedor.DataSource =  proveedor.LeerProveedor();

            TxtProducto.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtCasacomercial.Enabled = false;
            TxtPrecio.Enabled = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtProducto.Enabled = true;
            TxtProveedor.Enabled = true;
            TxtCasacomercial.Enabled = true;
            TxtPrecio.Enabled = true;

            TxtPrecio.Clear();
            TxtProducto.Clear();
            TxtProveedor.Clear();
            TxtCasacomercial.Clear();

            BtnNuevo.Enabled = false;
        }
        private void TxtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarProducto.Text == "Buscar")
            {
                TxtBuscarProducto.Text = "";
                TxtBuscarProducto.ForeColor = Color.Black;
            }
        }
        private void Btndardebaja_Click(object sender, EventArgs e)
        {
            
        }

        private void DtgProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgProveedor.SelectedRows[0];

                TxtCodigo.Text = data.Cells[0].Value.ToString();

                TxtProveedor.Text = data.Cells[1].Value.ToString();

                TxtProducto.Text = data.Cells[3].Value.ToString();

                TxtCasacomercial.Text = data.Cells[2].Value.ToString();

                TxtPrecio.Text = data.Cells[4].Value.ToString();
            }

            TxtProducto.Enabled = true;

            TxtPrecio.Enabled = true;
           
        }
        private void BtnBuscarProductos_Click(object sender, EventArgs e)
        {
            DtgProveedor.DataSource = proveedor.LeerProveedorporId(TxtBuscarProducto.Text.ToString());
        }
        private void Btnrefrescar_Click_1(object sender, EventArgs e)
        {
            DtgProveedor.DataSource = proveedor.LeerProveedor();
        }
        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            TxtProducto.Enabled = true;
            TxtProveedor.Enabled = true;
            TxtCasacomercial.Enabled = true;
            TxtPrecio.Enabled = true;

            TxtPrecio.Clear();
            TxtProducto.Clear();
            TxtProveedor.Clear();
            TxtCasacomercial.Clear();

            BtnNuevo.Enabled = false;
        }
        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (DtgProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgProveedor.SelectedRows[0];

                TxtCodigo.Text = data.Cells[0].Value.ToString();

                TxtProveedor.Text = data.Cells[1].Value.ToString();

                TxtProducto.Text = data.Cells[3].Value.ToString();

                TxtCasacomercial.Text = data.Cells[2].Value.ToString();

                TxtPrecio.Text = data.Cells[4].Value.ToString();
            }

            BtnNuevo.Enabled = false;

            BtnEditar.Enabled = false;
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtProveedor.Text)
             && !string.IsNullOrWhiteSpace(TxtProducto.Text)
             && !string.IsNullOrWhiteSpace(TxtCasacomercial.Text) && !string.IsNullOrWhiteSpace(TxtPrecio.Text)
             || decimal.TryParse(TxtPrecio.Text, out _))
            {
                string Proveedor = TxtProveedor.Text;

                string CasaComercial = TxtCasacomercial.Text;

                string Producto = TxtProducto.Text;

                decimal Precio = Convert.ToDecimal(TxtPrecio.Text);

                proveedor.InsertarProveedor(Proveedor, CasaComercial);

                proveedor.InsertarProducto(Producto, Precio, Proveedor);

                MessageBox.Show("Guardado Correctamente", "Sql Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtProveedor.Enabled = false;
                TxtCasacomercial.Enabled = false;

                TxtProducto.Clear();
                TxtPrecio.Clear();

                BtnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Campos Incompletos", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Provider.SetError(BtnGuardar, "Errodeguardar");
            }
        }
        private void Btndardebaja_Click_1(object sender, EventArgs e)
        {
            /*
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgProveedor.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgProveedor.SelectedRows[0];

                    int numeroruc = Convert.ToInt32(data.Cells[0].Value);

                    facturas.ActualizarFacturas(numeroruc);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
        }
    }
}
