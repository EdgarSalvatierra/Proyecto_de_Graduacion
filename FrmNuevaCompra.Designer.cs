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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaCompra));
            this.PnlGuardar = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.Pnlarriba = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtFecha = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblRegistroCompras = new System.Windows.Forms.Label();
            this.Pnlproveedor = new System.Windows.Forms.Panel();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.Pnlpreciook = new System.Windows.Forms.Panel();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.Lblproveedor = new System.Windows.Forms.Label();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgCompra = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSistemaLab = new System.Windows.Forms.Label();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PnlGuardar.SuspendLayout();
            this.Pnlarriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnlproveedor.SuspendLayout();
            this.Pnlpreciook.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGuardar
            // 
            this.PnlGuardar.Controls.Add(this.BtnCancelar);
            this.PnlGuardar.Controls.Add(this.BtnGuardar);
            this.PnlGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlGuardar.Location = new System.Drawing.Point(0, 639);
            this.PnlGuardar.Name = "PnlGuardar";
            this.PnlGuardar.Size = new System.Drawing.Size(944, 66);
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
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 20;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(609, 13);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(260, 40);
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
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuardar.IconSize = 20;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(68, 13);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(261, 40);
            this.BtnGuardar.TabIndex = 58;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Pnlarriba
            // 
            this.Pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.Pnlarriba.Controls.Add(this.BtnMinimizar);
            this.Pnlarriba.Controls.Add(this.LblSistemaLab);
            this.Pnlarriba.Controls.Add(this.BtnClose);
            this.Pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.Pnlarriba.Name = "Pnlarriba";
            this.Pnlarriba.Size = new System.Drawing.Size(944, 36);
            this.Pnlarriba.TabIndex = 13;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClose.Location = new System.Drawing.Point(914, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 29);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.TxtFecha);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.LblRegistroCompras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 55);
            this.panel1.TabIndex = 14;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtFecha.AutoSize = true;
            this.TxtFecha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFecha.Location = new System.Drawing.Point(696, 18);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(29, 19);
            this.TxtFecha.TabIndex = 2;
            this.TxtFecha.Text = "....";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblFecha.Location = new System.Drawing.Point(536, 18);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(153, 21);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha de Compra";
            // 
            // LblRegistroCompras
            // 
            this.LblRegistroCompras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblRegistroCompras.AutoSize = true;
            this.LblRegistroCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRegistroCompras.Location = new System.Drawing.Point(20, 18);
            this.LblRegistroCompras.Name = "LblRegistroCompras";
            this.LblRegistroCompras.Size = new System.Drawing.Size(198, 23);
            this.LblRegistroCompras.TabIndex = 0;
            this.LblRegistroCompras.Text = "Registro de Compras";
            // 
            // Pnlproveedor
            // 
            this.Pnlproveedor.Controls.Add(this.CmbProducto);
            this.Pnlproveedor.Controls.Add(this.LblProducto);
            this.Pnlproveedor.Controls.Add(this.TxtPrecio);
            this.Pnlproveedor.Controls.Add(this.BtnProveedor);
            this.Pnlproveedor.Controls.Add(this.TxtCantidad);
            this.Pnlproveedor.Controls.Add(this.LblPrecio);
            this.Pnlproveedor.Controls.Add(this.LblCantidad);
            this.Pnlproveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlproveedor.Location = new System.Drawing.Point(0, 91);
            this.Pnlproveedor.Name = "Pnlproveedor";
            this.Pnlproveedor.Size = new System.Drawing.Size(944, 61);
            this.Pnlproveedor.TabIndex = 15;
            // 
            // CmbProducto
            // 
            this.CmbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(102, 17);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(180, 27);
            this.CmbProducto.TabIndex = 4;
            this.CmbProducto.DropDownClosed += new System.EventHandler(this.CmbProducto_DropDownClosed);
            // 
            // LblProducto
            // 
            this.LblProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(12, 20);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(75, 19);
            this.LblProducto.TabIndex = 3;
            this.LblProducto.Text = "Producto";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(433, 15);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(188, 27);
            this.TxtPrecio.TabIndex = 7;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.Location = new System.Drawing.Point(279, 15);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(48, 29);
            this.BtnProveedor.TabIndex = 2;
            this.BtnProveedor.Text = "....";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(775, 15);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(142, 27);
            this.TxtCantidad.TabIndex = 9;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(369, 20);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 19);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(681, 20);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(74, 19);
            this.LblCantidad.TabIndex = 8;
            this.LblCantidad.Text = "Cantidad";
            // 
            // Pnlpreciook
            // 
            this.Pnlpreciook.Controls.Add(this.CmbProveedor);
            this.Pnlpreciook.Controls.Add(this.Lblproveedor);
            this.Pnlpreciook.Controls.Add(this.BtnQuitar);
            this.Pnlpreciook.Controls.Add(this.TxtTotal);
            this.Pnlpreciook.Controls.Add(this.Btnagregar);
            this.Pnlpreciook.Controls.Add(this.LblTotal);
            this.Pnlpreciook.Controls.Add(this.TxtSubTotal);
            this.Pnlpreciook.Controls.Add(this.LblSubtotal);
            this.Pnlpreciook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlpreciook.Location = new System.Drawing.Point(0, 152);
            this.Pnlpreciook.Name = "Pnlpreciook";
            this.Pnlpreciook.Size = new System.Drawing.Size(944, 45);
            this.Pnlpreciook.TabIndex = 16;
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProveedor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(102, 8);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(180, 27);
            this.CmbProveedor.TabIndex = 10;
            this.CmbProveedor.DropDown += new System.EventHandler(this.CmbProveedor_DropDown);
            this.CmbProveedor.DropDownClosed += new System.EventHandler(this.CmbProveedor_DropDownClosed);
            // 
            // Lblproveedor
            // 
            this.Lblproveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lblproveedor.AutoSize = true;
            this.Lblproveedor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblproveedor.Location = new System.Drawing.Point(12, 13);
            this.Lblproveedor.Name = "Lblproveedor";
            this.Lblproveedor.Size = new System.Drawing.Size(84, 19);
            this.Lblproveedor.TabIndex = 14;
            this.Lblproveedor.Text = "Proveedor";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnQuitar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnQuitar.FlatAppearance.BorderSize = 0;
            this.BtnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuitar.Location = new System.Drawing.Point(799, 8);
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(118, 30);
            this.BtnQuitar.TabIndex = 11;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtTotal.AutoSize = true;
            this.TxtTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(586, 13);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(34, 19);
            this.TxtTotal.TabIndex = 13;
            this.TxtTotal.Text = ".....";
            // 
            // Btnagregar
            // 
            this.Btnagregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btnagregar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btnagregar.FlatAppearance.BorderSize = 0;
            this.Btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnagregar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btnagregar.Location = new System.Drawing.Point(666, 7);
            this.Btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(116, 30);
            this.Btnagregar.TabIndex = 10;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = false;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click_1);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(539, 13);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 19);
            this.LblTotal.TabIndex = 12;
            this.LblTotal.Text = "Total";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtSubTotal.AutoSize = true;
            this.TxtSubTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTotal.Location = new System.Drawing.Point(445, 13);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(34, 19);
            this.TxtSubTotal.TabIndex = 11;
            this.TxtSubTotal.Text = ".....";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(369, 14);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(70, 19);
            this.LblSubtotal.TabIndex = 10;
            this.LblSubtotal.Text = "SubTotal";
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgCompra);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(0, 197);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(944, 442);
            this.PnlGrid.TabIndex = 18;
            // 
            // DtgCompra
            // 
            this.DtgCompra.AllowUserToAddRows = false;
            this.DtgCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCompra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgCompra.ColumnHeadersHeight = 40;
            this.DtgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.Importe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgCompra.EnableHeadersVisualStyles = false;
            this.DtgCompra.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompra.Location = new System.Drawing.Point(12, 8);
            this.DtgCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgCompra.Name = "DtgCompra";
            this.DtgCompra.ReadOnly = true;
            this.DtgCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgCompra.RowHeadersWidth = 65;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgCompra.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgCompra.RowTemplate.Height = 24;
            this.DtgCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCompra.Size = new System.Drawing.Size(920, 427);
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
            // LblSistemaLab
            // 
            this.LblSistemaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSistemaLab.AutoSize = true;
            this.LblSistemaLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.LblSistemaLab.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemaLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSistemaLab.Location = new System.Drawing.Point(367, 9);
            this.LblSistemaLab.Name = "LblSistemaLab";
            this.LblSistemaLab.Size = new System.Drawing.Size(211, 19);
            this.LblSistemaLab.TabIndex = 16;
            this.LblSistemaLab.Text = "Sistema Socorro Lab";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnMinimizar.Location = new System.Drawing.Point(876, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(32, 29);
            this.BtnMinimizar.TabIndex = 17;
            this.BtnMinimizar.Text = "-";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmNuevaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 705);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.Pnlpreciook);
            this.Controls.Add(this.Pnlproveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnlarriba);
            this.Controls.Add(this.PnlGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaCompra";
            this.Load += new System.EventHandler(this.FrmNuevaCompra_Load);
            this.PnlGuardar.ResumeLayout(false);
            this.Pnlarriba.ResumeLayout(false);
            this.Pnlarriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnlproveedor.ResumeLayout(false);
            this.Pnlproveedor.PerformLayout();
            this.Pnlpreciook.ResumeLayout(false);
            this.Pnlpreciook.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Panel Pnlarriba;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblRegistroCompras;
        private System.Windows.Forms.Label TxtFecha;
        private System.Windows.Forms.Panel Pnlproveedor;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Panel Pnlpreciook;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label TxtSubTotal;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.Label Lblproveedor;
        private System.Windows.Forms.Label LblSistemaLab;
        private System.Windows.Forms.Button BtnMinimizar;
    }
}