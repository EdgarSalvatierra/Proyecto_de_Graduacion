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

namespace Proyecto_de_Graduacion
{
    public partial class FrmEditarExamen_ : Form
    {
        Examen_Model Examen = new Examen_Model();

        Paciente_Model Paciente = new Paciente_Model();

        Categoria_Model categoria = new Categoria_Model();

        Resultados_Model resultados = new Resultados_Model();

        BindingSource source = new BindingSource();

        public FrmEditarExamen_()
        {
            InitializeComponent();
        }

        private void FrmEditarExamen__Load(object sender, EventArgs e)
        {
            llenarDatos();

            source.DataSource = categoria.LeerCategoria();

            if (source.Count > 0)
            {
                CMBCategoria.DataSource = source;

                CMBCategoria.DisplayMember = "Area";

                CMBCategoria.ValueMember = "Codigo";
            }
            else
            {
                CMBCategoria.Enabled = false;

                CMBCategoria.Text = "No hay datos disponibles";
            }
        }
        private void llenarDatos()
        {
            DtgExamen.DataSource = Examen.LeerExamen();
            DtgPaciente.DataSource = Paciente.CargarPacientes();
        }
        private void BtncargarPlantilla_Click(object sender, EventArgs e)
        {
            if (DtgExamen.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DtgExamen.CurrentRow.Cells[0].Value.ToString());
                Examen.Id = id;
                var lista = new List<Examen_Model>();
                lista = Examen.filtroDocumentos(id);

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
                    BtnGuardarTodo.Enabled = true;
                }
            }
        }
        private void BtnGuardarTodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaciente.Text))
            {
                BtnGuardarTodo.Enabled = false;
                errorProvider1.SetError(txtPaciente, "Ingrese El Nombre Del Examinado");
            }
            else

            if (string.IsNullOrEmpty(TxtPrecio.Text))
            {
                BtnGuardarTodo.Enabled = false;
                errorProvider1.SetError(TxtPrecio, "Ingrese El Precio");
            }
            else

            if (string.IsNullOrEmpty(TxtTitulo.Text))

            {
                BtnGuardarTodo.Enabled = false;

                errorProvider1.SetError(TxtTitulo, "Ingrese El Examen");
            }
            else
            {

                errorProvider1.SetError(txtPaciente, "");
                errorProvider1.SetError(TxtPrecio, "");
                errorProvider1.SetError(TxtTitulo, "");


                string Direccion = AppDomain.CurrentDomain.BaseDirectory;
                string carpeta = Direccion + "Resultados";


                openFileDialog1.InitialDirectory = carpeta;
                openFileDialog1.Filter = "todas las extensiones(*.doc*)|*.doc*";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    TxtRuta.Text = openFileDialog1.FileName;


                byte[] archivo = null;
                Stream MyStream = openFileDialog1.OpenFile();
                MemoryStream obj = new MemoryStream();
                MyStream.CopyTo(obj);
                archivo = obj.ToArray();

                string Nombre = TxtTitulo.Text;
                string NombrePaciente = txtPaciente.Text;
                byte[] Documento = archivo;
                string Extension = openFileDialog1.SafeFileName;
                int Categoria = Convert.ToInt32(CMBCategoria.SelectedValue);
                decimal Precio = Convert.ToDecimal(TxtPrecio.Text);


                resultados.Insertar_Resultados(Nombre, NombrePaciente, Documento, Extension, Categoria, Precio);

                MessageBox.Show("Guardado  Correctamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPaciente.Text = DtgPaciente.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void DtgExamen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtTitulo.Text = DtgExamen.CurrentRow.Cells[1].Value.ToString();
                CMBCategoria.Text = DtgExamen.CurrentRow.Cells[2].Value.ToString();
                TxtPrecio.Text = DtgExamen.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
