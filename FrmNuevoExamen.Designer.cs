namespace Proyecto_de_Graduacion
{
    partial class FrmNuevoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoExamen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnlgrid = new System.Windows.Forms.Panel();
            this.Dtgexamen = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCargarPlantilla = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.CMBCategoria = new System.Windows.Forms.ComboBox();
            this.Lblruta = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.BtnEnlace = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.Pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgexamen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEnlace);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.CMBCategoria);
            this.panel1.Controls.Add(this.Lblruta);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 160);
            this.panel1.TabIndex = 97;
            // 
            // Pnlgrid
            // 
            this.Pnlgrid.Controls.Add(this.Dtgexamen);
            this.Pnlgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlgrid.Location = new System.Drawing.Point(0, 160);
            this.Pnlgrid.Name = "Pnlgrid";
            this.Pnlgrid.Size = new System.Drawing.Size(915, 330);
            this.Pnlgrid.TabIndex = 98;
            // 
            // Dtgexamen
            // 
            this.Dtgexamen.AllowUserToAddRows = false;
            this.Dtgexamen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dtgexamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgexamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgexamen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtgexamen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dtgexamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtgexamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgexamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgexamen.ColumnHeadersHeight = 40;
            this.Dtgexamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgexamen.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtgexamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtgexamen.EnableHeadersVisualStyles = false;
            this.Dtgexamen.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dtgexamen.Location = new System.Drawing.Point(0, 0);
            this.Dtgexamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtgexamen.Name = "Dtgexamen";
            this.Dtgexamen.ReadOnly = true;
            this.Dtgexamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgexamen.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Dtgexamen.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtgexamen.RowTemplate.Height = 24;
            this.Dtgexamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgexamen.Size = new System.Drawing.Size(915, 330);
            this.Dtgexamen.TabIndex = 97;
            this.Dtgexamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgexamen_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnCargarPlantilla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 93);
            this.panel2.TabIndex = 99;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(637, 23);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(266, 46);
            this.BtnCancelar.TabIndex = 116;
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
            this.BtnGuardar.Location = new System.Drawing.Point(345, 23);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(250, 46);
            this.BtnGuardar.TabIndex = 115;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCargarPlantilla
            // 
            this.BtnCargarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCargarPlantilla.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCargarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarPlantilla.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarPlantilla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCargarPlantilla.Location = new System.Drawing.Point(32, 23);
            this.BtnCargarPlantilla.Name = "BtnCargarPlantilla";
            this.BtnCargarPlantilla.Size = new System.Drawing.Size(286, 46);
            this.BtnCargarPlantilla.TabIndex = 114;
            this.BtnCargarPlantilla.Text = "Cargar Plantilla";
            this.BtnCargarPlantilla.UseVisualStyleBackColor = false;
            this.BtnCargarPlantilla.Click += new System.EventHandler(this.BtnCargarPlantilla_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(147, 92);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(179, 31);
            this.txt_precio.TabIndex = 112;
            this.txt_precio.Validating += new System.ComponentModel.CancelEventHandler(this.txt_precio_Validating);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(29, 90);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 20);
            this.lblApellido.TabIndex = 110;
            this.lblApellido.Text = "Precio";
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(147, 26);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(179, 31);
            this.txttitulo.TabIndex = 111;
            this.txttitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttitulo_KeyPress);
            this.txttitulo.Validating += new System.ComponentModel.CancelEventHandler(this.txttitulo_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 26);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 109;
            this.lblNombre.Text = "Examen";
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(548, 27);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(258, 31);
            this.txtRuta.TabIndex = 116;
            this.txtRuta.Validating += new System.ComponentModel.CancelEventHandler(this.txtRuta_Validating);
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.Location = new System.Drawing.Point(548, 101);
            this.CMBCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(258, 28);
            this.CMBCategoria.TabIndex = 114;
            // 
            // Lblruta
            // 
            this.Lblruta.AutoSize = true;
            this.Lblruta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblruta.Location = new System.Drawing.Point(361, 32);
            this.Lblruta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblruta.Name = "Lblruta";
            this.Lblruta.Size = new System.Drawing.Size(133, 20);
            this.Lblruta.TabIndex = 115;
            this.Lblruta.Text = "Ruta de Archivo";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(361, 103);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(87, 20);
            this.LblCategoria.TabIndex = 113;
            this.LblCategoria.Text = "Categoria";
            // 
            // BtnEnlace
            // 
            this.BtnEnlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnEnlace.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnlace.Location = new System.Drawing.Point(829, 22);
            this.BtnEnlace.Name = "BtnEnlace";
            this.BtnEnlace.Size = new System.Drawing.Size(56, 42);
            this.BtnEnlace.TabIndex = 117;
            this.BtnEnlace.Text = "....";
            this.BtnEnlace.UseVisualStyleBackColor = true;
            this.BtnEnlace.Click += new System.EventHandler(this.BtnEnlace_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNuevoExamen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnlgrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Examen";
            this.Load += new System.EventHandler(this.FrmNuevoExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgexamen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnlgrid;
        private System.Windows.Forms.DataGridView Dtgexamen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCargarPlantilla;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.ComboBox CMBCategoria;
        private System.Windows.Forms.Label Lblruta;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Button BtnEnlace;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}