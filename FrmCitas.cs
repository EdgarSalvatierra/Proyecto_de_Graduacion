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
    public partial class FrmCitas : Form
    {
        Citas_Model Citas = new Citas_Model();
        public FrmCitas()
        {
            InitializeComponent();
        }
        private void FrmCitas_Load(object sender, EventArgs e)
        {
           dgvMostrar.DataSource =  Citas.LeerCitas();
        }
        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtBusquedaCita.Text, out _))
            {
                long Telefono = Convert.ToInt64(txtBusquedaCita.Text);

                string Pacientes = "";

               dgvMostrar.DataSource =  Citas.Search(Pacientes, Telefono);
            }
            else  
            {
                long Telefono = 0;

                string Pacientes = txtBusquedaCita.Text;

                dgvMostrar.DataSource = Citas.Search(Pacientes, Telefono);
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = Citas.LeerCitas();
        }
        private void txtBusquedaCita_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaCita.Text == "Buscar Citas")
            {
                txtBusquedaCita.Text = "";
            }
        }
    }
}
