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
    public partial class FrmNuevaCita : Form
    {
        Citas_Model citas = new Citas_Model();

        public FrmNuevaCita()
        {
            InitializeComponent();
        }
        private void FrmNuevaCita_Load(object sender, EventArgs e)
        {
            DtpFechaCita.Enabled = false;

            DtpHoraCita.Enabled = false;

            DtpNacimiento.Enabled = false;

            TxtNombre.Enabled = false;

            TxtTelefono.Enabled = false;

            TxtApellido.Enabled = false;

            TxtCodigo.Enabled = false;

            TxtMotivo.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnCancelar.Enabled = false;
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btnnueva_Click(object sender, EventArgs e)
        {
            DtpFechaCita.Enabled = true;

            DtpHoraCita.Enabled = true;

            DtpNacimiento.Enabled = true;

            TxtNombre.Enabled = true;

            TxtTelefono.Enabled = true;

            TxtApellido.Enabled = true;

            TxtCodigo.Enabled = true;

            TxtMotivo.Enabled = true;

            BtnGuardar.Enabled = true;

            BtnCancelar.Enabled = true;

            Btnnueva.Enabled = false;

            TxtNombre.Clear();

            TxtApellido.Clear();

            TxtMotivo.Clear();

            TxtTelefono.Clear();

            DtpFechaCita.Focus();

            DtpHoraCita.Focus();

            DtpNacimiento.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();

            TxtApellido.Clear();

            TxtMotivo.Clear();

            TxtTelefono.Clear();

            DtpFechaCita.Focus();

            DtpHoraCita.Focus();

            DtpNacimiento.Focus();

            BtnGuardar.Enabled = false;

            BtnCancelar.Enabled = false;

            Btnnueva.Enabled = true;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                citas.InsertarCitas(TxtNombre.Text, TxtApellido.Text, DtpNacimiento.Value, Convert.ToInt64(TxtTelefono.Text), TxtMotivo.Text, DtpFechaCita.Value, DtpHoraCita.Value);

                MessageBox.Show("Guardado Correctament", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNombre.Clear();

                TxtApellido.Clear();

                TxtMotivo.Clear();

                TxtTelefono.Clear();

                DtpFechaCita.Focus();

                DtpHoraCita.Focus();

                DtpNacimiento.Focus();

                DtpFechaCita.Enabled = false;

                DtpHoraCita.Enabled = false;

                DtpNacimiento.Enabled = false;

                TxtNombre.Enabled = false;

                TxtTelefono.Enabled = false;

                TxtApellido.Enabled = false;

                TxtCodigo.Enabled = false;

                TxtMotivo.Enabled = false;

                BtnGuardar.Enabled = false;

                BtnCancelar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
