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

        ErrorProvider provider = new ErrorProvider();
        public FrmRegistrodePacientes()
        {
            InitializeComponent();
        }
        private void FrmRegistrodePacientes_Load(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();

            TxtNombre.Enabled = false;

            TxtApellido.Enabled = false;

            txtTelefono.Enabled = false;

            CmbSexo.Enabled = false;

            DtpFecha.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnCancelar.Enabled = false;
        }
        private void BtnNuevoPaciente_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            txtTelefono.Clear();
            DtpFecha.Focus();
            CmbSexo.Focus();

            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            CmbSexo.Enabled = true;
            DtpFecha.Enabled = true;

            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnNuevoPaciente.Enabled = false;
            BtnEditar.Enabled = false;
        }
        private void TxtBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarPaciente.Text == "Buscar Paciente")
            {
                TxtBuscarPaciente.Text = "";
                TxtBuscarPaciente.ForeColor = Color.Black;
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();
        }
        private void ICNBuscador_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarPaciente.Text, out _))
            {
                string Paciente = TxtBuscarPaciente.Text;

                DtgPaciente.DataSource = paciente.LeerPacientesporId(Paciente);
            }
            else
            {
                MessageBox.Show("No existe tal dato", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (DtgPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgPaciente.SelectedRows[0];

                LblCodigo.Text = data.Cells[0].Value.ToString();

                TxtNombre.Text = data.Cells[1].Value.ToString();

                TxtApellido.Text = data.Cells[2].Value.ToString();

                DtpFecha.Text = data.Cells[3].Value.ToString();

                CmbSexo.Text = data.Cells[5].Value.ToString();

                txtTelefono.Text = data.Cells[6].Value.ToString();
            }
            BtnEditar.Enabled = false;

            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            CmbSexo.Enabled = true;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            txtTelefono.Clear();
            DtpFecha.Focus();
            CmbSexo.Focus();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxtNombre.Text) && !String.IsNullOrWhiteSpace(txtTelefono.Text) && !String.IsNullOrWhiteSpace(DtpFecha.Text))
                {
                    string Nombre = TxtNombre.Text;

                    string Apellido = TxtApellido.Text;

                    DateTime Nacimiento = Convert.ToDateTime(DtpFecha.Text);

                    long telefono = Convert.ToInt64(txtTelefono.Text);

                    string Sexo = CmbSexo.Text;

                    paciente.InsertarPacientes(Nombre, Apellido, telefono, Nacimiento, Sexo);

                    MessageBox.Show("Guardardo exitosamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtNombre.Clear();

                    TxtApellido.Clear();

                    txtTelefono.Clear();

                    TxtNombre.Enabled = false;

                    TxtApellido.Enabled = false;

                    txtTelefono.Enabled = false;

                    CmbSexo.Enabled = false;

                    DtpFecha.Enabled = false;

                    BtnGuardar.Enabled = false;

                    BtnCancelar.Enabled = false; ;

                    BtnEditar.Enabled = true;

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
        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgPaciente.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgPaciente.SelectedRows[0];

                    LblCodigo.Text = data.Cells[0].Value.ToString();

                    TxtNombre.Text = data.Cells[1].Value.ToString();

                    TxtApellido.Text = data.Cells[2].Value.ToString();

                    DtpFecha.Text = data.Cells[3].Value.ToString();

                    CmbSexo.Text = data.Cells[5].Value.ToString();

                    txtTelefono.Text = data.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btndardebaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgPaciente.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgPaciente.SelectedRows[0];

                    DateTime numeroruc = Convert.ToDateTime(data.Cells[3].Value.ToString());

                    paciente.ActualizarEstado(numeroruc);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
