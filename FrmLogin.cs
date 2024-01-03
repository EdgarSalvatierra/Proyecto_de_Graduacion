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
    public partial class FrmLogin : Form
    {
        Usuario_Model model = new Usuario_Model();

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUser.Text;

            string contraseña = TxtContraseña.Text;

            bool res = model.InicioSesion(usuario, contraseña);

            if (res)
            {
                MessageBox.Show("Usuario verificado, puede entrar al sistema","SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Hide();

                FrmMDI mDI = new FrmMDI(TxtUser.Text,TxtContraseña.Text);

                mDI.Show();
            }
            else
            {
                ErrorProvider errorProvider = new ErrorProvider();

                errorProvider.SetError(BtnEntrar, "No existe usuario");

                MessageBox.Show("El Usuario no existe,intente comunicarse con el Administrador", "SQl Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Usuario")
            {
                TxtUser.Text = "";
            }
        }
    }
}
