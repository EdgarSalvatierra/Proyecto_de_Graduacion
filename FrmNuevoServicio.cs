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
    public partial class FrmNuevoServicio : Form
    {

        ErrorProvider error = new ErrorProvider();

        Examen_Model examenes = new Examen_Model();

        Paciente_Model paciente = new Paciente_Model();

        Facturacion_Model facturas = new Facturacion_Model();

        BindingSource Bindi = new BindingSource();

        List<Object> lista = new List<Object>();

        decimal Monto = 0;

        string ultimosCuatro = "";

        public FrmNuevoServicio()
        {
            InitializeComponent();

        }
        private void FrmNuevoServicio_Load(object sender, EventArgs e)
        {

            TxtExamen.Enabled = false;

            TxtPrecio.Enabled = false;

            Bindi.DataSource = examenes.Cargar();

            lstexamenes1.DataSource = Bindi;

            lstexamenes1.DisplayMember = "Titulo";

            lstexamenes1.ValueMember = "cod_examen";

            timer.Start();

            CmbPacientes.DataSource = paciente.CargarPacientes();

            CmbPacientes.DisplayMember = "Nombre";

            CmbPacientes.ValueMember = "Cod_paciente";

            TxtCodigoFactura.Enabled = false;

            Random random = new Random();

            TxtCodigoFactura.Text = random.Next(100, 10000).ToString();

            CmbPacientes.Enabled = false;

            DtpFecha.Enabled = false;

            DtpHora.Enabled = false;

            Btnagregar.Enabled = false;

            BtnQuitar.Enabled = false;

            BtnGuardar.Enabled = false;

            BtnCancelar.Enabled = false;
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtCodigoFactura.Text)
                && !string.IsNullOrWhiteSpace(LBlsubtotal.Text)
                && !string.IsNullOrWhiteSpace(lbl001.Text) &&
                !string.IsNullOrWhiteSpace(DtpFecha.Text)
                && !string.IsNullOrWhiteSpace(DtpHora.Text) &&
                !string.IsNullOrWhiteSpace(CmbPacientes.Text))
            {
                if (DtpHora.Text == "00:00:00" || DtpFecha.Text == string.Empty)
                {
                    MessageBox.Show("Escribir una tiempo o fecha en especifico", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    error.SetError(DtpFecha, "Error");

                    error.SetError(DtpHora, "Error");
                }
                else
                {
                    if (DtgDetallesdeFactura.Rows.Count == 0)
                    {
                        MessageBox.Show("No ha elegido ningun examen, por favor elija uno", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        error.SetError(DtgDetallesdeFactura, "Error");
                    }
                    else
                    {
                        int numero = Convert.ToInt32(TxtCodigoFactura.Text);

                        DateTime dtpfecha = Convert.ToDateTime(DtpFecha.Text);

                        DateTime Hora = Convert.ToDateTime(DtpHora.Text);

                        decimal subTotal = Convert.ToDecimal(LBlsubtotal.Text);

                        decimal Total = Convert.ToDecimal(lbl001.Text);

                        int pacient = Convert.ToInt32(CmbPacientes.SelectedValue.GetHashCode());

                        facturas.InsertarFacturas(pacient, numero, subTotal, Total, dtpfecha, Hora);


                        while (DtgDetallesdeFactura.Rows.Count > 0)
                        {
                            int numero1 = Convert.ToInt32(TxtCodigoFactura.Text);

                            decimal subTotal1 = Convert.ToDecimal(LBlsubtotal.Text);

                            decimal Tota1 = Convert.ToDecimal(lbl001.Text);

                            string examen = DtgDetallesdeFactura.CurrentRow.Cells[0].Value.ToString();

                            decimal Precio = Convert.ToDecimal(DtgDetallesdeFactura.CurrentRow.Cells[1].Value);

                            facturas.InsertarDetallesFacturas(Precio, numero1, examen, subTotal1, Tota1);

                            DtgDetallesdeFactura.Rows.RemoveAt(0);
                        }

                        DateTime Hora1 = Convert.ToDateTime(DtpHora.Text);

                        MessageBox.Show($"Se ha realizado el Servicio Correctamente, la fecha de entrega de resultados sera el '{DtpFecha.Value}' a las '{Hora1.TimeOfDay}'", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        try
                        {
                            CmbPacientes.DataSource = paciente.CargarPacientes();

                            CmbPacientes.DisplayMember = "Nombre";

                            CmbPacientes.ValueMember = "Cod_paciente";

                            DtpHora.Text = "00:00:00";

                            Bindi.DataSource = examenes.Cargar();

                            lstexamenes1.DataSource = Bindi;

                            lstexamenes1.DisplayMember = "Titulo";

                            lstexamenes1.ValueMember = "cod_examen";

                            DtgDetallesdeFactura.Rows.Clear();

                            TxtExamen.Clear();

                            TxtPrecio.Clear();

                            lbl001.Text = "00.00";

                            LBlsubtotal.Text = "00.00";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos incompletos, por favor rellenarlos", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtExamen.Text) && !string.IsNullOrWhiteSpace(TxtPrecio.Text))
            {
                try
                {
                    if (lstexamenes1.Items.Count == 0)
                    {
                        MessageBox.Show("No hay examenes disponibles", "Systema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var list = lstexamenes1.SelectedItem;

                        Monto = Monto + Convert.ToDecimal(TxtPrecio.Text);

                        LBlsubtotal.Text = Monto.ToString();

                        lbl001.Text = Monto.ToString();

                        Bindi.Remove(list);

                        lstexamenes1.DataSource = Bindi;

                        lista.Add(list);

                        Bindi.ResetBindings(false);

                        int n = DtgDetallesdeFactura.Rows.Add();

                        DtgDetallesdeFactura.Rows[n].Cells[0].Value = TxtExamen.Text;

                        DtgDetallesdeFactura.Rows[n].Cells[1].Value = TxtPrecio.Text;

                        TxtExamen.Clear();

                        TxtPrecio.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error.SetError(Btnagregar, "Seleccione un elemento de la Lista y agregelo");

                MessageBox.Show("Seleccione un elemento de la Lista y agregelo", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lstexamenes1_Click(object sender, EventArgs e)
        {
            string texto = lstexamenes1.Text;

            int indiceIgual = texto.IndexOf('=');

            if (indiceIgual >= 0)
            {
                string primerosSeis = texto.Substring(0, indiceIgual);

                TxtExamen.Text = primerosSeis;

            }

            ultimosCuatro = new string(texto.Where(c => !char.IsLetter(c)).ToArray());

            ultimosCuatro = ultimosCuatro.Substring(ultimosCuatro.Length - 6);

            ultimosCuatro = ultimosCuatro.Replace("()", "");

            ultimosCuatro = ultimosCuatro.Replace("...", "");

            ultimosCuatro = ultimosCuatro.Replace("(,)", "");

            ultimosCuatro = ultimosCuatro.Replace("$", "");


            TxtPrecio.Text = ultimosCuatro;
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtgDetallesdeFactura.Rows.Count == 0)
                {
                    MessageBox.Show("Tabla vacia, no hay elementos que borrar", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    error.SetError(BtnQuitar, "Tabla vacia, no hay elementos que borrar");
                }
                else
                {
                    Monto = Monto - Convert.ToDecimal(DtgDetallesdeFactura.CurrentRow.Cells[1].Value);

                    LBlsubtotal.Text = Monto.ToString();

                    lbl001.Text = Monto.ToString();

                    DtgDetallesdeFactura.Rows.Remove(DtgDetallesdeFactura.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                CmbPacientes.DataSource = paciente.CargarPacientes();

                CmbPacientes.DisplayMember = "Nombre";

                CmbPacientes.ValueMember = "Cod_paciente";

                DtpHora.Text = "00:00:00";

                Bindi.DataSource = examenes.Cargar();

                lstexamenes1.DataSource = Bindi;

                lstexamenes1.DisplayMember = "Titulo";

                lstexamenes1.ValueMember = "cod_examen";

                DtgDetallesdeFactura.Rows.Clear();

                TxtExamen.Clear();

                TxtPrecio.Clear();

                lbl001.Text = "00.00";

                LBlsubtotal.Text = "00.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgDetallesdeFactura_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void BtnNuevoServicio_Click(object sender, EventArgs e)
        {

            CmbPacientes.Enabled = true;

            DtpFecha.Enabled = true;

            DtpHora.Enabled = true;

            Btnagregar.Enabled = true;

            BtnQuitar.Enabled = true;

            BtnGuardar.Enabled = true;

            BtnCancelar.Enabled = true;

            BtnNuevoServicio.Enabled = false;

            try
            {
                CmbPacientes.DataSource = paciente.CargarPacientes();

                CmbPacientes.DisplayMember = "Nombre";

                CmbPacientes.ValueMember = "Cod_paciente";

                DtpHora.Text = "00:00:00";

                Bindi.DataSource = examenes.Cargar();

                lstexamenes1.DataSource = Bindi;

                lstexamenes1.DisplayMember = "Titulo";

                lstexamenes1.ValueMember = "cod_examen";

                DtgDetallesdeFactura.Rows.Clear();

                TxtExamen.Clear();

                TxtPrecio.Clear();

                lbl001.Text = "00.00";

                LBlsubtotal.Text = "00.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
