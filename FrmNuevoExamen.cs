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
        public FrmNuevoExamen()
        {
            InitializeComponent();
        }
        private void FrmNuevoExamen_Load(object sender, EventArgs e)
        {
            Txtruta.Enabled = false;

            CMBCategoria.DataSource = categoria.LeerCategoria();

            CMBCategoria.DisplayMember = "Area";

            CMBCategoria.ValueMember = "Codigo";

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
                Txtruta.Text = openFileDialog1.FileName;

        }
        private void BtnNuevoExamen_Click(object sender, EventArgs e)
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
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();

            categoria.Show();
        }

        private void BtnGuardarTodo_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo = obj.ToArray();

            string Nombre = txtNombre.Text;
            byte[] Documento = archivo;
            string Extension = openFileDialog1.SafeFileName;
            int Categoria = Convert.ToInt32(CMBCategoria.SelectedValue);
            decimal Precio = Convert.ToDecimal(TxtPrecio.Text);

            examen.InsertarExamenes(Categoria,Nombre, Documento, Extension,Precio);

            MessageBox.Show("Guardado  Correctamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void Dtgexamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid_examen.Text = Dtgexamen.CurrentRow.Cells[0].Value.ToString();

                CMBCategoria.Text = Dtgexamen.CurrentRow.Cells[1].Value.ToString();

                txtNombre.Text = Dtgexamen.CurrentRow.Cells[2].Value.ToString();

                Txtruta.Text = Dtgexamen.CurrentRow.Cells[3].Value.ToString();

                TxtPrecio.Text = Dtgexamen.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
