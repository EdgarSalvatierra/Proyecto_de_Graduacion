namespace Proyecto_de_Graduacion
{
    partial class FrmNuevoServicio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoServicio));
            this.PnlFacturacion = new System.Windows.Forms.Panel();
            this.BtnX = new FontAwesome.Sharp.IconButton();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.PnlCarrito = new System.Windows.Forms.Panel();
            this.LblCita = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DtpHora = new System.Windows.Forms.DateTimePicker();
            this.LblHora = new System.Windows.Forms.Label();
            this.PnlRegistro = new System.Windows.Forms.Panel();
            this.TxtCodigoFactura = new System.Windows.Forms.Label();
            this.CmbPacientes = new System.Windows.Forms.ComboBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblCodigoFactura = new System.Windows.Forms.Label();
            this.Pnlexamenes = new System.Windows.Forms.Panel();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.lstexamenes1 = new System.Windows.Forms.ListBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblExamen = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtExamen = new System.Windows.Forms.TextBox();
            this.GbDetallesdefactura = new System.Windows.Forms.GroupBox();
            this.PnlTotal = new System.Windows.Forms.Panel();
            this.lbl001 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.LBlsubtotal = new System.Windows.Forms.Label();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevaVent = new System.Windows.Forms.Button();
            this.DtgDetallesdeFactura = new System.Windows.Forms.DataGridView();
            this.Examen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PnlFacturacion.SuspendLayout();
            this.PnlCarrito.SuspendLayout();
            this.PnlRegistro.SuspendLayout();
            this.Pnlexamenes.SuspendLayout();
            this.GbDetallesdefactura.SuspendLayout();
            this.PnlTotal.SuspendLayout();
            this.PnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesdeFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFacturacion
            // 
            this.PnlFacturacion.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlFacturacion.Controls.Add(this.BtnMinimizar);
            this.PnlFacturacion.Controls.Add(this.BtnX);
            this.PnlFacturacion.Controls.Add(this.LbTitulo);
            this.PnlFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFacturacion.Location = new System.Drawing.Point(0, 0);
            this.PnlFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlFacturacion.Name = "PnlFacturacion";
            this.PnlFacturacion.Size = new System.Drawing.Size(995, 60);
            this.PnlFacturacion.TabIndex = 1;
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
            this.BtnX.Location = new System.Drawing.Point(944, 1);
            this.BtnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(51, 56);
            this.BtnX.TabIndex = 29;
            this.BtnX.UseVisualStyleBackColor = false;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbTitulo.Location = new System.Drawing.Point(281, 15);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(274, 24);
            this.LbTitulo.TabIndex = 28;
            this.LbTitulo.Text = "Formulario de Facturacion";
            // 
            // PnlCarrito
            // 
            this.PnlCarrito.Controls.Add(this.LblCita);
            this.PnlCarrito.Controls.Add(this.DtpFecha);
            this.PnlCarrito.Controls.Add(this.DtpHora);
            this.PnlCarrito.Controls.Add(this.LblHora);
            this.PnlCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCarrito.Location = new System.Drawing.Point(0, 60);
            this.PnlCarrito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlCarrito.Name = "PnlCarrito";
            this.PnlCarrito.Size = new System.Drawing.Size(995, 63);
            this.PnlCarrito.TabIndex = 6;
            // 
            // LblCita
            // 
            this.LblCita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCita.AutoSize = true;
            this.LblCita.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCita.Location = new System.Drawing.Point(15, 24);
            this.LblCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCita.Name = "LblCita";
            this.LblCita.Size = new System.Drawing.Size(142, 22);
            this.LblCita.TabIndex = 40;
            this.LblCita.Text = "Fecha de Entrega";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpFecha.CustomFormat = "";
            this.DtpFecha.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(164, 19);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFecha.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(310, 29);
            this.DtpFecha.TabIndex = 38;
            this.DtpFecha.Value = new System.DateTime(2023, 12, 11, 0, 0, 0, 0);
            // 
            // DtpHora
            // 
            this.DtpHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DtpHora.CustomFormat = "";
            this.DtpHora.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHora.Location = new System.Drawing.Point(766, 19);
            this.DtpHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpHora.Name = "DtpHora";
            this.DtpHora.Size = new System.Drawing.Size(217, 29);
            this.DtpHora.TabIndex = 39;
            this.DtpHora.Value = new System.DateTime(2023, 11, 25, 0, 0, 0, 0);
            // 
            // LblHora
            // 
            this.LblHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(610, 24);
            this.LblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(134, 22);
            this.LblHora.TabIndex = 41;
            this.LblHora.Text = "Hora de Entrega";
            // 
            // PnlRegistro
            // 
            this.PnlRegistro.Controls.Add(this.TxtCodigoFactura);
            this.PnlRegistro.Controls.Add(this.CmbPacientes);
            this.PnlRegistro.Controls.Add(this.LblCliente);
            this.PnlRegistro.Controls.Add(this.LblCodigoFactura);
            this.PnlRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlRegistro.Location = new System.Drawing.Point(0, 123);
            this.PnlRegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlRegistro.Name = "PnlRegistro";
            this.PnlRegistro.Size = new System.Drawing.Size(995, 61);
            this.PnlRegistro.TabIndex = 7;
            // 
            // TxtCodigoFactura
            // 
            this.TxtCodigoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCodigoFactura.AutoSize = true;
            this.TxtCodigoFactura.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoFactura.Location = new System.Drawing.Point(160, 18);
            this.TxtCodigoFactura.Name = "TxtCodigoFactura";
            this.TxtCodigoFactura.Size = new System.Drawing.Size(30, 21);
            this.TxtCodigoFactura.TabIndex = 11;
            this.TxtCodigoFactura.Text = ".....";
            // 
            // CmbPacientes
            // 
            this.CmbPacientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPacientes.FormattingEnabled = true;
            this.CmbPacientes.Location = new System.Drawing.Point(766, 16);
            this.CmbPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbPacientes.Name = "CmbPacientes";
            this.CmbPacientes.Size = new System.Drawing.Size(217, 28);
            this.CmbPacientes.TabIndex = 3;
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(610, 19);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(77, 21);
            this.LblCliente.TabIndex = 2;
            this.LblCliente.Text = "Pacientes";
            // 
            // LblCodigoFactura
            // 
            this.LblCodigoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCodigoFactura.AutoSize = true;
            this.LblCodigoFactura.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoFactura.Location = new System.Drawing.Point(14, 18);
            this.LblCodigoFactura.Name = "LblCodigoFactura";
            this.LblCodigoFactura.Size = new System.Drawing.Size(124, 21);
            this.LblCodigoFactura.TabIndex = 0;
            this.LblCodigoFactura.Text = "Numero Factura";
            // 
            // Pnlexamenes
            // 
            this.Pnlexamenes.Controls.Add(this.BtnQuitar);
            this.Pnlexamenes.Controls.Add(this.Btnagregar);
            this.Pnlexamenes.Controls.Add(this.lstexamenes1);
            this.Pnlexamenes.Controls.Add(this.TxtPrecio);
            this.Pnlexamenes.Controls.Add(this.LblExamen);
            this.Pnlexamenes.Controls.Add(this.LblPrecio);
            this.Pnlexamenes.Controls.Add(this.TxtExamen);
            this.Pnlexamenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlexamenes.Location = new System.Drawing.Point(0, 184);
            this.Pnlexamenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlexamenes.Name = "Pnlexamenes";
            this.Pnlexamenes.Size = new System.Drawing.Size(995, 266);
            this.Pnlexamenes.TabIndex = 8;
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnQuitar.FlatAppearance.BorderSize = 0;
            this.BtnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuitar.Location = new System.Drawing.Point(772, 215);
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(179, 33);
            this.BtnQuitar.TabIndex = 10;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btnagregar.Location = new System.Drawing.Point(565, 215);
            this.Btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(179, 33);
            this.Btnagregar.TabIndex = 9;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // lstexamenes1
            // 
            this.lstexamenes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstexamenes1.FormattingEnabled = true;
            this.lstexamenes1.ItemHeight = 25;
            this.lstexamenes1.Location = new System.Drawing.Point(45, 19);
            this.lstexamenes1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstexamenes1.Name = "lstexamenes1";
            this.lstexamenes1.Size = new System.Drawing.Size(455, 229);
            this.lstexamenes1.TabIndex = 0;
            this.lstexamenes1.Click += new System.EventHandler(this.lstexamenes1_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(655, 140);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(289, 27);
            this.TxtPrecio.TabIndex = 8;
            // 
            // LblExamen
            // 
            this.LblExamen.AutoSize = true;
            this.LblExamen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExamen.Location = new System.Drawing.Point(554, 48);
            this.LblExamen.Name = "LblExamen";
            this.LblExamen.Size = new System.Drawing.Size(73, 20);
            this.LblExamen.TabIndex = 6;
            this.LblExamen.Text = "Examen";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(554, 149);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(60, 20);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtExamen
            // 
            this.TxtExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExamen.Location = new System.Drawing.Point(655, 44);
            this.TxtExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtExamen.Name = "TxtExamen";
            this.TxtExamen.Size = new System.Drawing.Size(289, 27);
            this.TxtExamen.TabIndex = 6;
            // 
            // GbDetallesdefactura
            // 
            this.GbDetallesdefactura.Controls.Add(this.PnlTotal);
            this.GbDetallesdefactura.Controls.Add(this.PnlOpciones);
            this.GbDetallesdefactura.Controls.Add(this.DtgDetallesdeFactura);
            this.GbDetallesdefactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbDetallesdefactura.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetallesdefactura.Location = new System.Drawing.Point(0, 466);
            this.GbDetallesdefactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDetallesdefactura.Name = "GbDetallesdefactura";
            this.GbDetallesdefactura.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbDetallesdefactura.Size = new System.Drawing.Size(995, 429);
            this.GbDetallesdefactura.TabIndex = 9;
            this.GbDetallesdefactura.TabStop = false;
            this.GbDetallesdefactura.Text = "Detalles de la Factura";
            // 
            // PnlTotal
            // 
            this.PnlTotal.Controls.Add(this.lbl001);
            this.PnlTotal.Controls.Add(this.LblTotal);
            this.PnlTotal.Controls.Add(this.SubTotal);
            this.PnlTotal.Controls.Add(this.LBlsubtotal);
            this.PnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlTotal.Location = new System.Drawing.Point(3, 299);
            this.PnlTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlTotal.Name = "PnlTotal";
            this.PnlTotal.Size = new System.Drawing.Size(989, 51);
            this.PnlTotal.TabIndex = 7;
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl001.Location = new System.Drawing.Point(564, 15);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(60, 22);
            this.lbl001.TabIndex = 7;
            this.lbl001.Text = "00.00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(503, 17);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(48, 20);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "Total";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(278, 17);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(77, 20);
            this.SubTotal.TabIndex = 6;
            this.SubTotal.Text = "SubTotal";
            // 
            // LBlsubtotal
            // 
            this.LBlsubtotal.AutoSize = true;
            this.LBlsubtotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBlsubtotal.Location = new System.Drawing.Point(395, 15);
            this.LBlsubtotal.Name = "LBlsubtotal";
            this.LBlsubtotal.Size = new System.Drawing.Size(60, 22);
            this.LBlsubtotal.TabIndex = 6;
            this.LBlsubtotal.Text = "00.00";
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.Controls.Add(this.BtnCancelar);
            this.PnlOpciones.Controls.Add(this.BtnGuardar);
            this.PnlOpciones.Controls.Add(this.BtnNuevaVent);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlOpciones.Location = new System.Drawing.Point(3, 350);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(989, 75);
            this.PnlOpciones.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(739, 20);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(223, 46);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Location = new System.Drawing.Point(399, 20);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(223, 46);
            this.BtnGuardar.TabIndex = 65;
            this.BtnGuardar.Text = "Terminar Servicio";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // BtnNuevaVent
            // 
            this.BtnNuevaVent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevaVent.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNuevaVent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaVent.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaVent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevaVent.Location = new System.Drawing.Point(42, 20);
            this.BtnNuevaVent.Name = "BtnNuevaVent";
            this.BtnNuevaVent.Size = new System.Drawing.Size(223, 46);
            this.BtnNuevaVent.TabIndex = 64;
            this.BtnNuevaVent.Text = "Nueva Venta";
            this.BtnNuevaVent.UseVisualStyleBackColor = false;
            this.BtnNuevaVent.Click += new System.EventHandler(this.BtnNuevaVent_Click);
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
            this.DtgDetallesdeFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Examen1,
            this.Precio1});
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
            this.DtgDetallesdeFactura.Location = new System.Drawing.Point(18, 30);
            this.DtgDetallesdeFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgDetallesdeFactura.Name = "DtgDetallesdeFactura";
            this.DtgDetallesdeFactura.ReadOnly = true;
            this.DtgDetallesdeFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgDetallesdeFactura.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgDetallesdeFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgDetallesdeFactura.RowTemplate.Height = 24;
            this.DtgDetallesdeFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgDetallesdeFactura.Size = new System.Drawing.Size(965, 261);
            this.DtgDetallesdeFactura.TabIndex = 1;
            this.DtgDetallesdeFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDetallesdeFactura_CellClick_1);
            // 
            // Examen1
            // 
            this.Examen1.HeaderText = "Examen";
            this.Examen1.MinimumWidth = 6;
            this.Examen1.Name = "Examen1";
            this.Examen1.ReadOnly = true;
            // 
            // Precio1
            // 
            this.Precio1.HeaderText = "Precio";
            this.Precio1.MinimumWidth = 6;
            this.Precio1.Name = "Precio1";
            this.Precio1.ReadOnly = true;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnMinimizar.Location = new System.Drawing.Point(889, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(49, 50);
            this.BtnMinimizar.TabIndex = 30;
            this.BtnMinimizar.Text = "-";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmNuevoServicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(995, 895);
            this.Controls.Add(this.GbDetallesdefactura);
            this.Controls.Add(this.Pnlexamenes);
            this.Controls.Add(this.PnlRegistro);
            this.Controls.Add(this.PnlCarrito);
            this.Controls.Add(this.PnlFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoServicio";
            this.Load += new System.EventHandler(this.FrmNuevoServicio_Load);
            this.PnlFacturacion.ResumeLayout(false);
            this.PnlFacturacion.PerformLayout();
            this.PnlCarrito.ResumeLayout(false);
            this.PnlCarrito.PerformLayout();
            this.PnlRegistro.ResumeLayout(false);
            this.PnlRegistro.PerformLayout();
            this.Pnlexamenes.ResumeLayout(false);
            this.Pnlexamenes.PerformLayout();
            this.GbDetallesdefactura.ResumeLayout(false);
            this.PnlTotal.ResumeLayout(false);
            this.PnlTotal.PerformLayout();
            this.PnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesdeFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFacturacion;
        private FontAwesome.Sharp.IconButton BtnX;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Panel PnlCarrito;
        private System.Windows.Forms.Label LblCita;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DateTimePicker DtpHora;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Panel PnlRegistro;
        private System.Windows.Forms.Label TxtCodigoFactura;
        private System.Windows.Forms.ComboBox CmbPacientes;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblCodigoFactura;
        private System.Windows.Forms.Panel Pnlexamenes;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.ListBox lstexamenes1;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblExamen;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtExamen;
        private System.Windows.Forms.GroupBox GbDetallesdefactura;
        private System.Windows.Forms.Panel PnlTotal;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label LBlsubtotal;
        private System.Windows.Forms.Panel PnlOpciones;
        private System.Windows.Forms.DataGridView DtgDetallesdeFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BtnNuevaVent;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnMinimizar;
    }
}