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
    public partial class Frmservicio2 : Form
    {
        Facturacion_Model facturas = new Facturacion_Model();

        ErrorProvider error = new ErrorProvider();

        int NumeroRuc;

        string nombre;

        decimal subtotal, total;

        DateTime Date;

        TimeSpan Time;

        string Examen;

        decimal Monto = 0;

        string ultimosCuatro = "";

        List<Object> lista = new List<Object>();

        BindingSource Bindi = new BindingSource();

        Examen_Model examenes = new Examen_Model();
        public Frmservicio2(int numeroruc, string Nombre, decimal SubTotal, decimal Total, DateTime date, TimeSpan hora)
        {
            InitializeComponent();

            NumeroRuc = numeroruc;

            nombre = Nombre;

            subtotal = SubTotal;

            total = Total;

            Date = date;

            Time = hora;

            Bindi.DataSource = examenes.Cargar();
        }
        private void Frmservicio2_Load(object sender, EventArgs e)
        {
            TxtCodigoFactura.Text = NumeroRuc.ToString();

            TxtCodigoFactura.Enabled = false;

            TxtPacientes.Enabled = false;

            TxtPacientes.Text = nombre;

            DtgDetallesdeFactura.DataSource = facturas.LeerFacturasporId(NumeroRuc);

            LBlsubtotal.Text = subtotal.ToString();

            lbl001.Text = total.ToString();

            TxtExamen.Enabled = false;

            TxtPrecio.Enabled = false;

            TxtExamen.Text = DtgDetallesdeFactura.CurrentRow.Cells[0].Value.ToString();

            TxtPrecio.Text = DtgDetallesdeFactura.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtgDetallesdeFactura_Click(object sender, EventArgs e)
        {
            try
            {
                TxtExamen.Text = DtgDetallesdeFactura.CurrentRow.Cells[0].Value.ToString();

                TxtPrecio.Text = DtgDetallesdeFactura.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
