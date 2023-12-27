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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
