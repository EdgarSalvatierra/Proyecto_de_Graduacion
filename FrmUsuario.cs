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
    public partial class FrmUsuario : Form
    {
        Usuario_Model Usuario = new Usuario_Model();
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
           DtgUsuarios.DataSource =  Usuario.LeerUsuario();
        }
        private void TxtBuscarFactura_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarFactura.Text == "Buscar Usuario")
            {
                TxtBuscarFactura.Text = "";
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgUsuarios.DataSource = Usuario.LeerUsuario();
        }
        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarFactura.Text,out _))
            {
                string Nombre = TxtBuscarFactura.Text;

                string Roles = TxtBuscarFactura.Text;

                DtgUsuarios.DataSource = Usuario.LeerUsuarioporId(Nombre,Roles);
            }
        }
        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevo = new FrmNuevoUsuario();

            frmNuevo.Show();
        }
        private void Btndardebaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgUsuarios.SelectedRows[0];

                    string user = data.Cells[4].Value.ToString();

                    Usuario.DardebajaUsuario(user);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DtgUsuarios.DataSource = Usuario.LeerUsuario();
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgUsuarios.SelectedRows[0];

                int Codigo = Convert.ToInt32(data.Cells[0].Value);

                string Nombre = data.Cells[1].Value.ToString();

                int Edad = Convert.ToInt32(data.Cells[2].Value);

                long Telefono = Convert.ToInt64(data.Cells[3].Value);

                string user = data.Cells[4].Value.ToString();

                string contraseña = data.Cells[5].Value.ToString();

                string Roles = data.Cells[6].Value.ToString();

                FrmEditarUsuario editarUsuario = new FrmEditarUsuario(Codigo, Nombre, Edad, Telefono, user, contraseña, Roles);

                editarUsuario.Show();

                DtgUsuarios.DataSource = Usuario.LeerUsuario();
            }
            else
            {
                MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
