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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnCategoria = new FontAwesome.Sharp.IconButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtid_examen = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Txtruta = new System.Windows.Forms.TextBox();
            this.CMBCategoria = new System.Windows.Forms.ComboBox();
            this.Lblruta = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.Pnlgrid = new System.Windows.Forms.Panel();
            this.Dtgexamen = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarTodo = new FontAwesome.Sharp.IconButton();
            this.BtnEnlace = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoExamen = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.Pnlgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgexamen)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.BtnCategoria);
            this.panel1.Controls.Add(this.BtnEnlace);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtid_examen);
            this.panel1.Controls.Add(this.LblId);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.Txtruta);
            this.panel1.Controls.Add(this.CMBCategoria);
            this.panel1.Controls.Add(this.Lblruta);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 210);
            this.panel1.TabIndex = 97;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(106, 157);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(179, 31);
            this.TxtPrecio.TabIndex = 103;
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCategoria.IconColor = System.Drawing.Color.Black;
            this.BtnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCategoria.Location = new System.Drawing.Point(809, 90);
            this.BtnCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.Size = new System.Drawing.Size(46, 38);
            this.BtnCategoria.TabIndex = 106;
            this.BtnCategoria.Text = ".....";
            this.BtnCategoria.UseVisualStyleBackColor = true;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(28, 162);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 20);
            this.lblApellido.TabIndex = 99;
            this.lblApellido.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(106, 90);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 31);
            this.txtNombre.TabIndex = 100;
            // 
            // txtid_examen
            // 
            this.txtid_examen.Enabled = false;
            this.txtid_examen.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_examen.Location = new System.Drawing.Point(106, 21);
            this.txtid_examen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid_examen.Name = "txtid_examen";
            this.txtid_examen.ReadOnly = true;
            this.txtid_examen.Size = new System.Drawing.Size(104, 31);
            this.txtid_examen.TabIndex = 102;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(28, 27);
            this.LblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(70, 20);
            this.LblId.TabIndex = 101;
            this.LblId.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 95);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 98;
            this.lblNombre.Text = "Examen";
            // 
            // Txtruta
            // 
            this.Txtruta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtruta.Location = new System.Drawing.Point(528, 21);
            this.Txtruta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtruta.Name = "Txtruta";
            this.Txtruta.Size = new System.Drawing.Size(258, 31);
            this.Txtruta.TabIndex = 108;
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.Location = new System.Drawing.Point(528, 95);
            this.CMBCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(258, 28);
            this.CMBCategoria.TabIndex = 105;
            // 
            // Lblruta
            // 
            this.Lblruta.AutoSize = true;
            this.Lblruta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblruta.Location = new System.Drawing.Point(341, 26);
            this.Lblruta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblruta.Name = "Lblruta";
            this.Lblruta.Size = new System.Drawing.Size(133, 20);
            this.Lblruta.TabIndex = 107;
            this.Lblruta.Text = "Ruta de Archivo";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(341, 95);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(87, 20);
            this.LblCategoria.TabIndex = 104;
            this.LblCategoria.Text = "Categoria";
            // 
            // Pnlgrid
            // 
            this.Pnlgrid.Controls.Add(this.Dtgexamen);
            this.Pnlgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlgrid.Location = new System.Drawing.Point(0, 210);
            this.Pnlgrid.Name = "Pnlgrid";
            this.Pnlgrid.Size = new System.Drawing.Size(915, 330);
            this.Pnlgrid.TabIndex = 98;
            // 
            // Dtgexamen
            // 
            this.Dtgexamen.AllowUserToAddRows = false;
            this.Dtgexamen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Dtgexamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.Dtgexamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgexamen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtgexamen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dtgexamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtgexamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgexamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Dtgexamen.ColumnHeadersHeight = 40;
            this.Dtgexamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgexamen.DefaultCellStyle = dataGridViewCellStyle15;
            this.Dtgexamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtgexamen.EnableHeadersVisualStyles = false;
            this.Dtgexamen.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dtgexamen.Location = new System.Drawing.Point(0, 0);
            this.Dtgexamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dtgexamen.Name = "Dtgexamen";
            this.Dtgexamen.ReadOnly = true;
            this.Dtgexamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtgexamen.RowHeadersWidth = 65;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Dtgexamen.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Dtgexamen.RowTemplate.Height = 24;
            this.Dtgexamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgexamen.Size = new System.Drawing.Size(915, 330);
            this.Dtgexamen.TabIndex = 97;
            this.Dtgexamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgexamen_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnGuardarTodo);
            this.panel2.Controls.Add(this.BtnNuevoExamen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 93);
            this.panel2.TabIndex = 99;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnCancelar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCancelar.IconSize = 20;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(697, 22);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(206, 49);
            this.BtnCancelar.TabIndex = 97;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarTodo
            // 
            this.BtnGuardarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnGuardarTodo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnGuardarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarTodo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarTodo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnGuardarTodo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnGuardarTodo.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnGuardarTodo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuardarTodo.IconSize = 20;
            this.BtnGuardarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarTodo.Location = new System.Drawing.Point(366, 22);
            this.BtnGuardarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardarTodo.Name = "BtnGuardarTodo";
            this.BtnGuardarTodo.Size = new System.Drawing.Size(203, 49);
            this.BtnGuardarTodo.TabIndex = 96;
            this.BtnGuardarTodo.Text = "Guardar";
            this.BtnGuardarTodo.UseVisualStyleBackColor = false;
            this.BtnGuardarTodo.Click += new System.EventHandler(this.BtnGuardarTodo_Click);
            // 
            // BtnEnlace
            // 
            this.BtnEnlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnEnlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEnlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEnlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnlace.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnlace.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEnlace.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEnlace.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEnlace.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEnlace.IconSize = 20;
            this.BtnEnlace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnlace.Location = new System.Drawing.Point(809, 17);
            this.BtnEnlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnlace.Name = "BtnEnlace";
            this.BtnEnlace.Size = new System.Drawing.Size(46, 40);
            this.BtnEnlace.TabIndex = 95;
            this.BtnEnlace.Text = "....";
            this.BtnEnlace.UseVisualStyleBackColor = false;
            this.BtnEnlace.Click += new System.EventHandler(this.BtnEnlace_Click);
            // 
            // BtnNuevoExamen
            // 
            this.BtnNuevoExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnNuevoExamen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevoExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoExamen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoExamen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoExamen.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoExamen.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoExamen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoExamen.IconSize = 20;
            this.BtnNuevoExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoExamen.Location = new System.Drawing.Point(57, 22);
            this.BtnNuevoExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoExamen.Name = "BtnNuevoExamen";
            this.BtnNuevoExamen.Size = new System.Drawing.Size(198, 49);
            this.BtnNuevoExamen.TabIndex = 94;
            this.BtnNuevoExamen.Text = "Cargar Plantilla";
            this.BtnNuevoExamen.UseVisualStyleBackColor = false;
            this.BtnNuevoExamen.Click += new System.EventHandler(this.BtnNuevoExamen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmNuevoExamen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnlgrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNuevoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Examen";
            this.Load += new System.EventHandler(this.FrmNuevoExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnlgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgexamen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txtruta;
        private System.Windows.Forms.Label Lblruta;
        private FontAwesome.Sharp.IconButton BtnCategoria;
        private System.Windows.Forms.ComboBox CMBCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txtid_examen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel Pnlgrid;
        private System.Windows.Forms.DataGridView Dtgexamen;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardarTodo;
        private FontAwesome.Sharp.IconButton BtnEnlace;
        private FontAwesome.Sharp.IconButton BtnNuevoExamen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}