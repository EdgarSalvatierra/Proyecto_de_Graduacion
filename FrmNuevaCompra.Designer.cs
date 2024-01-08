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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlFacturacion = new System.Windows.Forms.Panel();
            this.BtnX = new FontAwesome.Sharp.IconButton();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.PnlCarrito = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFech = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.LblCasacomercial = new System.Windows.Forms.Label();
            this.Txtcasacomerciales = new System.Windows.Forms.TextBox();
            this.PnlProducto = new System.Windows.Forms.Panel();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgCompra = new System.Windows.Forms.DataGridView();
            this.PnlGuardar = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.Pnlsubtotal = new System.Windows.Forms.Panel();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
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
            this.PnlCarrito.Controls.Add(this.Txtcasacomerciales);
            this.PnlCarrito.Controls.Add(this.LblCasacomercial);
            this.PnlCarrito.Controls.Add(this.TxtProveedor);
            this.PnlCarrito.Controls.Add(this.LblProveedor);
            this.PnlCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCarrito.Location = new System.Drawing.Point(0, 60);
            this.PnlCarrito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlCarrito.Name = "PnlCarrito";
            this.PnlCarrito.Size = new System.Drawing.Size(959, 63);
            this.PnlCarrito.TabIndex = 7;
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
            // TxtProveedor
            // 
            this.TxtProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtProveedor.Location = new System.Drawing.Point(203, 20);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(266, 22);
            this.TxtProveedor.TabIndex = 1;
            // 
            // LblCasacomercial
            // 
            this.LblCasacomercial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCasacomercial.AutoSize = true;
            this.LblCasacomercial.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCasacomercial.Location = new System.Drawing.Point(519, 20);
            this.LblCasacomercial.Name = "LblCasacomercial";
            this.LblCasacomercial.Size = new System.Drawing.Size(143, 19);
            this.LblCasacomercial.TabIndex = 2;
            this.LblCasacomercial.Text = "Casa Comerciales";
            // 
            // Txtcasacomerciales
            // 
            this.Txtcasacomerciales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txtcasacomerciales.Location = new System.Drawing.Point(697, 20);
            this.Txtcasacomerciales.Name = "Txtcasacomerciales";
            this.Txtcasacomerciales.Size = new System.Drawing.Size(250, 22);
            this.Txtcasacomerciales.TabIndex = 3;
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
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPrecio.Location = new System.Drawing.Point(458, 21);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(180, 22);
            this.TxtPrecio.TabIndex = 3;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(395, 21);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 19);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtProducto.Location = new System.Drawing.Point(203, 20);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(163, 22);
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
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCantidad.Location = new System.Drawing.Point(746, 21);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(201, 22);
            this.TxtCantidad.TabIndex = 5;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(666, 24);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 19);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad";
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DtgCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCompra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DtgCompra.ColumnHeadersHeight = 40;
            this.DtgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCompra.DefaultCellStyle = dataGridViewCellStyle8;
            this.DtgCompra.EnableHeadersVisualStyles = false;
            this.DtgCompra.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.Location = new System.Drawing.Point(12, 8);
            this.DtgCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgCompra.Name = "DtgCompra";
            this.DtgCompra.ReadOnly = true;
            this.DtgCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DtgCompra.RowHeadersWidth = 65;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgCompra.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DtgCompra.RowTemplate.Height = 24;
            this.DtgCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCompra.Size = new System.Drawing.Size(935, 304);
            this.DtgCompra.TabIndex = 3;
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
            this.BtnCancelar.Location = new System.Drawing.Point(624, 13);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(307, 40);
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
            this.BtnGuardar.Location = new System.Drawing.Point(29, 13);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(308, 40);
            this.BtnGuardar.TabIndex = 58;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Pnlsubtotal
            // 
            this.Pnlsubtotal.Controls.Add(this.lbl001);
            this.Pnlsubtotal.Controls.Add(this.LblTotal);
            this.Pnlsubtotal.Controls.Add(this.SubTotal);
            this.Pnlsubtotal.Controls.Add(this.LBlsubtotal);
            this.Pnlsubtotal.Controls.Add(this.BtnQuitar);
            this.Pnlsubtotal.Controls.Add(this.Btnagregar);
            this.Pnlsubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlsubtotal.Location = new System.Drawing.Point(0, 518);
            this.Pnlsubtotal.Name = "Pnlsubtotal";
            this.Pnlsubtotal.Size = new System.Drawing.Size(959, 101);
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
            this.BtnQuitar.Location = new System.Drawing.Point(722, 61);
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(179, 33);
            this.BtnQuitar.TabIndex = 11;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
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
            this.Btnagregar.Location = new System.Drawing.Point(722, 16);
            this.Btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(179, 33);
            this.Btnagregar.TabIndex = 10;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl001.Location = new System.Drawing.Point(187, 60);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(60, 22);
            this.lbl001.TabIndex = 14;
            this.lbl001.Text = "00.00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(70, 62);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(48, 20);
            this.LblTotal.TabIndex = 15;
            this.LblTotal.Text = "Total";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(70, 12);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(77, 20);
            this.SubTotal.TabIndex = 12;
            this.SubTotal.Text = "SubTotal";
            // 
            // LBlsubtotal
            // 
            this.LBlsubtotal.AutoSize = true;
            this.LBlsubtotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBlsubtotal.Location = new System.Drawing.Point(187, 10);
            this.LBlsubtotal.Name = "LBlsubtotal";
            this.LBlsubtotal.Size = new System.Drawing.Size(60, 22);
            this.LBlsubtotal.TabIndex = 13;
            this.LBlsubtotal.Text = "00.00";
            // 
            // FrmNuevaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 705);
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
            this.Pnlsubtotal.PerformLayout();
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
        private System.Windows.Forms.TextBox TxtProveedor;
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
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label LBlsubtotal;
    }
}