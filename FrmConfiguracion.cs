using Capa_Modelo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class FrmConfiguracion : Form
    {
        Configuracion_Model configuracion = new Configuracion_Model();
        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            Bitmap omg = new Bitmap(Properties.Resources.Laboratorio_removebg_preview);
            // Convertir el ícono a imagen
            Image imagenIcono = omg;

            // Asignar la imagen al control PictureBox (suponiendo que Pclogo es un control PictureBox)
            Pclogo.Image = imagenIcono;

            LblEntidad2.Text = configuracion.GetNombre();

            Lbladministrador2.Text = configuracion.GetAdministrador();

            LblTelefono2.Text = configuracion.GetTelefono().ToString();

            Lblubicacion2.Text = configuracion.GetUbicacion().ToString();

            Lblciudad2.Text = configuracion.GetCiudad().ToString();
        }
        private void Btncambiarinformacion_Click(object sender, EventArgs e)
        {
            FrmNuevaConfiguracion nuevaConfiguracion = new FrmNuevaConfiguracion(LblEntidad2.Text,Lbladministrador2.Text,LblTelefono2.Text,Lblubicacion2.Text,Lblciudad2.Text);

            nuevaConfiguracion.Show();
        }
        public void cambiaricono(string rutaimagen)
        {
            Bitmap bitmap = new Bitmap(rutaimagen);
            Icon nuevoIcono = Icon.FromHandle(bitmap.GetHicon());

            // Convertir el nuevo ícono a un arreglo de bytes

            foreach (Form formulario in Application.OpenForms)
            {
                formulario.Icon = nuevoIcono;

                // Opcional: Forzar una actualización visual del formulario
                formulario.Refresh();

                nuevoIcono.Dispose();
            }
            // Convertir el nuevo ícono a una imagen y asignarlo a un control PictureBox (si es necesario)
            System.Drawing.Image imagenIcono = nuevoIcono.ToBitmap();
            Pclogo.Image = imagenIcono;
        }    
        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
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
        private void BtnCambiarlogo_Click(object sender, EventArgs e)
        {
            cambiaricono(TxtArchivodelIcono.Text);
        }
    }
}
