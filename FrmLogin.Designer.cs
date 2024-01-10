namespace Proyecto_de_Graduacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.Lblsesion = new System.Windows.Forms.Label();
            this.Btnmin = new System.Windows.Forms.Button();
            this.icncandado = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnlcontraseña = new System.Windows.Forms.Panel();
            this.pccandado = new System.Windows.Forms.PictureBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.pnltec = new System.Windows.Forms.Panel();
            this.pcusuario = new System.Windows.Forms.PictureBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icncandado)).BeginInit();
            this.panel3.SuspendLayout();
            this.Pnlcontraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccandado)).BeginInit();
            this.pnltec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(508, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(55, 48);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEntrar.Location = new System.Drawing.Point(116, 434);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(341, 40);
            this.BtnEntrar.TabIndex = 8;
            this.BtnEntrar.Text = "Verificar Usuario";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // Lblsesion
            // 
            this.Lblsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblsesion.AutoSize = true;
            this.Lblsesion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsesion.Location = new System.Drawing.Point(77, 205);
            this.Lblsesion.Name = "Lblsesion";
            this.Lblsesion.Size = new System.Drawing.Size(143, 24);
            this.Lblsesion.TabIndex = 9;
            this.Lblsesion.Text = "Inicio de Sesion";
            // 
            // Btnmin
            // 
            this.Btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmin.FlatAppearance.BorderSize = 0;
            this.Btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmin.Location = new System.Drawing.Point(462, 0);
            this.Btnmin.Name = "Btnmin";
            this.Btnmin.Size = new System.Drawing.Size(55, 48);
            this.Btnmin.TabIndex = 10;
            this.Btnmin.Text = "_";
            this.Btnmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnmin.UseVisualStyleBackColor = true;
            this.Btnmin.Click += new System.EventHandler(this.Btnmin_Click_1);
            // 
            // icncandado
            // 
            this.icncandado.Image = global::Proyecto_de_Graduacion.Properties.Resources.icono_removebg_preview;
            this.icncandado.Location = new System.Drawing.Point(351, 68);
            this.icncandado.Name = "icncandado";
            this.icncandado.Size = new System.Drawing.Size(138, 122);
            this.icncandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icncandado.TabIndex = 0;
            this.icncandado.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Pnlcontraseña);
            this.panel3.Controls.Add(this.pnltec);
            this.panel3.Location = new System.Drawing.Point(116, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 131);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 3);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 3);
            this.panel1.TabIndex = 16;
            // 
            // Pnlcontraseña
            // 
            this.Pnlcontraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnlcontraseña.Controls.Add(this.pccandado);
            this.Pnlcontraseña.Controls.Add(this.TxtContraseña);
            this.Pnlcontraseña.Location = new System.Drawing.Point(17, 72);
            this.Pnlcontraseña.Name = "Pnlcontraseña";
            this.Pnlcontraseña.Size = new System.Drawing.Size(304, 36);
            this.Pnlcontraseña.TabIndex = 15;
            // 
            // pccandado
            // 
            this.pccandado.BackColor = System.Drawing.Color.LightGray;
            this.pccandado.Image = global::Proyecto_de_Graduacion.Properties.Resources.iconodecandado_removebg_preview;
            this.pccandado.Location = new System.Drawing.Point(0, 3);
            this.pccandado.Name = "pccandado";
            this.pccandado.Size = new System.Drawing.Size(40, 28);
            this.pccandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pccandado.TabIndex = 2;
            this.pccandado.TabStop = false;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtContraseña.Location = new System.Drawing.Point(50, 9);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(251, 21);
            this.TxtContraseña.TabIndex = 1;
            this.TxtContraseña.Text = "Ingrese su contraseña";
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            // 
            // pnltec
            // 
            this.pnltec.BackColor = System.Drawing.Color.Gainsboro;
            this.pnltec.Controls.Add(this.pcusuario);
            this.pnltec.Controls.Add(this.TxtUser);
            this.pnltec.Location = new System.Drawing.Point(17, 11);
            this.pnltec.Name = "pnltec";
            this.pnltec.Size = new System.Drawing.Size(304, 33);
            this.pnltec.TabIndex = 14;
            // 
            // pcusuario
            // 
            this.pcusuario.Image = global::Proyecto_de_Graduacion.Properties.Resources.usuario_removebg_preview;
            this.pcusuario.Location = new System.Drawing.Point(0, 3);
            this.pcusuario.Name = "pcusuario";
            this.pcusuario.Size = new System.Drawing.Size(40, 24);
            this.pcusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcusuario.TabIndex = 1;
            this.pcusuario.TabStop = false;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtUser.Location = new System.Drawing.Point(50, 7);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(251, 21);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.Text = "Ingrese su usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(562, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Btnmin);
            this.Controls.Add(this.Lblsesion);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.icncandado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.icncandado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Pnlcontraseña.ResumeLayout(false);
            this.Pnlcontraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccandado)).EndInit();
            this.pnltec.ResumeLayout(false);
            this.pnltec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icncandado;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label Lblsesion;
        private System.Windows.Forms.Button Btnmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnlcontraseña;
        private System.Windows.Forms.PictureBox pccandado;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Panel pnltec;
        private System.Windows.Forms.PictureBox pcusuario;
        private System.Windows.Forms.TextBox TxtUser;
    }
}