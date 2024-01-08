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
    public partial class FrmNuevoPaciente : Form
    {
        Paciente_Model paciente = new Paciente_Model();

        ErrorProvider provider = new ErrorProvider();
        public FrmNuevoPaciente()
        {
            InitializeComponent();
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxtNombre.Text) && !String.IsNullOrWhiteSpace(txtTelefono.Text) && !String.IsNullOrWhiteSpace(TxtFecha.Text))
                {
                    string Nombre = TxtNombre.Text;

                    DateTime Nacimiento = Convert.ToDateTime(DtpFecha.Text);

                    long telefono = Convert.ToInt64(txtTelefono.Text);

                    string Sexo = CmbSexo.Text;
                  
                    paciente.InsertarPacientes(Nombre, telefono, Nacimiento, Sexo);

                    MessageBox.Show("Guardardo exitosamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtNombre.Clear();

                    txtTelefono.Clear();

                    this.Close();
                }
                else
                {
                    provider.SetError(BtnGuardar, "Campos incompletos, no se puede guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
