namespace Proyecto_de_Graduacion
{
    partial class FrmEditarExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarExamen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Txtruta = new System.Windows.Forms.TextBox();
            this.CMBCategoria = new System.Windows.Forms.ComboBox();
            this.Lblruta = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarTodo = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoExamen = new FontAwesome.Sharp.IconButton();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCodigoExamen = new System.Windows.Forms.Label();
            this.BtnEnlace = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblCodigoExamen);
            this.panel1.Controls.Add(this.BtnEnlace);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.LblPrecio);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.LblId);
            this.panel1.Controls.Add(this.Txtruta);
            this.panel1.Controls.Add(this.Lblruta);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.CMBCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 291);
            this.panel1.TabIndex = 98;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(169, 187);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(485, 31);
            this.txtNombre.TabIndex = 100;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(29, 26);
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
            this.lblNombre.Location = new System.Drawing.Point(29, 192);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 98;
            this.lblNombre.Text = "Examen";
            // 
            // Txtruta
            // 
            this.Txtruta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtruta.Location = new System.Drawing.Point(170, 136);
            this.Txtruta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtruta.Name = "Txtruta";
            this.Txtruta.Size = new System.Drawing.Size(431, 31);
            this.Txtruta.TabIndex = 108;
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.Location = new System.Drawing.Point(169, 81);
            this.CMBCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(432, 28);
            this.CMBCategoria.TabIndex = 105;
            // 
            // Lblruta
            // 
            this.Lblruta.AutoSize = true;
            this.Lblruta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblruta.Location = new System.Drawing.Point(29, 141);
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
            this.LblCategoria.Location = new System.Drawing.Point(29, 81);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(87, 20);
            this.LblCategoria.TabIndex = 104;
            this.LblCategoria.Text = "Categoria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnGuardarTodo);
            this.panel2.Controls.Add(this.BtnNuevoExamen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 93);
            this.panel2.TabIndex = 100;
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
            this.BtnCancelar.Location = new System.Drawing.Point(466, 21);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(189, 49);
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
            this.BtnGuardarTodo.Location = new System.Drawing.Point(238, 21);
            this.BtnGuardarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardarTodo.Name = "BtnGuardarTodo";
            this.BtnGuardarTodo.Size = new System.Drawing.Size(203, 49);
            this.BtnGuardarTodo.TabIndex = 96;
            this.BtnGuardarTodo.Text = "Guardar";
            this.BtnGuardarTodo.UseVisualStyleBackColor = false;
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
            this.BtnNuevoExamen.Location = new System.Drawing.Point(12, 21);
            this.BtnNuevoExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoExamen.Name = "BtnNuevoExamen";
            this.BtnNuevoExamen.Size = new System.Drawing.Size(198, 49);
            this.BtnNuevoExamen.TabIndex = 94;
            this.BtnNuevoExamen.Text = "Cargar Plantilla";
            this.BtnNuevoExamen.UseVisualStyleBackColor = false;
            this.BtnNuevoExamen.Click += new System.EventHandler(this.BtnNuevoExamen_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(170, 239);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(484, 31);
            this.TxtPrecio.TabIndex = 110;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(29, 244);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(60, 20);
            this.LblPrecio.TabIndex = 109;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCodigoExamen
            // 
            this.LblCodigoExamen.AutoSize = true;
            this.LblCodigoExamen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoExamen.Location = new System.Drawing.Point(166, 26);
            this.LblCodigoExamen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigoExamen.Name = "LblCodigoExamen";
            this.LblCodigoExamen.Size = new System.Drawing.Size(27, 20);
            this.LblCodigoExamen.TabIndex = 112;
            this.LblCodigoExamen.Text = "...";
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
            this.BtnEnlace.Location = new System.Drawing.Point(609, 129);
            this.BtnEnlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnlace.Name = "BtnEnlace";
            this.BtnEnlace.Size = new System.Drawing.Size(46, 32);
            this.BtnEnlace.TabIndex = 111;
            this.BtnEnlace.Text = "....";
            this.BtnEnlace.UseVisualStyleBackColor = false;
            this.BtnEnlace.Click += new System.EventHandler(this.BtnEnlace_Click);
            // 
            // FrmEditarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Examen";
            this.Load += new System.EventHandler(this.FrmEditarExamen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox Txtruta;
        private System.Windows.Forms.ComboBox CMBCategoria;
        private System.Windows.Forms.Label Lblruta;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardarTodo;
        private FontAwesome.Sharp.IconButton BtnNuevoExamen;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCodigoExamen;
        private FontAwesome.Sharp.IconButton BtnEnlace;
    }
}