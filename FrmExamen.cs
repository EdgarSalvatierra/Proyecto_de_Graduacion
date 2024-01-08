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
    public partial class FrmExamen : Form
    {
        Examen_Model Examen = new Examen_Model();
        public FrmExamen()
        {
            InitializeComponent();
        }
        private void FrmExamen_Load(object sender, EventArgs e)
        {
            DtgExamen.DataSource = Examen.LeerExamen();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {

        } 
        private void ICNCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();

            categoria.Show();
        }

        private void ICNBuscador_Click(object sender, EventArgs e)
        {
            string examen = TxtBuscarExamen.Text;

            DtgExamen.DataSource = Examen.BuscarporExamen(examen);
        }
    }
}
