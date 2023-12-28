namespace Proyecto_de_Graduacion
{
    partial class FrmNuevoPaciente
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
            this.gbdatospaciente = new System.Windows.Forms.GroupBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.PcBox = new System.Windows.Forms.PictureBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.gbdatospaciente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdatospaciente
            // 
            this.gbdatospaciente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbdatospaciente.Controls.Add(this.CmbSexo);
            this.gbdatospaciente.Controls.Add(this.LblSexo);
            this.gbdatospaciente.Controls.Add(this.txtTelefono);
            this.gbdatospaciente.Controls.Add(this.lblContraseña);
            this.gbdatospaciente.Controls.Add(this.TxtNombre);
            this.gbdatospaciente.Controls.Add(this.label1);
            this.gbdatospaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatospaciente.Location = new System.Drawing.Point(24, 25);
            this.gbdatospaciente.Name = "gbdatospaciente";
            this.gbdatospaciente.Size = new System.Drawing.Size(390, 284);
            this.gbdatospaciente.TabIndex = 1;
            this.gbdatospaciente.TabStop = false;
            this.gbdatospaciente.Text = "Datos del Paciente";
            // 
            // CmbSexo
            // 
            this.CmbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CmbSexo.Location = new System.Drawing.Point(119, 137);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(204, 32);
            this.CmbSexo.TabIndex = 50;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(17, 133);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(47, 21);
            this.LblSexo.TabIndex = 49;
            this.LblSexo.Text = "Sexo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(119, 193);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(204, 32);
            this.txtTelefono.TabIndex = 47;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(17, 189);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(78, 22);
            this.lblContraseña.TabIndex = 48;
            this.lblContraseña.Text = "Telefono";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(119, 82);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(204, 30);
            this.TxtNombre.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtFecha);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.PcBox);
            this.panel1.Location = new System.Drawing.Point(429, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 275);
            this.panel1.TabIndex = 2;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(39, 186);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(167, 18);
            this.LblFecha.TabIndex = 42;
            this.LblFecha.Text = "Fecha de Nacimiento";
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
            this.BtnGuardar.Location = new System.Drawing.Point(195, 339);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(341, 40);
            this.BtnGuardar.TabIndex = 49;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PcBox
            // 
            this.PcBox.Image = global::Proyecto_de_Graduacion.Properties.Resources.paciente_removebg_preview;
            this.PcBox.Location = new System.Drawing.Point(42, 23);
            this.PcBox.Name = "PcBox";
            this.PcBox.Size = new System.Drawing.Size(174, 138);
            this.PcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcBox.TabIndex = 0;
            this.PcBox.TabStop = false;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(28, 220);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(204, 30);
            this.TxtFecha.TabIndex = 51;
            // 
            // FrmNuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 392);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbdatospaciente);
            this.Name = "FrmNuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Paciente";
            this.gbdatospaciente.ResumeLayout(false);
            this.gbdatospaciente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbdatospaciente;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PcBox;
        private System.Windows.Forms.Label LblFecha;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TxtFecha;
    }
}