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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace Proyecto_de_Graduacion
{
    public partial class Frmservicio2 : Form
    {
        Facturacion_Model facturas = new Facturacion_Model();

        Paciente_Model paciente = new Paciente_Model();

        ErrorProvider error = new ErrorProvider();

        int NumeroRuc;

        string nombre;

        decimal subtotal, total;

        DateTime Date;

        TimeSpan Time;

        string Examen;

        decimal Monto = 0;

        string ultimosCuatro = "";

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

            LblFecha.Text = DateTime.Now.ToLongDateString();
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
            try
            {
                decimal total = 0;

                SaveFileDialog saveFile = new SaveFileDialog();

                saveFile.FileName = $@"Factura{NumeroRuc}.pdf ";

                string texto_Html = Properties.Resources.Facturas.ToString();
                texto_Html = texto_Html.Replace("@NumeroRuc", TxtCodigoFactura.Text);
                texto_Html = texto_Html.Replace("@Fecha_Actual", LblFecha.Text);
                texto_Html = texto_Html.Replace("@ClienteNombre", TxtPacientes.Text);
                texto_Html = texto_Html.Replace("@ClienteEdad", paciente.CargarEdad(TxtPacientes.Text).ToString());
                texto_Html = texto_Html.Replace("@ClienteTelefono", paciente.CargarTelefono(TxtPacientes.Text).ToString());
                texto_Html = texto_Html.Replace("@Fecha", facturas.CargarFecha(Convert.ToInt32(TxtCodigoFactura.Text)).ToLongDateString());
                texto_Html = texto_Html.Replace("@Hora", facturas.CargarHora(Convert.ToInt32(TxtCodigoFactura.Text)).TimeOfDay.ToString());
                string filas = string.Empty;

                foreach (DataGridViewRow item in DtgDetallesdeFactura.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + item.Cells[0].Value.ToString() + "</td>";
                    filas += "<td>" + item.Cells[1].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total += decimal.Parse(item.Cells[1].Value.ToString());
                }

                texto_Html = texto_Html.Replace("@filas", filas);

                texto_Html = texto_Html.Replace("@total", total.ToString());

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                        pdf.Open();

                        pdf.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Laboratorio1, System.Drawing.Imaging.ImageFormat.Png);

                        img.ScaleToFit(80,60);

                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        img.SetAbsolutePosition(pdf.LeftMargin,pdf.Top - 60);

                        pdf.Add(img);

                        using (StringReader sr = new StringReader(texto_Html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                        }
                        pdf.Close();

                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
    }
}
