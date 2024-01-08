namespace Proyecto_de_Graduacion
{
    partial class FrmNuevaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlFacturacion = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFech = new System.Windows.Forms.Label();
            this.BtnX = new FontAwesome.Sharp.IconButton();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.PnlCarrito = new System.Windows.Forms.Panel();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.Txtcasacomerciales = new System.Windows.Forms.TextBox();
            this.LblCasacomercial = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.PnlProducto = new System.Windows.Forms.Panel();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgCompra = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlGuardar = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.Pnlsubtotal = new System.Windows.Forms.Panel();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Pnlsub = new System.Windows.Forms.Panel();
            this.lbl001 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.LBlsubtotal = new System.Windows.Forms.Label();
            this.PnlFacturacion.SuspendLayout();
            this.PnlCarrito.SuspendLayout();
            this.PnlProducto.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompra)).BeginInit();
            this.PnlGuardar.SuspendLayout();
            this.Pnlsubtotal.SuspendLayout();
            this.Pnlsub.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFacturacion
            // 
            this.PnlFacturacion.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlFacturacion.Controls.Add(this.LblFecha);
            this.PnlFacturacion.Controls.Add(this.LblFech);
            this.PnlFacturacion.Controls.Add(this.BtnX);
            this.PnlFacturacion.Controls.Add(this.LbTitulo);
            this.PnlFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFacturacion.Location = new System.Drawing.Point(0, 0);
            this.PnlFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlFacturacion.Name = "PnlFacturacion";
            this.PnlFacturacion.Size = new System.Drawing.Size(959, 60);
            this.PnlFacturacion.TabIndex = 2;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFecha.Location = new System.Drawing.Point(667, 19);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(24, 17);
            this.LblFecha.TabIndex = 31;
            this.LblFecha.Text = "....";
            // 
            // LblFech
            // 
            this.LblFech.AutoSize = true;
            this.LblFech.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFech.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFech.Location = new System.Drawing.Point(605, 19);
            this.LblFech.Name = "LblFech";
            this.LblFech.Size = new System.Drawing.Size(56, 20);
            this.LblFech.TabIndex = 30;
            this.LblFech.Text = "Fecha";
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
            this.BtnX.Location = new System.Drawing.Point(908, 1);
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
            this.LbTitulo.Location = new System.Drawing.Point(298, 15);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(235, 24);
            this.LbTitulo.TabIndex = 28;
            this.LbTitulo.Text = "Formulario de Compra";
            // 
            // PnlCarrito
            // 
            this.PnlCarrito.Controls.Add(this.BtnProveedor);
            this.PnlCarrito.Controls.Add(this.CmbProveedor);
            this.PnlCarrito.Controls.Add(this.Txtcasacomerciales);
            this.PnlCarrito.Controls.Add(this.LblCasacomercial);
            this.PnlCarrito.Controls.Add(this.LblProveedor);
            this.PnlCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCarrito.Location = new System.Drawing.Point(0, 60);
            this.PnlCarrito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlCarrito.Name = "PnlCarrito";
            this.PnlCarrito.Size = new System.Drawing.Size(959, 63);
            this.PnlCarrito.TabIndex = 7;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.Location = new System.Drawing.Point(399, 17);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(42, 30);
            this.BtnProveedor.TabIndex = 5;
            this.BtnProveedor.Text = "....";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbProveedor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(203, 17);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(186, 27);
            this.CmbProveedor.TabIndex = 4;
            // 
            // Txtcasacomerciales
            // 
            this.Txtcasacomerciales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txtcasacomerciales.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcasacomerciales.Location = new System.Drawing.Point(699, 20);
            this.Txtcasacomerciales.Name = "Txtcasacomerciales";
            this.Txtcasacomerciales.Size = new System.Drawing.Size(250, 27);
            this.Txtcasacomerciales.TabIndex = 3;
            // 
            // LblCasacomercial
            // 
            this.LblCasacomercial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCasacomercial.AutoSize = true;
            this.LblCasacomercial.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasacomercial.Location = new System.Drawing.Point(521, 20);
            this.LblCasacomercial.Name = "LblCasacomercial";
            this.LblCasacomercial.Size = new System.Drawing.Size(143, 19);
            this.LblCasacomercial.TabIndex = 2;
            this.LblCasacomercial.Text = "Casa Comerciales";
            // 
            // LblProveedor
            // 
            this.LblProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(25, 20);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(172, 19);
            this.LblProveedor.TabIndex = 0;
            this.LblProveedor.Text = "Nombre del Proveedor";
            // 
            // PnlProducto
            // 
            this.PnlProducto.Controls.Add(this.TxtCantidad);
            this.PnlProducto.Controls.Add(this.LblCantidad);
            this.PnlProducto.Controls.Add(this.TxtPrecio);
            this.PnlProducto.Controls.Add(this.LblPrecio);
            this.PnlProducto.Controls.Add(this.TxtProducto);
            this.PnlProducto.Controls.Add(this.LblNombreProducto);
            this.PnlProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProducto.Location = new System.Drawing.Point(0, 123);
            this.PnlProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlProducto.Name = "PnlProducto";
            this.PnlProducto.Size = new System.Drawing.Size(959, 63);
            this.PnlProducto.TabIndex = 8;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(700, 12);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 27);
            this.TxtCantidad.TabIndex = 5;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(587, 17);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 19);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(468, 15);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(97, 27);
            this.TxtPrecio.TabIndex = 3;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(405, 20);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 19);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(203, 15);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(186, 27);
            this.TxtProducto.TabIndex = 1;
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(25, 20);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(163, 19);
            this.LblNombreProducto.TabIndex = 0;
            this.LblNombreProducto.Text = "Nombre del Producto";
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgCompra);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGrid.Location = new System.Drawing.Point(0, 186);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(959, 332);
            this.PnlGrid.TabIndex = 11;
            // 
            // DtgCompra
            // 
            this.DtgCompra.AllowUserToAddRows = false;
            this.DtgCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            this.DtgCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.DtgCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCompra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.DtgCompra.ColumnHeadersHeight = 40;
            this.DtgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.Importe});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCompra.DefaultCellStyle = dataGridViewCellStyle28;
            this.DtgCompra.EnableHeadersVisualStyles = false;
            this.DtgCompra.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.Location = new System.Drawing.Point(12, 8);
            this.DtgCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgCompra.Name = "DtgCompra";
            this.DtgCompra.ReadOnly = true;
            this.DtgCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DtgCompra.RowHeadersWidth = 65;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgCompra.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.DtgCompra.RowTemplate.Height = 24;
            this.DtgCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCompra.Size = new System.Drawing.Size(935, 304);
            this.DtgCompra.TabIndex = 3;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Unitario";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // PnlGuardar
            // 
            this.PnlGuardar.Controls.Add(this.BtnCancelar);
            this.PnlGuardar.Controls.Add(this.BtnGuardar);
            this.PnlGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlGuardar.Location = new System.Drawing.Point(0, 639);
            this.PnlGuardar.Name = "PnlGuardar";
            this.PnlGuardar.Size = new System.Drawing.Size(959, 66);
            this.PnlGuardar.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 20;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(609, 13);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(275, 40);
            this.BtnCancelar.TabIndex = 59;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuardar.IconSize = 20;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(68, 13);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(276, 40);
            this.BtnGuardar.TabIndex = 58;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Pnlsubtotal
            // 
            this.Pnlsubtotal.Controls.Add(this.BtnQuitar);
            this.Pnlsubtotal.Controls.Add(this.Btnagregar);
            this.Pnlsubtotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlsubtotal.Location = new System.Drawing.Point(0, 591);
            this.Pnlsubtotal.Name = "Pnlsubtotal";
            this.Pnlsubtotal.Size = new System.Drawing.Size(959, 48);
            this.Pnlsubtotal.TabIndex = 12;
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnQuitar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnQuitar.FlatAppearance.BorderSize = 0;
            this.BtnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuitar.Location = new System.Drawing.Point(642, 9);
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(179, 33);
            this.BtnQuitar.TabIndex = 11;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btnagregar.Location = new System.Drawing.Point(108, 9);
            this.Btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(179, 33);
            this.Btnagregar.TabIndex = 10;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Pnlsub
            // 
            this.Pnlsub.Controls.Add(this.lbl001);
            this.Pnlsub.Controls.Add(this.LblTotal);
            this.Pnlsub.Controls.Add(this.SubTotal);
            this.Pnlsub.Controls.Add(this.LBlsubtotal);
            this.Pnlsub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlsub.Location = new System.Drawing.Point(0, 524);
            this.Pnlsub.Name = "Pnlsub";
            this.Pnlsub.Size = new System.Drawing.Size(959, 67);
            this.Pnlsub.TabIndex = 13;
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl001.Location = new System.Drawing.Point(554, 25);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(60, 22);
            this.lbl001.TabIndex = 18;
            this.lbl001.Text = "00.00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(500, 25);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(55, 22);
            this.LblTotal.TabIndex = 19;
            this.LblTotal.Text = "Total";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(280, 25);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(90, 22);
            this.SubTotal.TabIndex = 16;
            this.SubTotal.Text = "SubTotal";
            // 
            // LBlsubtotal
            // 
            this.LBlsubtotal.AutoSize = true;
            this.LBlsubtotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBlsubtotal.Location = new System.Drawing.Point(381, 25);
            this.LBlsubtotal.Name = "LBlsubtotal";
            this.LBlsubtotal.Size = new System.Drawing.Size(60, 22);
            this.LBlsubtotal.TabIndex = 17;
            this.LBlsubtotal.Text = "00.00";
            // 
            // FrmNuevaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 705);
            this.Controls.Add(this.Pnlsub);
            this.Controls.Add(this.Pnlsubtotal);
            this.Controls.Add(this.PnlGuardar);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlProducto);
            this.Controls.Add(this.PnlCarrito);
            this.Controls.Add(this.PnlFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaCompra";
            this.Load += new System.EventHandler(this.FrmNuevaCompra_Load);
            this.PnlFacturacion.ResumeLayout(false);
            this.PnlFacturacion.PerformLayout();
            this.PnlCarrito.ResumeLayout(false);
            this.PnlCarrito.PerformLayout();
            this.PnlProducto.ResumeLayout(false);
            this.PnlProducto.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompra)).EndInit();
            this.PnlGuardar.ResumeLayout(false);
            this.Pnlsubtotal.ResumeLayout(false);
            this.Pnlsub.ResumeLayout(false);
            this.Pnlsub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFacturacion;
        private FontAwesome.Sharp.IconButton BtnX;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Panel PnlCarrito;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblFech;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.TextBox Txtcasacomerciales;
        private System.Windows.Forms.Label LblCasacomercial;
        private System.Windows.Forms.Panel PnlProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.Panel PnlGuardar;
        private System.Windows.Forms.DataGridView DtgCompra;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Panel Pnlsubtotal;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Panel Pnlsub;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label LBlsubtotal;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.ComboBox CmbProveedor;
    }
}