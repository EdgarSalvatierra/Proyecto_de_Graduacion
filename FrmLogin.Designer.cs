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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.Btnmin = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Pnlloginh2 = new System.Windows.Forms.Panel();
            this.BtnEntrar = new FontAwesome.Sharp.IconButton();
            this.Pnlcontraseña = new System.Windows.Forms.Panel();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblContraseñas = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblIniciosesion = new System.Windows.Forms.Label();
            this.ICNUser = new FontAwesome.Sharp.IconPictureBox();
            this.PnlLogin.SuspendLayout();
            this.Pnlloginh2.SuspendLayout();
            this.Pnlcontraseña.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.SystemColors.Control;
            this.PnlLogin.Controls.Add(this.Btnmin);
            this.PnlLogin.Controls.Add(this.BtnClose);
            this.PnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogin.Location = new System.Drawing.Point(0, 0);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(496, 40);
            this.PnlLogin.TabIndex = 1;
            // 
            // Btnmin
            // 
            this.Btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmin.BackColor = System.Drawing.SystemColors.Control;
            this.Btnmin.FlatAppearance.BorderSize = 0;
            this.Btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Btnmin.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btnmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btnmin.IconSize = 20;
            this.Btnmin.Location = new System.Drawing.Point(412, 2);
            this.Btnmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnmin.Name = "Btnmin";
            this.Btnmin.Size = new System.Drawing.Size(36, 32);
            this.Btnmin.TabIndex = 5;
            this.Btnmin.UseVisualStyleBackColor = false;
            this.Btnmin.Click += new System.EventHandler(this.Btnmin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.Location = new System.Drawing.Point(454, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(41, 33);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Pnlloginh2
            // 
            this.Pnlloginh2.BackColor = System.Drawing.SystemColors.Control;
            this.Pnlloginh2.Controls.Add(this.BtnEntrar);
            this.Pnlloginh2.Controls.Add(this.Pnlcontraseña);
            this.Pnlloginh2.Controls.Add(this.PnlBuscare);
            this.Pnlloginh2.Controls.Add(this.LblContraseñas);
            this.Pnlloginh2.Controls.Add(this.LblUsuario);
            this.Pnlloginh2.Controls.Add(this.LblIniciosesion);
            this.Pnlloginh2.Controls.Add(this.ICNUser);
            this.Pnlloginh2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlloginh2.Location = new System.Drawing.Point(0, 40);
            this.Pnlloginh2.Name = "Pnlloginh2";
            this.Pnlloginh2.Size = new System.Drawing.Size(496, 427);
            this.Pnlloginh2.TabIndex = 2;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEntrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnEntrar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.BtnEntrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnEntrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEntrar.IconSize = 20;
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrar.Location = new System.Drawing.Point(129, 366);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(284, 51);
            this.BtnEntrar.TabIndex = 52;
            this.BtnEntrar.Text = "Entrar Sesion";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // Pnlcontraseña
            // 
            this.Pnlcontraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pnlcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlcontraseña.Controls.Add(this.TxtContraseña);
            this.Pnlcontraseña.Location = new System.Drawing.Point(129, 292);
            this.Pnlcontraseña.Name = "Pnlcontraseña";
            this.Pnlcontraseña.Size = new System.Drawing.Size(284, 35);
            this.Pnlcontraseña.TabIndex = 25;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(3, 10);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(276, 20);
            this.TxtContraseña.TabIndex = 0;
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtUser);
            this.PnlBuscare.Location = new System.Drawing.Point(129, 206);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(284, 35);
            this.PnlBuscare.TabIndex = 24;
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtUser.Location = new System.Drawing.Point(3, 8);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(276, 20);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            // 
            // LblContraseñas
            // 
            this.LblContraseñas.AutoSize = true;
            this.LblContraseñas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseñas.ForeColor = System.Drawing.Color.Black;
            this.LblContraseñas.Location = new System.Drawing.Point(12, 298);
            this.LblContraseñas.Name = "LblContraseñas";
            this.LblContraseñas.Size = new System.Drawing.Size(103, 22);
            this.LblContraseñas.TabIndex = 23;
            this.LblContraseñas.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblUsuario.Location = new System.Drawing.Point(12, 206);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 22);
            this.LblUsuario.TabIndex = 22;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblIniciosesion
            // 
            this.LblIniciosesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIniciosesion.AutoSize = true;
            this.LblIniciosesion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIniciosesion.Location = new System.Drawing.Point(175, 13);
            this.LblIniciosesion.Name = "LblIniciosesion";
            this.LblIniciosesion.Size = new System.Drawing.Size(124, 22);
            this.LblIniciosesion.TabIndex = 6;
            this.LblIniciosesion.Text = "Inicio Sesion";
            // 
            // ICNUser
            // 
            this.ICNUser.BackColor = System.Drawing.SystemColors.Control;
            this.ICNUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ICNUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ICNUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ICNUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNUser.IconSize = 112;
            this.ICNUser.Location = new System.Drawing.Point(172, 46);
            this.ICNUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ICNUser.Name = "ICNUser";
            this.ICNUser.Size = new System.Drawing.Size(127, 112);
            this.ICNUser.TabIndex = 21;
            this.ICNUser.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(496, 470);
            this.Controls.Add(this.Pnlloginh2);
            this.Controls.Add(this.PnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlLogin.ResumeLayout(false);
            this.Pnlloginh2.ResumeLayout(false);
            this.Pnlloginh2.PerformLayout();
            this.Pnlcontraseña.ResumeLayout(false);
            this.Pnlcontraseña.PerformLayout();
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private FontAwesome.Sharp.IconButton Btnmin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel Pnlloginh2;
        private System.Windows.Forms.Label LblIniciosesion;
        private FontAwesome.Sharp.IconPictureBox ICNUser;
        private System.Windows.Forms.Label LblContraseñas;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Panel Pnlcontraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtUser;
        private FontAwesome.Sharp.IconButton BtnEntrar;
    }
}