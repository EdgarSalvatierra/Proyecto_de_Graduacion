namespace Proyecto_de_Graduacion
{
    partial class FrmConfiguracion
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
            this.Pnlarchivo = new System.Windows.Forms.Panel();
            this.TxtArchivodelIcono = new System.Windows.Forms.TextBox();
            this.LnlNuevoIcono = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.gbtamaño = new System.Windows.Forms.GroupBox();
            this.Pnlmensajes = new System.Windows.Forms.Panel();
            this.LstMensajedecambios = new System.Windows.Forms.ListBox();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblTamaño = new System.Windows.Forms.Label();
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.TxtFuente = new System.Windows.Forms.TextBox();
            this.LblFuente = new System.Windows.Forms.Label();
            this.gbcambiartamaño = new System.Windows.Forms.GroupBox();
            this.gbPropiedades = new System.Windows.Forms.GroupBox();
            this.BtnRestablece = new System.Windows.Forms.Button();
            this.RBAmpliar = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Lblcambiartamaño = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lbllefttop = new System.Windows.Forms.Label();
            this.Pclogo = new System.Windows.Forms.PictureBox();
            this.Lbllogo = new System.Windows.Forms.Label();
            this.Pnlarchivo.SuspendLayout();
            this.gbtamaño.SuspendLayout();
            this.Pnlmensajes.SuspendLayout();
            this.gbcambiartamaño.SuspendLayout();
            this.gbPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnlarchivo
            // 
            this.Pnlarchivo.Controls.Add(this.BtnSeleccionar);
            this.Pnlarchivo.Controls.Add(this.LnlNuevoIcono);
            this.Pnlarchivo.Controls.Add(this.TxtArchivodelIcono);
            this.Pnlarchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlarchivo.Location = new System.Drawing.Point(0, 0);
            this.Pnlarchivo.Name = "Pnlarchivo";
            this.Pnlarchivo.Size = new System.Drawing.Size(900, 67);
            this.Pnlarchivo.TabIndex = 0;
            // 
            // TxtArchivodelIcono
            // 
            this.TxtArchivodelIcono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtArchivodelIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivodelIcono.Location = new System.Drawing.Point(151, 23);
            this.TxtArchivodelIcono.Name = "TxtArchivodelIcono";
            this.TxtArchivodelIcono.Size = new System.Drawing.Size(564, 30);
            this.TxtArchivodelIcono.TabIndex = 0;
            // 
            // LnlNuevoIcono
            // 
            this.LnlNuevoIcono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LnlNuevoIcono.AutoSize = true;
            this.LnlNuevoIcono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LnlNuevoIcono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnlNuevoIcono.Location = new System.Drawing.Point(12, 26);
            this.LnlNuevoIcono.Name = "LnlNuevoIcono";
            this.LnlNuevoIcono.Size = new System.Drawing.Size(97, 18);
            this.LnlNuevoIcono.TabIndex = 1;
            this.LnlNuevoIcono.Text = "Cambiar logo";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(744, 20);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(144, 32);
            this.BtnSeleccionar.TabIndex = 2;
            this.BtnSeleccionar.Text = "Seleccionar...";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // gbtamaño
            // 
            this.gbtamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtamaño.Controls.Add(this.Lbllefttop);
            this.gbtamaño.Controls.Add(this.TxtFuente);
            this.gbtamaño.Controls.Add(this.LblFuente);
            this.gbtamaño.Controls.Add(this.TxtTamaño);
            this.gbtamaño.Controls.Add(this.LblTamaño);
            this.gbtamaño.Location = new System.Drawing.Point(15, 366);
            this.gbtamaño.Name = "gbtamaño";
            this.gbtamaño.Size = new System.Drawing.Size(668, 176);
            this.gbtamaño.TabIndex = 1;
            this.gbtamaño.TabStop = false;
            this.gbtamaño.Text = "Tamaño y posicion";
            // 
            // Pnlmensajes
            // 
            this.Pnlmensajes.Controls.Add(this.BtnGuardar);
            this.Pnlmensajes.Controls.Add(this.BtnCancelar);
            this.Pnlmensajes.Controls.Add(this.BtnAplicar);
            this.Pnlmensajes.Controls.Add(this.LstMensajedecambios);
            this.Pnlmensajes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlmensajes.Location = new System.Drawing.Point(0, 562);
            this.Pnlmensajes.Name = "Pnlmensajes";
            this.Pnlmensajes.Size = new System.Drawing.Size(900, 138);
            this.Pnlmensajes.TabIndex = 2;
            // 
            // LstMensajedecambios
            // 
            this.LstMensajedecambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LstMensajedecambios.BackColor = System.Drawing.SystemColors.Info;
            this.LstMensajedecambios.FormattingEnabled = true;
            this.LstMensajedecambios.ItemHeight = 16;
            this.LstMensajedecambios.Location = new System.Drawing.Point(15, 14);
            this.LstMensajedecambios.Name = "LstMensajedecambios";
            this.LstMensajedecambios.Size = new System.Drawing.Size(668, 116);
            this.LstMensajedecambios.TabIndex = 0;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAplicar.Location = new System.Drawing.Point(744, 14);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(116, 34);
            this.BtnAplicar.TabIndex = 1;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCancelar.Location = new System.Drawing.Point(744, 93);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 33);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnGuardar.Location = new System.Drawing.Point(744, 54);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 33);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // LblTamaño
            // 
            this.LblTamaño.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTamaño.AutoSize = true;
            this.LblTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTamaño.Location = new System.Drawing.Point(23, 66);
            this.LblTamaño.Name = "LblTamaño";
            this.LblTamaño.Size = new System.Drawing.Size(71, 18);
            this.LblTamaño.TabIndex = 2;
            this.LblTamaño.Text = "Tamaño: ";
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTamaño.Location = new System.Drawing.Point(124, 50);
            this.TxtTamaño.Multiline = true;
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(201, 110);
            this.TxtTamaño.TabIndex = 3;
            // 
            // TxtFuente
            // 
            this.TxtFuente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFuente.Location = new System.Drawing.Point(442, 50);
            this.TxtFuente.Multiline = true;
            this.TxtFuente.Name = "TxtFuente";
            this.TxtFuente.Size = new System.Drawing.Size(209, 110);
            this.TxtFuente.TabIndex = 5;
            // 
            // LblFuente
            // 
            this.LblFuente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFuente.AutoSize = true;
            this.LblFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuente.Location = new System.Drawing.Point(350, 66);
            this.LblFuente.Name = "LblFuente";
            this.LblFuente.Size = new System.Drawing.Size(61, 18);
            this.LblFuente.TabIndex = 4;
            this.LblFuente.Text = "Fuente: ";
            // 
            // gbcambiartamaño
            // 
            this.gbcambiartamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbcambiartamaño.Controls.Add(this.comboBox1);
            this.gbcambiartamaño.Controls.Add(this.Lblcambiartamaño);
            this.gbcambiartamaño.Controls.Add(this.radioButton1);
            this.gbcambiartamaño.Controls.Add(this.RBAmpliar);
            this.gbcambiartamaño.Controls.Add(this.BtnRestablece);
            this.gbcambiartamaño.Location = new System.Drawing.Point(694, 73);
            this.gbcambiartamaño.Name = "gbcambiartamaño";
            this.gbcambiartamaño.Size = new System.Drawing.Size(194, 263);
            this.gbcambiartamaño.TabIndex = 3;
            this.gbcambiartamaño.TabStop = false;
            this.gbcambiartamaño.Text = "Cambiar Tamaño";
            // 
            // gbPropiedades
            // 
            this.gbPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPropiedades.Controls.Add(this.Lbllogo);
            this.gbPropiedades.Controls.Add(this.Pclogo);
            this.gbPropiedades.Location = new System.Drawing.Point(15, 73);
            this.gbPropiedades.Name = "gbPropiedades";
            this.gbPropiedades.Size = new System.Drawing.Size(673, 263);
            this.gbPropiedades.TabIndex = 4;
            this.gbPropiedades.TabStop = false;
            this.gbPropiedades.Text = "Propiedades";
            // 
            // BtnRestablece
            // 
            this.BtnRestablece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestablece.Location = new System.Drawing.Point(6, 221);
            this.BtnRestablece.Name = "BtnRestablece";
            this.BtnRestablece.Size = new System.Drawing.Size(182, 36);
            this.BtnRestablece.TabIndex = 0;
            this.BtnRestablece.Text = "Restablecer Fuente";
            this.BtnRestablece.UseVisualStyleBackColor = true;
            // 
            // RBAmpliar
            // 
            this.RBAmpliar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RBAmpliar.AutoSize = true;
            this.RBAmpliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBAmpliar.Location = new System.Drawing.Point(23, 44);
            this.RBAmpliar.Name = "RBAmpliar";
            this.RBAmpliar.Size = new System.Drawing.Size(87, 24);
            this.RBAmpliar.TabIndex = 1;
            this.RBAmpliar.TabStop = true;
            this.RBAmpliar.Text = "Ampliar";
            this.RBAmpliar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(23, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reducir";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Lblcambiartamaño
            // 
            this.Lblcambiartamaño.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lblcambiartamaño.AutoSize = true;
            this.Lblcambiartamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lblcambiartamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcambiartamaño.Location = new System.Drawing.Point(20, 152);
            this.Lblcambiartamaño.Name = "Lblcambiartamaño";
            this.Lblcambiartamaño.Size = new System.Drawing.Size(21, 18);
            this.Lblcambiartamaño.TabIndex = 3;
            this.Lblcambiartamaño.Text = "%";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.comboBox1.Location = new System.Drawing.Point(48, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Lbllefttop
            // 
            this.Lbllefttop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbllefttop.AutoSize = true;
            this.Lbllefttop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbllefttop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbllefttop.Location = new System.Drawing.Point(423, 18);
            this.Lbllefttop.Name = "Lbllefttop";
            this.Lbllefttop.Size = new System.Drawing.Size(28, 18);
            this.Lbllefttop.TabIndex = 6;
            this.Lbllefttop.Text = ".... ";
            // 
            // Pclogo
            // 
            this.Pclogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pclogo.Location = new System.Drawing.Point(426, 21);
            this.Pclogo.Name = "Pclogo";
            this.Pclogo.Size = new System.Drawing.Size(241, 204);
            this.Pclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pclogo.TabIndex = 0;
            this.Pclogo.TabStop = false;
            // 
            // Lbllogo
            // 
            this.Lbllogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbllogo.AutoSize = true;
            this.Lbllogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbllogo.Location = new System.Drawing.Point(516, 228);
            this.Lbllogo.Name = "Lbllogo";
            this.Lbllogo.Size = new System.Drawing.Size(34, 20);
            this.Lbllogo.TabIndex = 7;
            this.Lbllogo.Text = ".....";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.gbPropiedades);
            this.Controls.Add(this.gbcambiartamaño);
            this.Controls.Add(this.Pnlmensajes);
            this.Controls.Add(this.gbtamaño);
            this.Controls.Add(this.Pnlarchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.Pnlarchivo.ResumeLayout(false);
            this.Pnlarchivo.PerformLayout();
            this.gbtamaño.ResumeLayout(false);
            this.gbtamaño.PerformLayout();
            this.Pnlmensajes.ResumeLayout(false);
            this.gbcambiartamaño.ResumeLayout(false);
            this.gbcambiartamaño.PerformLayout();
            this.gbPropiedades.ResumeLayout(false);
            this.gbPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlarchivo;
        private System.Windows.Forms.TextBox TxtArchivodelIcono;
        private System.Windows.Forms.Label LnlNuevoIcono;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.GroupBox gbtamaño;
        private System.Windows.Forms.Panel Pnlmensajes;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.ListBox LstMensajedecambios;
        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Label LblTamaño;
        private System.Windows.Forms.TextBox TxtFuente;
        private System.Windows.Forms.Label LblFuente;
        private System.Windows.Forms.GroupBox gbcambiartamaño;
        private System.Windows.Forms.Button BtnRestablece;
        private System.Windows.Forms.GroupBox gbPropiedades;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RBAmpliar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lblcambiartamaño;
        private System.Windows.Forms.Label Lbllefttop;
        private System.Windows.Forms.Label Lbllogo;
        private System.Windows.Forms.PictureBox Pclogo;
    }
}