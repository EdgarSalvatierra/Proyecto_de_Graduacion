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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el diálogo para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    TxtArchivodelIcono.Text = rutaImagen;

                    TxtArchivodelIcono.Enabled = false;

                    // Cargar la imagen en el PictureBox
                    Pclogo.Image = Image.FromFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
