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
    public partial class FrmNuevoUsuario : Form
    {
        Usuario_Model usuario_Model = new Usuario_Model(); 

        ErrorProvider provider = new ErrorProvider();

        Roles_Model roles = new Roles_Model();

        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }
        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            CmBRoles.DataSource = roles.LeerRol();

            CmBRoles.DisplayMember = "Rol";

            CmBRoles.ValueMember = "Codigo";
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNombre.Text)
                 && !String.IsNullOrWhiteSpace(txtApellido.Text)
                 && !String.IsNullOrWhiteSpace(txttelefono.Text) && !String.IsNullOrWhiteSpace(txtUsuario.Text)
                 && !String.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    string Nombre = txtNombre.Text;

                    string Apellido = txtApellido.Text;

                    DateTime fechanacimiento = Convert.ToDateTime(DtpFechaNacimiento.Text);

                    long telefono = Convert.ToInt64(txttelefono.Text);

                    string Usuario = txtUsuario.Text;

                    string contraseña = txtContraseña.Text;

                    string Roles = CmBRoles.Text;

                    usuario_Model.InsertarUsuario(Usuario, contraseña, Roles);

                    usuario_Model.InsertarDetalles(Usuario, Nombre, Apellido, fechanacimiento, telefono);

                    MessageBox.Show("Guardado  Correctamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    provider.SetError(button1, "Campos incompletos, complete el formulario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
