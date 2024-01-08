using Capa_Modelo.ViewModel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class FrmNuevaCompra : Form
    {
        Compras_Model compras = new Compras_Model();

        ErrorProvider error = new ErrorProvider();
        public FrmNuevaCompra()
        {
            InitializeComponent();
        }
        private void FrmNuevaCompra_Load(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(TxtCantidad.Text)
                && !string.IsNullOrWhiteSpace(LBlsubtotal.Text)
                && !string.IsNullOrWhiteSpace(lbl001.Text) &&
                !string.IsNullOrWhiteSpace(Txtcasacomerciales.Text)
                && !string.IsNullOrWhiteSpace(TxtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(TxtProducto.Text) && !string.IsNullOrWhiteSpace(CmbProveedor.Text)))
            {
                if (DtgCompra.Rows.Count == 0)
                {
                    MessageBox.Show("No ha elegido ningun examen, por favor elija uno", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    error.SetError(DtgCompra, "Error");
                }
                else
                {
                    decimal total = 0;

                    SaveFileDialog saveFile = new SaveFileDialog();

                    saveFile.FileName = $@"PedidoaDistribuidora: {CmbProveedor.Text}.pdf ";

                    string texto_html = Properties.Resources.FacturaPedido;

                    texto_html = texto_html.Replace("@Fecha", DateTime.Now.ToLongDateString());

                    texto_html = texto_html.Replace("@Proveedor", CmbProveedor.Text.ToString());

                    texto_html = texto_html.Replace("@Distribuidora", Txtcasacomerciales.Text.ToString());

                    string filas = string.Empty;

                    foreach (DataGridViewRow item in DtgCompra.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + item.Cells[0].Value.ToString() + "</td>";
                        filas += "<td>" + item.Cells[1].Value.ToString() + "</td>";
                        filas += "<td>" + item.Cells[2].Value.ToString() + "</td>";
                        filas += "<td>" + item.Cells[3].Value.ToString() + "</td>";
                        filas += "<td>" + item.Cells[4].Value.ToString() + "</td>";
                        filas += "</tr>";
                        total += decimal.Parse(item.Cells[4].Value.ToString());
                    }
                    texto_html = texto_html.Replace("@filas", filas);

                    texto_html = texto_html.Replace("@total", total.ToString());

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                        {
                            Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                            PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                            pdf.Open();

                            pdf.Add(new Phrase(""));

                            using (StringReader sr = new StringReader(texto_html))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                            }
                            pdf.Close();

                            stream.Close();
                        }                  
                    }
                    compras.InsertarPedidos(TxtProducto.Text, Convert.ToDecimal(TxtPrecio.Text), Convert.ToInt32(TxtCantidad.Text), Convert.ToDecimal(LBlsubtotal.Text), Convert.ToDecimal(lbl001.Text), CmbProveedor.Text.ToString());

                    MessageBox.Show($"Se ha realizado el pedido exitosamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            decimal Monto = 0;
            if (!string.IsNullOrWhiteSpace(CmbProveedor.Text) && !string.IsNullOrWhiteSpace(TxtPrecio.Text) && !string.IsNullOrWhiteSpace(Txtcasacomerciales.Text) && !string.IsNullOrWhiteSpace(TxtProducto.Text) && !string.IsNullOrWhiteSpace(TxtCantidad.Text))
            {
                try
                {
                    if (DtgCompra.Rows.Count  == 0)
                    {
                        MessageBox.Show("No hay examenes disponibles", "Systema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {            
                        int n = DtgCompra.Rows.Add();

                        DtgCompra.Rows[n].Cells[0].Value = TxtProducto.Text;

                        DtgCompra.Rows[n].Cells[1].Value = TxtPrecio.Text;

                        DtgCompra.Rows[n].Cells[2].Value = TxtCantidad.Text;

                        DtgCompra.Rows[n].Cells[3].Value = Convert.ToDecimal(TxtPrecio.Text) * Convert.ToInt32(TxtCantidad.Text);

                        Monto = Monto + Convert.ToDecimal(DtgCompra.CurrentRow.Cells[3].Value);

                        LBlsubtotal.Text = Monto.ToString();

                        lbl001.Text = Monto.ToString();

                        TxtProducto.Clear();

                        TxtCantidad.Clear();

                        Txtcasacomerciales.Clear();

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
        private void BtnProveedor_Click(object sender, EventArgs e)
        {

        }
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            decimal Monto = 0;
            try
            {
                if (DtgCompra.Rows.Count == 0)
                {
                    MessageBox.Show("Tabla vacia, no hay elementos que borrar", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    error.SetError(BtnQuitar, "Tabla vacia, no hay elementos que borrar");
                }
                else
                {
                    Monto = Monto - Convert.ToDecimal(DtgCompra.CurrentRow.Cells[1].Value);

                    LBlsubtotal.Text = Monto.ToString();

                    lbl001.Text = Monto.ToString();

                    DtgCompra.Rows.Remove(DtgCompra.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
