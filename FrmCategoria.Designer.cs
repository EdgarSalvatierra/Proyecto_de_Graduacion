namespace Proyecto_de_Graduacion
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.PnlTitullo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNCategoria = new FontAwesome.Sharp.IconPictureBox();
            this.LstCategoria = new System.Windows.Forms.Label();
            this.Pnlgrid = new System.Windows.Forms.Panel();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.Pnlgridis = new System.Windows.Forms.Panel();
            this.DtgCategoria = new System.Windows.Forms.DataGridView();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoExamen = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.PnlTitullo.SuspendLayout();
            this.PnlLista.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNCategoria)).BeginInit();
            this.Pnlgrid.SuspendLayout();
            this.Pnlgridis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).BeginInit();
            this.PnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitullo
            // 
            this.PnlTitullo.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnlTitullo.Controls.Add(this.btnCerrar);
            this.PnlTitullo.Controls.Add(this.LblTitulo);
            this.PnlTitullo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitullo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitullo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlTitullo.Name = "PnlTitullo";
            this.PnlTitullo.Size = new System.Drawing.Size(1032, 52);
            this.PnlTitullo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(982, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(326, 11);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(203, 20);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Registro de Categorias";
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.ICNBuscador);
            this.PnlLista.Controls.Add(this.PnlBuscare);
            this.PnlLista.Controls.Add(this.BtnRefrescar);
            this.PnlLista.Controls.Add(this.ICNCategoria);
            this.PnlLista.Controls.Add(this.LstCategoria);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLista.Location = new System.Drawing.Point(0, 52);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(1032, 66);
            this.PnlLista.TabIndex = 2;
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
            this.ICNBuscador.Location = new System.Drawing.Point(906, 15);
            this.ICNBuscador.Name = "ICNBuscador";
            this.ICNBuscador.Size = new System.Drawing.Size(45, 37);
            this.ICNBuscador.TabIndex = 80;
            this.ICNBuscador.UseVisualStyleBackColor = false;
            this.ICNBuscador.Click += new System.EventHandler(this.ICNBuscador_Click);
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarFactura);
            this.PnlBuscare.Location = new System.Drawing.Point(529, 14);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(371, 35);
            this.PnlBuscare.TabIndex = 79;
            // 
            // TxtBuscarFactura
            // 
            this.TxtBuscarFactura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarFactura.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarFactura.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarFactura.Name = "TxtBuscarFactura";
            this.TxtBuscarFactura.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarFactura.TabIndex = 0;
            this.TxtBuscarFactura.Text = "Buscar Categoria";
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
            this.BtnRefrescar.Location = new System.Drawing.Point(957, 15);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(46, 38);
            this.BtnRefrescar.TabIndex = 78;
            this.BtnRefrescar.UseVisualStyleBackColor = false;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // ICNCategoria
            // 
            this.ICNCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ICNCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ICNCategoria.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.ICNCategoria.IconColor = System.Drawing.SystemColors.ControlText;
            this.ICNCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNCategoria.IconSize = 55;
            this.ICNCategoria.Location = new System.Drawing.Point(47, 8);
            this.ICNCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ICNCategoria.Name = "ICNCategoria";
            this.ICNCategoria.Size = new System.Drawing.Size(56, 55);
            this.ICNCategoria.TabIndex = 3;
            this.ICNCategoria.TabStop = false;
            // 
            // LstCategoria
            // 
            this.LstCategoria.AutoSize = true;
            this.LstCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCategoria.Location = new System.Drawing.Point(110, 22);
            this.LstCategoria.Name = "LstCategoria";
            this.LstCategoria.Size = new System.Drawing.Size(164, 20);
            this.LstCategoria.TabIndex = 2;
            this.LstCategoria.Text = "Lista de Categoria";
            // 
            // Pnlgrid
            // 
            this.Pnlgrid.Controls.Add(this.TxtCategoria);
            this.Pnlgrid.Controls.Add(this.txtid);
            this.Pnlgrid.Controls.Add(this.LblCategoria);
            this.Pnlgrid.Controls.Add(this.Lblcodigo);
            this.Pnlgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlgrid.Location = new System.Drawing.Point(0, 118);
            this.Pnlgrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlgrid.Name = "Pnlgrid";
            this.Pnlgrid.Size = new System.Drawing.Size(1032, 57);
            this.Pnlgrid.TabIndex = 3;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(697, 15);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(203, 27);
            this.TxtCategoria.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(202, 12);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(151, 27);
            this.txtid.TabIndex = 2;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(585, 18);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(93, 20);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoria";
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.AutoSize = true;
            this.Lblcodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcodigo.Location = new System.Drawing.Point(110, 15);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(70, 20);
            this.Lblcodigo.TabIndex = 0;
            this.Lblcodigo.Text = "Codigo";
            // 
            // Pnlgridis
            // 
            this.Pnlgridis.Controls.Add(this.DtgCategoria);
            this.Pnlgridis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlgridis.Location = new System.Drawing.Point(0, 175);
            this.Pnlgridis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlgridis.Name = "Pnlgridis";
            this.Pnlgridis.Size = new System.Drawing.Size(1032, 447);
            this.Pnlgridis.TabIndex = 5;
            // 
            // DtgCategoria
            // 
            this.DtgCategoria.AllowUserToAddRows = false;
            this.DtgCategoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgCategoria.ColumnHeadersHeight = 40;
            this.DtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgCategoria.EnableHeadersVisualStyles = false;
            this.DtgCategoria.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCategoria.Location = new System.Drawing.Point(0, 45);
            this.DtgCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgCategoria.Name = "DtgCategoria";
            this.DtgCategoria.ReadOnly = true;
            this.DtgCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgCategoria.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgCategoria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgCategoria.RowTemplate.Height = 24;
            this.DtgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCategoria.Size = new System.Drawing.Size(1032, 402);
            this.DtgCategoria.TabIndex = 1;
            this.DtgCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCategoria_CellClick);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.Controls.Add(this.BtnCancelar);
            this.PnlOpciones.Controls.Add(this.BtnGuardar);
            this.PnlOpciones.Controls.Add(this.BtnNuevoExamen);
            this.PnlOpciones.Controls.Add(this.BtnEditar);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlOpciones.Location = new System.Drawing.Point(0, 629);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(1032, 85);
            this.PnlOpciones.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 20;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(826, 22);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(192, 48);
            this.BtnCancelar.TabIndex = 57;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
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
            this.BtnGuardar.Location = new System.Drawing.Point(580, 22);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(192, 48);
            this.BtnGuardar.TabIndex = 56;
            this.BtnGuardar.Text = "Guardar ";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevoExamen
            // 
            this.BtnNuevoExamen.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNuevoExamen.FlatAppearance.BorderSize = 0;
            this.BtnNuevoExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoExamen.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoExamen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevoExamen.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoExamen.IconColor = System.Drawing.Color.White;
            this.BtnNuevoExamen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoExamen.IconSize = 20;
            this.BtnNuevoExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoExamen.Location = new System.Drawing.Point(14, 22);
            this.BtnNuevoExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoExamen.Name = "BtnNuevoExamen";
            this.BtnNuevoExamen.Size = new System.Drawing.Size(210, 48);
            this.BtnNuevoExamen.TabIndex = 54;
            this.BtnNuevoExamen.Text = "Nuevo Categoria";
            this.BtnNuevoExamen.UseVisualStyleBackColor = false;
            this.BtnNuevoExamen.Click += new System.EventHandler(this.BtnNuevoExamen_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(302, 22);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(218, 48);
            this.BtnEditar.TabIndex = 55;
            this.BtnEditar.Text = "Editar Categoria";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 714);
            this.Controls.Add(this.PnlOpciones);
            this.Controls.Add(this.Pnlgridis);
            this.Controls.Add(this.Pnlgrid);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.PnlTitullo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.PnlTitullo.ResumeLayout(false);
            this.PnlTitullo.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNCategoria)).EndInit();
            this.Pnlgrid.ResumeLayout(false);
            this.Pnlgrid.PerformLayout();
            this.Pnlgridis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).EndInit();
            this.PnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitullo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlLista;
        public FontAwesome.Sharp.IconPictureBox ICNCategoria;
        private System.Windows.Forms.Label LstCategoria;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel Pnlgrid;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label Lblcodigo;
        private System.Windows.Forms.Panel Pnlgridis;
        private System.Windows.Forms.DataGridView DtgCategoria;
        private System.Windows.Forms.Panel PnlOpciones;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevoExamen;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}