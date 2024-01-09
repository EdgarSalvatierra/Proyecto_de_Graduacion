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
    public partial class FrmEditarExamen : Form
    {
        int codigo = 0;
        string Categoria, Examen, Plantilla;
        decimal Precio = 0;

        public FrmEditarExamen(int Codigo,string categoria,string examen,string plantilla,decimal precio)
        {
            InitializeComponent();

            codigo = Codigo;

            Categoria = categoria;

            Examen = examen;

            Plantilla = plantilla;

            Precio = precio;
        }

        private void BtnEnlace_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarExamen_Load(object sender, EventArgs e)
        {
            LblCodigoExamen.Text = codigo.ToString();

            CMBCategoria.Text = Categoria;

            txtNombre.Text = Examen;

            Txtruta.Text = Plantilla;

            TxtPrecio.Text = Precio.ToString();
            
        }
        private void BtnNuevoExamen_Click(object sender, EventArgs e)
        {

        }
    }
}
