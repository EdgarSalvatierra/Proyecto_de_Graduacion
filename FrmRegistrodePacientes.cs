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
    public partial class FrmRegistrodePacientes : Form
    {
        Paciente_Model paciente = new Paciente_Model();       
        public FrmRegistrodePacientes()
        {
            InitializeComponent();
        }
        private void FrmRegistrodePacientes_Load(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();
        }
        private void BtnNuevoPaciente_Click(object sender, EventArgs e)
        {
            FrmNuevoPaciente nuevoPaciente = new FrmNuevoPaciente();

            nuevoPaciente.Show();
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();
        }
        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarPaciente.Text, out _))
            {
                string Paciente = TxtBuscarPaciente.Text;

                DtgPaciente.DataSource =  paciente.LeerPacientesporId(Paciente);
            }
            else
            {
                MessageBox.Show("No existe tal dato","SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void TxtBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarPaciente.Text == "Buscar Paciente")
            {
                TxtBuscarPaciente.Text = "";
            }
        }
    }
}
