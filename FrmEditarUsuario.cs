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
    public partial class FrmEditarUsuario : Form
    {
        int codigo, edad;
        string nombre, User, Contraseña, roles;
        long telefono;

        Usuario_Model usuario_Model = new Usuario_Model(); 

        ErrorProvider provider = new ErrorProvider();

        Roles_Model Roles1 = new Roles_Model();
        public FrmEditarUsuario(int Codigo,string Nombre,int Edad,long Telefono,string user,string contraseña,string Roles)
        {
            InitializeComponent();

            codigo = Codigo;

            nombre = Nombre;

            edad = Edad;

            telefono = Telefono;

            User = user;

            Contraseña = contraseña;

            roles = Roles;

            CmBRoles.DataSource = Roles1.LeerRol();

            CmBRoles.ValueMember = "Codigo";

            CmBRoles.DisplayMember = "Rol";
        }
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            LblCodigo.Text = codigo.ToString();

            txtNombre.Text = nombre.ToString();

            txtEdad.Text = edad.ToString();

            txttelefono.Text = telefono.ToString();

            txtUsuario.Text = User.ToString();

            txtContraseña.Text = Contraseña.ToString();

            CmBRoles.Text = roles.ToString();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNombre.Text)
                 && !String.IsNullOrWhiteSpace(txttelefono.Text) && !String.IsNullOrWhiteSpace(txtUsuario.Text)
                 && !String.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    int Codigo = Convert.ToInt32(LblCodigo.Text);

                    string Nombre = txtNombre.Text;
                    
                    int Edad = Convert.ToInt32(txtEdad.Text);

                    long telefono = Convert.ToInt64(txttelefono.Text);

                    string Usuario = txtUsuario.Text;

                    string contraseña = txtContraseña.Text;

                    string Roles = CmBRoles.Text;

                    usuario_Model.ActualizarUsuario(Codigo,Usuario, contraseña, Nombre, Edad, telefono, Roles);

                    MessageBox.Show("Guardado  Correctamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    provider.SetError(BtnGuardar, "Campos incompletos, complete el formulario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
