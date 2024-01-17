using Capa_Modelo.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.tool.xml.html.HTML;

namespace Proyecto_de_Graduacion
{
    public partial class FrmNuevoExamen : Form
    {
        Categoria_Model categoria = new Categoria_Model();

        Examen_Model examen = new Examen_Model();

        BindingSource source = new BindingSource();
        public FrmNuevoExamen()
        {
            InitializeComponent();

            txttitulo.Focus();
            txttitulo.KeyPress += txttitulo_KeyPress;
            txt_precio.KeyPress += txttitulo_KeyPress;
            BtnEnlace.KeyPress += txttitulo_KeyPress;
            BtnGuardar.KeyPress += txttitulo_KeyPress;
        }
        private void FrmNuevoExamen_Load(object sender, EventArgs e)
        {
            txtRuta.Enabled = false;

            source.DataSource = categoria.LeerCategoria();

            if (source.Count > 0 )
            {
                CMBCategoria.DataSource = source;

                CMBCategoria.DisplayMember = "Area";

                CMBCategoria.ValueMember = "Codigo";
            }
            else
            {
                CMBCategoria.Text = "No hay datos disponibles";

                CMBCategoria.Enabled = false;
            } 

            Dtgexamen.DataSource = examen.LeerExamen();
        }
        private void BtnEnlace_Click(object sender, EventArgs e)
        {
            string Direccion = AppDomain.CurrentDomain.BaseDirectory;
            string carpeta = Direccion + "Resultados";
            openFileDialog1.InitialDirectory = carpeta;
            openFileDialog1.Filter = "todas las extensiones(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtRuta.Text = openFileDialog1.FileName;

        }
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();

            categoria.Show();
        }
        private void Dtgexamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttitulo.Text = Dtgexamen.CurrentRow.Cells[1].Value.ToString();

                CMBCategoria.Text = Dtgexamen.CurrentRow.Cells[2].Value.ToString();

                txt_precio.Text = Dtgexamen.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCargarPlantilla_Click(object sender, EventArgs e)
        {
            if (Dtgexamen.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Dtgexamen.CurrentRow.Cells[0].Value.ToString());
                var lista = new List<Examen_Model>();
                lista = examen.filtroDocumentos(id);

                foreach (Examen_Model item in lista)
                {
                    //crear carpeta temporal
                    string Direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = Direccion + "/Resultados/";
                    string ubicacionCompleta = carpeta + item.Extension;

                    //validacion
                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if (File.Exists(ubicacionCompleta))

                        File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);
                }
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo = obj.ToArray();

            string Nombre =  txttitulo.Text;
            byte[] Documento = archivo;
            string Extension = openFileDialog1.SafeFileName;
            int Categoria = Convert.ToInt32(CMBCategoria.SelectedValue);
            decimal Precio = Convert.ToDecimal(txt_precio.Text);

            examen.InsertarExamenes(Categoria, Nombre, Documento, Extension, Precio);

            MessageBox.Show("Guardado  Correctamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void BtnEnlace_Click_1(object sender, EventArgs e)
        {
            string Direccion = AppDomain.CurrentDomain.BaseDirectory;
            string carpeta = Direccion + "Resultados";
            openFileDialog1.InitialDirectory = carpeta;
            openFileDialog1.Filter = "todas las extensiones(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtRuta.Text = openFileDialog1.FileName;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtRuta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRuta.Text))
            {
                errorProvider1.SetError(txtRuta, "Ingrese el Nombre");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRuta, "");
            }
        }
        private void txt_precio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorProvider1.SetError(txt_precio, "Ingrese el Nombre");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_precio, "");
            }
        }
        private void txttitulo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txttitulo.Text))
            {
                errorProvider1.SetError(txttitulo, "Ingrese el Nombre");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txttitulo, "");
            }
        }
        private void txttitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
