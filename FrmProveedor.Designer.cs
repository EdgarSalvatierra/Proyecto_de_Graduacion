namespace Proyecto_de_Graduacion
{
    partial class FrmProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.Pnlarriba = new System.Windows.Forms.Panel();
            this.LblSistemaLab = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Pnlencabezado = new System.Windows.Forms.Panel();
            this.TxtCodigo = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblRegistroCompras = new System.Windows.Forms.Label();
            this.Pnlgrid2 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.Btndardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.PnlBuscarProveedor = new System.Windows.Forms.Panel();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarProducto = new System.Windows.Forms.TextBox();
            this.Pnlok = new System.Windows.Forms.Panel();
            this.TxtCasacomercial = new System.Windows.Forms.TextBox();
            this.Lblcomercial = new System.Windows.Forms.Label();
            this.Lblproveedor2 = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.PnlProducto = new System.Windows.Forms.Panel();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgProveedor = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.Pnlarriba.SuspendLayout();
            this.Pnlencabezado.SuspendLayout();
            this.Pnlgrid2.SuspendLayout();
            this.PnlBuscarProveedor.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.Pnlok.SuspendLayout();
            this.PnlProducto.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnlarriba
            // 
            this.Pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.Pnlarriba.Controls.Add(this.LblSistemaLab);
            this.Pnlarriba.Controls.Add(this.BtnClose);
            this.Pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.Pnlarriba.Name = "Pnlarriba";
            this.Pnlarriba.Size = new System.Drawing.Size(800, 36);
            this.Pnlarriba.TabIndex = 14;
            // 
            // LblSistemaLab
            // 
            this.LblSistemaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSistemaLab.AutoSize = true;
            this.LblSistemaLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.LblSistemaLab.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemaLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSistemaLab.Location = new System.Drawing.Point(277, 7);
            this.LblSistemaLab.Name = "LblSistemaLab";
            this.LblSistemaLab.Size = new System.Drawing.Size(211, 19);
            this.LblSistemaLab.TabIndex = 15;
            this.LblSistemaLab.Text = "Sistema Socorro Lab";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClose.Location = new System.Drawing.Point(770, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 29);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Pnlencabezado
            // 
            this.Pnlencabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(179)))));
            this.Pnlencabezado.Controls.Add(this.TxtCodigo);
            this.Pnlencabezado.Controls.Add(this.LblProveedor);
            this.Pnlencabezado.Controls.Add(this.LblRegistroCompras);
            this.Pnlencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlencabezado.Location = new System.Drawing.Point(0, 36);
            this.Pnlencabezado.Name = "Pnlencabezado";
            this.Pnlencabezado.Size = new System.Drawing.Size(800, 55);
            this.Pnlencabezado.TabIndex = 15;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCodigo.AutoSize = true;
            this.TxtCodigo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCodigo.Location = new System.Drawing.Point(508, 18);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(29, 19);
            this.TxtCodigo.TabIndex = 2;
            this.TxtCodigo.Text = "....";
            // 
            // LblProveedor
            // 
            this.LblProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblProveedor.Location = new System.Drawing.Point(435, 20);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(67, 21);
            this.LblProveedor.TabIndex = 1;
            this.LblProveedor.Text = "Codigo";
            // 
            // LblRegistroCompras
            // 
            this.LblRegistroCompras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblRegistroCompras.AutoSize = true;
            this.LblRegistroCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRegistroCompras.Location = new System.Drawing.Point(20, 18);
            this.LblRegistroCompras.Name = "LblRegistroCompras";
            this.LblRegistroCompras.Size = new System.Drawing.Size(207, 23);
            this.LblRegistroCompras.TabIndex = 0;
            this.LblRegistroCompras.Text = "Registro de Productos";
            // 
            // Pnlgrid2
            // 
            this.Pnlgrid2.Controls.Add(this.BtnGuardar);
            this.Pnlgrid2.Controls.Add(this.BtnEditar);
            this.Pnlgrid2.Controls.Add(this.Btndardebaja);
            this.Pnlgrid2.Controls.Add(this.BtnNuevo);
            this.Pnlgrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlgrid2.Location = new System.Drawing.Point(0, 583);
            this.Pnlgrid2.Name = "Pnlgrid2";
            this.Pnlgrid2.Size = new System.Drawing.Size(800, 76);
            this.Pnlgrid2.TabIndex = 18;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnGuardar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuardar.IconSize = 20;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(412, 19);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(170, 44);
            this.BtnGuardar.TabIndex = 61;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Btndardebaja
            // 
            this.Btndardebaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btndardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btndardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btndardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndardebaja.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.Btndardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btndardebaja.IconSize = 20;
            this.Btndardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndardebaja.Location = new System.Drawing.Point(623, 19);
            this.Btndardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndardebaja.Name = "Btndardebaja";
            this.Btndardebaja.Size = new System.Drawing.Size(165, 44);
            this.Btndardebaja.TabIndex = 60;
            this.Btndardebaja.Text = "Dar de Baja";
            this.Btndardebaja.UseVisualStyleBackColor = false;
            this.Btndardebaja.Click += new System.EventHandler(this.Btndardebaja_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevo.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevo.IconSize = 20;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(24, 19);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(170, 44);
            this.BtnNuevo.TabIndex = 58;
            this.BtnNuevo.Text = "Nuevo ";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PnlBuscarProveedor
            // 
            this.PnlBuscarProveedor.Controls.Add(this.LblBuscar);
            this.PnlBuscarProveedor.Controls.Add(this.BtnRefrescar);
            this.PnlBuscarProveedor.Controls.Add(this.ICNBuscador);
            this.PnlBuscarProveedor.Controls.Add(this.PnlBuscare);
            this.PnlBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBuscarProveedor.Location = new System.Drawing.Point(0, 91);
            this.PnlBuscarProveedor.Name = "PnlBuscarProveedor";
            this.PnlBuscarProveedor.Size = new System.Drawing.Size(800, 56);
            this.PnlBuscarProveedor.TabIndex = 20;
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBuscar.Location = new System.Drawing.Point(20, 16);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(66, 21);
            this.LblBuscar.TabIndex = 6;
            this.LblBuscar.Text = "Buscar";
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.BtnRefrescar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRefrescar.IconSize = 25;
            this.BtnRefrescar.Location = new System.Drawing.Point(721, 9);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(46, 38);
            this.BtnRefrescar.TabIndex = 79;
            this.BtnRefrescar.UseVisualStyleBackColor = false;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // ICNBuscador
            // 
            this.ICNBuscador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ICNBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICNBuscador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ICNBuscador.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.ICNBuscador.IconColor = System.Drawing.SystemColors.Highlight;
            this.ICNBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNBuscador.IconSize = 30;
            this.ICNBuscador.Location = new System.Drawing.Point(670, 10);
            this.ICNBuscador.Name = "ICNBuscador";
            this.ICNBuscador.Size = new System.Drawing.Size(45, 37);
            this.ICNBuscador.TabIndex = 78;
            this.ICNBuscador.UseVisualStyleBackColor = false;
            this.ICNBuscador.Click += new System.EventHandler(this.ICNBuscador_Click);
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarProducto);
            this.PnlBuscare.Location = new System.Drawing.Point(119, 9);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(545, 35);
            this.PnlBuscare.TabIndex = 77;
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarProducto.Location = new System.Drawing.Point(18, 6);
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.Size = new System.Drawing.Size(522, 20);
            this.TxtBuscarProducto.TabIndex = 0;
            this.TxtBuscarProducto.Text = "Buscar";
            this.TxtBuscarProducto.Enter += new System.EventHandler(this.TxtBuscarProducto_Enter);
            // 
            // Pnlok
            // 
            this.Pnlok.Controls.Add(this.TxtCasacomercial);
            this.Pnlok.Controls.Add(this.Lblcomercial);
            this.Pnlok.Controls.Add(this.Lblproveedor2);
            this.Pnlok.Controls.Add(this.TxtProveedor);
            this.Pnlok.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlok.Location = new System.Drawing.Point(0, 147);
            this.Pnlok.Name = "Pnlok";
            this.Pnlok.Size = new System.Drawing.Size(800, 51);
            this.Pnlok.TabIndex = 21;
            // 
            // TxtCasacomercial
            // 
            this.TxtCasacomercial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCasacomercial.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCasacomercial.Location = new System.Drawing.Point(578, 13);
            this.TxtCasacomercial.Name = "TxtCasacomercial";
            this.TxtCasacomercial.Size = new System.Drawing.Size(189, 28);
            this.TxtCasacomercial.TabIndex = 5;
            // 
            // Lblcomercial
            // 
            this.Lblcomercial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lblcomercial.AutoSize = true;
            this.Lblcomercial.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcomercial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lblcomercial.Location = new System.Drawing.Point(435, 16);
            this.Lblcomercial.Name = "Lblcomercial";
            this.Lblcomercial.Size = new System.Drawing.Size(137, 21);
            this.Lblcomercial.TabIndex = 4;
            this.Lblcomercial.Text = "Casa Comercial";
            // 
            // Lblproveedor2
            // 
            this.Lblproveedor2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lblproveedor2.AutoSize = true;
            this.Lblproveedor2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblproveedor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lblproveedor2.Location = new System.Drawing.Point(20, 16);
            this.Lblproveedor2.Name = "Lblproveedor2";
            this.Lblproveedor2.Size = new System.Drawing.Size(93, 21);
            this.Lblproveedor2.TabIndex = 3;
            this.Lblproveedor2.Text = "Proveedor";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtProveedor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(119, 13);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(189, 28);
            this.TxtProveedor.TabIndex = 0;
            // 
            // PnlProducto
            // 
            this.PnlProducto.Controls.Add(this.TxtPrecio);
            this.PnlProducto.Controls.Add(this.LblPrecio);
            this.PnlProducto.Controls.Add(this.LblProducto);
            this.PnlProducto.Controls.Add(this.TxtProducto);
            this.PnlProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProducto.Location = new System.Drawing.Point(0, 198);
            this.PnlProducto.Name = "PnlProducto";
            this.PnlProducto.Size = new System.Drawing.Size(800, 51);
            this.PnlProducto.TabIndex = 22;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtPrecio.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(578, 13);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(189, 28);
            this.TxtPrecio.TabIndex = 5;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPrecio.Location = new System.Drawing.Point(435, 16);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(61, 21);
            this.LblPrecio.TabIndex = 4;
            this.LblPrecio.Text = "Precio";
            // 
            // LblProducto
            // 
            this.LblProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblProducto.Location = new System.Drawing.Point(20, 16);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(82, 21);
            this.LblProducto.TabIndex = 3;
            this.LblProducto.Text = "Producto";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtProducto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(119, 13);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(189, 28);
            this.TxtProducto.TabIndex = 0;
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgProveedor);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(0, 249);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(800, 334);
            this.PnlGrid.TabIndex = 23;
            // 
            // DtgProveedor
            // 
            this.DtgProveedor.AllowUserToAddRows = false;
            this.DtgProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgProveedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgProveedor.ColumnHeadersHeight = 40;
            this.DtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgProveedor.EnableHeadersVisualStyles = false;
            this.DtgProveedor.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgProveedor.Location = new System.Drawing.Point(12, 8);
            this.DtgProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgProveedor.Name = "DtgProveedor";
            this.DtgProveedor.ReadOnly = true;
            this.DtgProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgProveedor.RowHeadersWidth = 65;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgProveedor.RowTemplate.Height = 24;
            this.DtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgProveedor.Size = new System.Drawing.Size(776, 306);
            this.DtgProveedor.TabIndex = 3;
            this.DtgProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgProveedor_CellClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(220, 19);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(169, 44);
            this.BtnEditar.TabIndex = 59;
            this.BtnEditar.Text = "Editar ";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlProducto);
            this.Controls.Add(this.Pnlok);
            this.Controls.Add(this.PnlBuscarProveedor);
            this.Controls.Add(this.Pnlgrid2);
            this.Controls.Add(this.Pnlencabezado);
            this.Controls.Add(this.Pnlarriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.Pnlarriba.ResumeLayout(false);
            this.Pnlarriba.PerformLayout();
            this.Pnlencabezado.ResumeLayout(false);
            this.Pnlencabezado.PerformLayout();
            this.Pnlgrid2.ResumeLayout(false);
            this.PnlBuscarProveedor.ResumeLayout(false);
            this.PnlBuscarProveedor.PerformLayout();
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.Pnlok.ResumeLayout(false);
            this.Pnlok.PerformLayout();
            this.PnlProducto.ResumeLayout(false);
            this.PnlProducto.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlarriba;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblSistemaLab;
        private System.Windows.Forms.Panel Pnlencabezado;
        private System.Windows.Forms.Label TxtCodigo;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblRegistroCompras;
        private System.Windows.Forms.Panel Pnlgrid2;
        private FontAwesome.Sharp.IconButton Btndardebaja;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Panel PnlBuscarProveedor;
        private System.Windows.Forms.Panel Pnlok;
        private System.Windows.Forms.TextBox TxtCasacomercial;
        private System.Windows.Forms.Label Lblcomercial;
        private System.Windows.Forms.Label Lblproveedor2;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Panel PnlProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblBuscar;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarProducto;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgProveedor;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}