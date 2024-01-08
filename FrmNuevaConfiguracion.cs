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
    public partial class FrmNuevaConfiguracion : Form
    {
        Configuracion_Model configuracion = new Configuracion_Model();

        string entidad, administrador, telefono, ubicacion, ciudad;

        public FrmNuevaConfiguracion(string Entidad, string Administrador, string Telefono, string Ubicacion, string Ciudad)
        {
            InitializeComponent();

            entidad = Entidad;

            administrador = Administrador;

            telefono = Telefono;

            ubicacion = Ubicacion; 
            
            ciudad = Ciudad;
        }
        private void FrmNuevaConfiguracion_Load(object sender, EventArgs e)
        {
            TxtEntidad.Text = entidad;

            TxtAdministrador.Text = administrador;

            TxtTelefono.Text = telefono;

            TxtUbicacion.Text = ubicacion;

            TxtCiudad.Text = ciudad;

            Lblfechita.Text = DateTime.Now.ToLongDateString();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            long Telefono = Convert.ToInt64(TxtTelefono.Text);

            configuracion.ActualizarEntidad(TxtEntidad.Text.ToString(), TxtAdministrador.Text.ToString(), Telefono, TxtUbicacion.Text.ToString(),TxtCiudad.Text.ToString());

            MessageBox.Show("Informacion Actualizada","SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEntidad.Clear();

            TxtAdministrador.Clear();

            TxtTelefono.Clear();

            TxtUbicacion.Clear();

            TxtCiudad.Clear();
        }
    }
}
