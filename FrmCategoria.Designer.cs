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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditarCategoria = new System.Windows.Forms.Button();
            this.BtnNuevaCategoria = new System.Windows.Forms.Button();
            this.Pnlgrid = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.ICNCategoria = new FontAwesome.Sharp.IconPictureBox();
            this.LstCategoria = new System.Windows.Forms.Label();
            this.Pnlcodigo = new System.Windows.Forms.Panel();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.Btnrefrescar = new System.Windows.Forms.Button();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.BtnBuscador = new System.Windows.Forms.Button();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.DtgCategoria = new System.Windows.Forms.DataGridView();
            this.PnlTitullo.SuspendLayout();
            this.PnlOpciones.SuspendLayout();
            this.Pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNCategoria)).BeginInit();
            this.Pnlcodigo.SuspendLayout();
            this.PnlLista.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).BeginInit();
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Location = new System.Drawing.Point(557, 22);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(223, 46);
            this.BtnGuardar.TabIndex = 65;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.Controls.Add(this.BtnCancelar);
            this.PnlOpciones.Controls.Add(this.BtnGuardar);
            this.PnlOpciones.Controls.Add(this.BtnEditarCategoria);
            this.PnlOpciones.Controls.Add(this.BtnNuevaCategoria);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlOpciones.Location = new System.Drawing.Point(0, 629);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(1032, 85);
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
            this.BtnCancelar.Location = new System.Drawing.Point(797, 22);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(223, 46);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnEditarCategoria
            // 
            this.BtnEditarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditarCategoria.Location = new System.Drawing.Point(290, 22);
            this.BtnEditarCategoria.Name = "BtnEditarCategoria";
            this.BtnEditarCategoria.Size = new System.Drawing.Size(223, 46);
            this.BtnEditarCategoria.TabIndex = 64;
            this.BtnEditarCategoria.Text = "Editar Categoria";
            this.BtnEditarCategoria.UseVisualStyleBackColor = false;
            this.BtnEditarCategoria.Click += new System.EventHandler(this.BtnEditarCategoria_Click);
            // 
            // BtnNuevaCategoria
            // 
            this.BtnNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevaCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevaCategoria.Location = new System.Drawing.Point(22, 22);
            this.BtnNuevaCategoria.Name = "BtnNuevaCategoria";
            this.BtnNuevaCategoria.Size = new System.Drawing.Size(223, 46);
            this.BtnNuevaCategoria.TabIndex = 63;
            this.BtnNuevaCategoria.Text = "Nueva Categoria";
            this.BtnNuevaCategoria.UseVisualStyleBackColor = false;
            this.BtnNuevaCategoria.Click += new System.EventHandler(this.BtnNuevaCategoria_Click);
            // 
            // Pnlgrid
            // 
            this.Pnlgrid.Controls.Add(this.PnlLista);
            this.Pnlgrid.Controls.Add(this.Pnlcodigo);
            this.Pnlgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlgrid.Location = new System.Drawing.Point(0, 52);
            this.Pnlgrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlgrid.Name = "Pnlgrid";
            this.Pnlgrid.Size = new System.Drawing.Size(1032, 130);
            this.Pnlgrid.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(742, 19);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(224, 27);
            this.txtid.TabIndex = 2;
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.AutoSize = true;
            this.Lblcodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcodigo.Location = new System.Drawing.Point(642, 22);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(70, 20);
            this.Lblcodigo.TabIndex = 0;
            this.Lblcodigo.Text = "Codigo";
            // 
            // ICNCategoria
            // 
            this.ICNCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ICNCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ICNCategoria.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.ICNCategoria.IconColor = System.Drawing.SystemColors.ControlText;
            this.ICNCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNCategoria.IconSize = 55;
            this.ICNCategoria.Location = new System.Drawing.Point(16, 5);
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
            this.LstCategoria.Location = new System.Drawing.Point(78, 22);
            this.LstCategoria.Name = "LstCategoria";
            this.LstCategoria.Size = new System.Drawing.Size(164, 20);
            this.LstCategoria.TabIndex = 2;
            this.LstCategoria.Text = "Lista de Categoria";
            // 
            // Pnlcodigo
            // 
            this.Pnlcodigo.Controls.Add(this.ICNCategoria);
            this.Pnlcodigo.Controls.Add(this.Lblcodigo);
            this.Pnlcodigo.Controls.Add(this.txtid);
            this.Pnlcodigo.Controls.Add(this.LstCategoria);
            this.Pnlcodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlcodigo.Location = new System.Drawing.Point(0, 0);
            this.Pnlcodigo.Name = "Pnlcodigo";
            this.Pnlcodigo.Size = new System.Drawing.Size(1032, 68);
            this.Pnlcodigo.TabIndex = 4;
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.TxtCategoria);
            this.PnlLista.Controls.Add(this.Btnrefrescar);
            this.PnlLista.Controls.Add(this.LblCategoria);
            this.PnlLista.Controls.Add(this.BtnBuscador);
            this.PnlLista.Controls.Add(this.PnlBuscare);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLista.Location = new System.Drawing.Point(0, 68);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(1032, 58);
            this.PnlLista.TabIndex = 10;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(742, 19);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(224, 27);
            this.TxtCategoria.TabIndex = 6;
            // 
            // Btnrefrescar
            // 
            this.Btnrefrescar.BackgroundImage = global::Proyecto_de_Graduacion.Properties.Resources.refresh;
            this.Btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnrefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnrefrescar.Location = new System.Drawing.Point(442, 14);
            this.Btnrefrescar.Name = "Btnrefrescar";
            this.Btnrefrescar.Size = new System.Drawing.Size(43, 38);
            this.Btnrefrescar.TabIndex = 88;
            this.Btnrefrescar.UseVisualStyleBackColor = true;
            this.Btnrefrescar.Click += new System.EventHandler(this.Btnrefrescar_Click_1);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(642, 22);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(93, 20);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoria";
            // 
            // BtnBuscador
            // 
            this.BtnBuscador.BackgroundImage = global::Proyecto_de_Graduacion.Properties.Resources.search;
            this.BtnBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBuscador.Location = new System.Drawing.Point(389, 14);
            this.BtnBuscador.Name = "BtnBuscador";
            this.BtnBuscador.Size = new System.Drawing.Size(47, 37);
            this.BtnBuscador.TabIndex = 87;
            this.BtnBuscador.UseVisualStyleBackColor = true;
            this.BtnBuscador.Click += new System.EventHandler(this.BtnBuscador_Click_1);
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarFactura);
            this.PnlBuscare.Location = new System.Drawing.Point(12, 16);
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
            this.DtgCategoria.Location = new System.Drawing.Point(0, 206);
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
            this.DtgCategoria.Size = new System.Drawing.Size(1032, 423);
            this.DtgCategoria.TabIndex = 8;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 714);
            this.Controls.Add(this.DtgCategoria);
            this.Controls.Add(this.Pnlgrid);
            this.Controls.Add(this.PnlOpciones);
            this.Controls.Add(this.PnlTitullo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.PnlTitullo.ResumeLayout(false);
            this.PnlTitullo.PerformLayout();
            this.PnlOpciones.ResumeLayout(false);
            this.Pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICNCategoria)).EndInit();
            this.Pnlcodigo.ResumeLayout(false);
            this.Pnlcodigo.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitullo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlOpciones;
        private System.Windows.Forms.Button BtnNuevaCategoria;
        private System.Windows.Forms.Button BtnEditarCategoria;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel Pnlgrid;
        public FontAwesome.Sharp.IconPictureBox ICNCategoria;
        private System.Windows.Forms.Label LstCategoria;
        private System.Windows.Forms.Label Lblcodigo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Button Btnrefrescar;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Button BtnBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private System.Windows.Forms.Panel Pnlcodigo;
        private System.Windows.Forms.DataGridView DtgCategoria;
    }
}