namespace Proyecto_de_Graduacion
{
    partial class Frmservicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlFacturacion = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LblFech = new System.Windows.Forms.Label();
            this.Pnllista = new System.Windows.Forms.Panel();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblCodigoFactura = new System.Windows.Forms.Label();
            this.LblExamen = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPacientes = new System.Windows.Forms.Label();
            this.TxtCodigoFactura = new System.Windows.Forms.Label();
            this.TxtExamen = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.Label();
            this.GbDetallesdefactura = new System.Windows.Forms.GroupBox();
            this.PnlTotal = new System.Windows.Forms.Panel();
            this.lbl001 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.LBlsubtotal = new System.Windows.Forms.Label();
            this.DtgDetallesdeFactura = new System.Windows.Forms.DataGridView();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.BtnImprimir = new FontAwesome.Sharp.IconButton();
            this.BtnX = new FontAwesome.Sharp.IconButton();
            this.PnlFacturacion.SuspendLayout();
            this.Pnllista.SuspendLayout();
            this.GbDetallesdefactura.SuspendLayout();
            this.PnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesdeFactura)).BeginInit();
            this.PnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFacturacion
            // 
            this.PnlFacturacion.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlFacturacion.Controls.Add(this.BtnX);
            this.PnlFacturacion.Controls.Add(this.LblFecha);
            this.PnlFacturacion.Controls.Add(this.LbTitulo);
            this.PnlFacturacion.Controls.Add(this.LblFech);
            this.PnlFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFacturacion.Location = new System.Drawing.Point(0, 0);
            this.PnlFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlFacturacion.Name = "PnlFacturacion";
            this.PnlFacturacion.Size = new System.Drawing.Size(943, 60);
            this.PnlFacturacion.TabIndex = 2;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFecha.Location = new System.Drawing.Point(798, 15);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(29, 20);
            this.LblFecha.TabIndex = 7;
            this.LblFecha.Text = "....";
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbTitulo.Location = new System.Drawing.Point(332, 15);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(274, 24);
            this.LbTitulo.TabIndex = 28;
            this.LbTitulo.Text = "Formulario de Facturacion";
            // 
            // LblFech
            // 
            this.LblFech.AutoSize = true;
            this.LblFech.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFech.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFech.Location = new System.Drawing.Point(728, 15);
            this.LblFech.Name = "LblFech";
            this.LblFech.Size = new System.Drawing.Size(56, 20);
            this.LblFech.TabIndex = 6;
            this.LblFech.Text = "Fecha";
            // 
            // Pnllista
            // 
            this.Pnllista.Controls.Add(this.TxtPrecio);
            this.Pnllista.Controls.Add(this.TxtExamen);
            this.Pnllista.Controls.Add(this.TxtCodigoFactura);
            this.Pnllista.Controls.Add(this.TxtPacientes);
            this.Pnllista.Controls.Add(this.LblCliente);
            this.Pnllista.Controls.Add(this.LblCodigoFactura);
            this.Pnllista.Controls.Add(this.LblExamen);
            this.Pnllista.Controls.Add(this.LblPrecio);
            this.Pnllista.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnllista.Location = new System.Drawing.Point(0, 60);
            this.Pnllista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnllista.Name = "Pnllista";
            this.Pnllista.Size = new System.Drawing.Size(943, 106);
            this.Pnllista.TabIndex = 11;
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(40, 73);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(85, 20);
            this.LblCliente.TabIndex = 2;
            this.LblCliente.Text = "Pacientes";
            // 
            // LblCodigoFactura
            // 
            this.LblCodigoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCodigoFactura.AutoSize = true;
            this.LblCodigoFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoFactura.Location = new System.Drawing.Point(40, 24);
            this.LblCodigoFactura.Name = "LblCodigoFactura";
            this.LblCodigoFactura.Size = new System.Drawing.Size(135, 20);
            this.LblCodigoFactura.TabIndex = 0;
            this.LblCodigoFactura.Text = "Numero Factura";
            // 
            // LblExamen
            // 
            this.LblExamen.AutoSize = true;
            this.LblExamen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExamen.Location = new System.Drawing.Point(624, 25);
            this.LblExamen.Name = "LblExamen";
            this.LblExamen.Size = new System.Drawing.Size(73, 20);
            this.LblExamen.TabIndex = 6;
            this.LblExamen.Text = "Examen";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(624, 72);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(60, 20);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtPacientes
            // 
            this.TxtPacientes.AutoSize = true;
            this.TxtPacientes.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPacientes.Location = new System.Drawing.Point(192, 72);
            this.TxtPacientes.Name = "TxtPacientes";
            this.TxtPacientes.Size = new System.Drawing.Size(30, 21);
            this.TxtPacientes.TabIndex = 9;
            this.TxtPacientes.Text = ".....";
            // 
            // TxtCodigoFactura
            // 
            this.TxtCodigoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCodigoFactura.AutoSize = true;
            this.TxtCodigoFactura.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoFactura.Location = new System.Drawing.Point(192, 23);
            this.TxtCodigoFactura.Name = "TxtCodigoFactura";
            this.TxtCodigoFactura.Size = new System.Drawing.Size(30, 21);
            this.TxtCodigoFactura.TabIndex = 10;
            this.TxtCodigoFactura.Text = ".....";
            // 
            // TxtExamen
            // 
            this.TxtExamen.AutoSize = true;
            this.TxtExamen.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExamen.Location = new System.Drawing.Point(713, 24);
            this.TxtExamen.Name = "TxtExamen";
            this.TxtExamen.Size = new System.Drawing.Size(30, 21);
            this.TxtExamen.TabIndex = 11;
            this.TxtExamen.Text = ".....";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.AutoSize = true;
            this.TxtPrecio.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(713, 71);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(30, 21);
            this.TxtPrecio.TabIndex = 12;
            this.TxtPrecio.Text = ".....";
            // 
            // GbDetallesdefactura
            // 
            this.GbDetallesdefactura.Controls.Add(this.PnlTotal);
            this.GbDetallesdefactura.Controls.Add(this.DtgDetallesdeFactura);
            this.GbDetallesdefactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbDetallesdefactura.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetallesdefactura.Location = new System.Drawing.Point(0, 166);
            this.GbDetallesdefactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDetallesdefactura.Name = "GbDetallesdefactura";
            this.GbDetallesdefactura.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDetallesdefactura.Size = new System.Drawing.Size(943, 427);
            this.GbDetallesdefactura.TabIndex = 12;
            this.GbDetallesdefactura.TabStop = false;
            // 
            // PnlTotal
            // 
            this.PnlTotal.Controls.Add(this.lbl001);
            this.PnlTotal.Controls.Add(this.LblTotal);
            this.PnlTotal.Controls.Add(this.SubTotal);
            this.PnlTotal.Controls.Add(this.LBlsubtotal);
            this.PnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlTotal.Location = new System.Drawing.Point(3, 355);
            this.PnlTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlTotal.Name = "PnlTotal";
            this.PnlTotal.Size = new System.Drawing.Size(937, 68);
            this.PnlTotal.TabIndex = 7;
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl001.Location = new System.Drawing.Point(411, 20);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(60, 22);
            this.lbl001.TabIndex = 7;
            this.lbl001.Text = "00.00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(350, 22);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(48, 20);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "Total";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(29, 22);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(77, 20);
            this.SubTotal.TabIndex = 6;
            this.SubTotal.Text = "SubTotal";
            // 
            // LBlsubtotal
            // 
            this.LBlsubtotal.AutoSize = true;
            this.LBlsubtotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBlsubtotal.Location = new System.Drawing.Point(146, 20);
            this.LBlsubtotal.Name = "LBlsubtotal";
            this.LBlsubtotal.Size = new System.Drawing.Size(60, 22);
            this.LBlsubtotal.TabIndex = 6;
            this.LBlsubtotal.Text = "00.00";
            // 
            // DtgDetallesdeFactura
            // 
            this.DtgDetallesdeFactura.AllowUserToAddRows = false;
            this.DtgDetallesdeFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgDetallesdeFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDetallesdeFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDetallesdeFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgDetallesdeFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgDetallesdeFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgDetallesdeFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgDetallesdeFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDetallesdeFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDetallesdeFactura.ColumnHeadersHeight = 40;
            this.DtgDetallesdeFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDetallesdeFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgDetallesdeFactura.EnableHeadersVisualStyles = false;
            this.DtgDetallesdeFactura.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgDetallesdeFactura.Location = new System.Drawing.Point(11, 30);
            this.DtgDetallesdeFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgDetallesdeFactura.Name = "DtgDetallesdeFactura";
            this.DtgDetallesdeFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgDetallesdeFactura.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgDetallesdeFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgDetallesdeFactura.RowTemplate.Height = 24;
            this.DtgDetallesdeFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgDetallesdeFactura.Size = new System.Drawing.Size(1012, 316);
            this.DtgDetallesdeFactura.TabIndex = 1;
            this.DtgDetallesdeFactura.Click += new System.EventHandler(this.DtgDetallesdeFactura_Click);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.Controls.Add(this.BtnImprimir);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOpciones.Location = new System.Drawing.Point(0, 593);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(943, 66);
            this.PnlOpciones.TabIndex = 13;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnImprimir.IconColor = System.Drawing.Color.White;
            this.BtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnImprimir.IconSize = 30;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(357, 16);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(223, 46);
            this.BtnImprimir.TabIndex = 3;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnX
            // 
            this.BtnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnX.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnX.FlatAppearance.BorderSize = 0;
            this.BtnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnX.IconColor = System.Drawing.Color.White;
            this.BtnX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnX.IconSize = 20;
            this.BtnX.Location = new System.Drawing.Point(893, 1);
            this.BtnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(51, 56);
            this.BtnX.TabIndex = 29;
            this.BtnX.UseVisualStyleBackColor = false;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // Frmservicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 664);
            this.Controls.Add(this.PnlOpciones);
            this.Controls.Add(this.GbDetallesdefactura);
            this.Controls.Add(this.Pnllista);
            this.Controls.Add(this.PnlFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmservicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frmservicio2_Load);
            this.PnlFacturacion.ResumeLayout(false);
            this.PnlFacturacion.PerformLayout();
            this.Pnllista.ResumeLayout(false);
            this.Pnllista.PerformLayout();
            this.GbDetallesdefactura.ResumeLayout(false);
            this.PnlTotal.ResumeLayout(false);
            this.PnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesdeFactura)).EndInit();
            this.PnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFacturacion;
        private FontAwesome.Sharp.IconButton BtnX;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LblFech;
        private System.Windows.Forms.Panel Pnllista;
        private System.Windows.Forms.Label TxtPrecio;
        private System.Windows.Forms.Label TxtExamen;
        private System.Windows.Forms.Label TxtCodigoFactura;
        private System.Windows.Forms.Label TxtPacientes;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblCodigoFactura;
        private System.Windows.Forms.Label LblExamen;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.GroupBox GbDetallesdefactura;
        private System.Windows.Forms.Panel PnlTotal;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label LBlsubtotal;
        private System.Windows.Forms.DataGridView DtgDetallesdeFactura;
        private System.Windows.Forms.Panel PnlOpciones;
        private FontAwesome.Sharp.IconButton BtnImprimir;
    }
}