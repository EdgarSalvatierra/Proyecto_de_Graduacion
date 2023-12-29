namespace Proyecto_de_Graduacion
{
    partial class FrmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.PnlCerrarMaximizar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PblHorario = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.PnlDesplegable = new System.Windows.Forms.Panel();
            this.PnlUser = new System.Windows.Forms.Panel();
            this.Lbluser = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlSistema = new System.Windows.Forms.Panel();
            this.BtnCerrarFormulario = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.LblSistemaLab = new System.Windows.Forms.Label();
            this.Lblsocorro = new System.Windows.Forms.Label();
            this.ICNCalendary = new FontAwesome.Sharp.IconPictureBox();
            this.ICNTimes = new FontAwesome.Sharp.IconPictureBox();
            this.IcnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.BtnConf = new FontAwesome.Sharp.IconButton();
            this.BtnCitas = new FontAwesome.Sharp.IconButton();
            this.BtnAd_Usuario = new FontAwesome.Sharp.IconButton();
            this.BtnGesti_Exa = new FontAwesome.Sharp.IconButton();
            this.BtnRes_Ex = new FontAwesome.Sharp.IconButton();
            this.BtnCompras = new FontAwesome.Sharp.IconButton();
            this.BtnReg_pas = new FontAwesome.Sharp.IconButton();
            this.BtnFac_m = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.IcnUsers = new FontAwesome.Sharp.IconPictureBox();
            this.PcLogo = new System.Windows.Forms.PictureBox();
            this.ICNMenu = new FontAwesome.Sharp.IconPictureBox();
            this.Btnmin = new FontAwesome.Sharp.IconButton();
            this.PnlCerrarMaximizar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PblHorario.SuspendLayout();
            this.PnlDesplegable.SuspendLayout();
            this.PnlUser.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            this.PnlSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNCalendary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICNTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICNMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCerrarMaximizar
            // 
            this.PnlCerrarMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.PnlCerrarMaximizar.Controls.Add(this.LblSistemaLab);
            this.PnlCerrarMaximizar.Controls.Add(this.Btnmin);
            this.PnlCerrarMaximizar.Controls.Add(this.button1);
            this.PnlCerrarMaximizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCerrarMaximizar.Location = new System.Drawing.Point(0, 0);
            this.PnlCerrarMaximizar.Name = "PnlCerrarMaximizar";
            this.PnlCerrarMaximizar.Size = new System.Drawing.Size(1392, 42);
            this.PnlCerrarMaximizar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1348, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Controls.Add(this.PnlMenu);
            this.panelDesktop.Controls.Add(this.PnlSistema);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 42);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1392, 882);
            this.panelDesktop.TabIndex = 3;
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlMenu.Controls.Add(this.PblHorario);
            this.PnlMenu.Controls.Add(this.PnlDesplegable);
            this.PnlMenu.Controls.Add(this.PnlUser);
            this.PnlMenu.Controls.Add(this.PnlLogo);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 60);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(346, 822);
            this.PnlMenu.TabIndex = 29;
            this.PnlMenu.MouseHover += new System.EventHandler(this.PnlMenu_MouseHover);
            // 
            // PblHorario
            // 
            this.PblHorario.Controls.Add(this.lblHora);
            this.PblHorario.Controls.Add(this.ICNCalendary);
            this.PblHorario.Controls.Add(this.LblFecha);
            this.PblHorario.Controls.Add(this.ICNTimes);
            this.PblHorario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PblHorario.Location = new System.Drawing.Point(0, 708);
            this.PblHorario.Name = "PblHorario";
            this.PblHorario.Size = new System.Drawing.Size(346, 114);
            this.PblHorario.TabIndex = 32;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.lblHora.Location = new System.Drawing.Point(70, 76);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 22);
            this.lblHora.TabIndex = 36;
            this.lblHora.Text = "--:--";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.LblFecha.Location = new System.Drawing.Point(70, 18);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(57, 23);
            this.LblFecha.TabIndex = 37;
            this.LblFecha.Text = "d/m/a";
            // 
            // PnlDesplegable
            // 
            this.PnlDesplegable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlDesplegable.Controls.Add(this.IcnCerrarSesion);
            this.PnlDesplegable.Controls.Add(this.BtnConf);
            this.PnlDesplegable.Controls.Add(this.BtnCitas);
            this.PnlDesplegable.Controls.Add(this.BtnAd_Usuario);
            this.PnlDesplegable.Controls.Add(this.BtnGesti_Exa);
            this.PnlDesplegable.Controls.Add(this.BtnRes_Ex);
            this.PnlDesplegable.Controls.Add(this.BtnCompras);
            this.PnlDesplegable.Controls.Add(this.BtnReg_pas);
            this.PnlDesplegable.Controls.Add(this.BtnFac_m);
            this.PnlDesplegable.Controls.Add(this.BtnHome);
            this.PnlDesplegable.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlDesplegable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDesplegable.Location = new System.Drawing.Point(0, 189);
            this.PnlDesplegable.Name = "PnlDesplegable";
            this.PnlDesplegable.Size = new System.Drawing.Size(346, 526);
            this.PnlDesplegable.TabIndex = 31;
            // 
            // PnlUser
            // 
            this.PnlUser.Controls.Add(this.IcnUsers);
            this.PnlUser.Controls.Add(this.Lbluser);
            this.PnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUser.Location = new System.Drawing.Point(0, 113);
            this.PnlUser.Name = "PnlUser";
            this.PnlUser.Size = new System.Drawing.Size(346, 76);
            this.PnlUser.TabIndex = 13;
            // 
            // Lbluser
            // 
            this.Lbluser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbluser.AutoSize = true;
            this.Lbluser.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.Lbluser.Location = new System.Drawing.Point(104, 26);
            this.Lbluser.Name = "Lbluser";
            this.Lbluser.Size = new System.Drawing.Size(51, 21);
            this.Lbluser.TabIndex = 7;
            this.Lbluser.Text = "Users";
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PcLogo);
            this.PnlLogo.Controls.Add(this.Lblsocorro);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(346, 113);
            this.PnlLogo.TabIndex = 12;
            // 
            // PnlSistema
            // 
            this.PnlSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.PnlSistema.Controls.Add(this.BtnCerrarFormulario);
            this.PnlSistema.Controls.Add(this.LblMenu);
            this.PnlSistema.Controls.Add(this.ICNMenu);
            this.PnlSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSistema.Location = new System.Drawing.Point(0, 0);
            this.PnlSistema.Name = "PnlSistema";
            this.PnlSistema.Size = new System.Drawing.Size(1392, 60);
            this.PnlSistema.TabIndex = 10;
            // 
            // BtnCerrarFormulario
            // 
            this.BtnCerrarFormulario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCerrarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarFormulario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCerrarFormulario.Location = new System.Drawing.Point(1129, 13);
            this.BtnCerrarFormulario.Name = "BtnCerrarFormulario";
            this.BtnCerrarFormulario.Size = new System.Drawing.Size(251, 39);
            this.BtnCerrarFormulario.TabIndex = 5;
            this.BtnCerrarFormulario.Text = "Cerrar Formulario";
            this.BtnCerrarFormulario.UseVisualStyleBackColor = true;
            this.BtnCerrarFormulario.Click += new System.EventHandler(this.BtnCerrarFormulario_Click);
            this.BtnCerrarFormulario.MouseHover += new System.EventHandler(this.BtnCerrarFormulario_MouseHover);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMenu.Location = new System.Drawing.Point(75, 16);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(162, 28);
            this.LblMenu.TabIndex = 4;
            this.LblMenu.Text = "Menu Principal";
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // LblSistemaLab
            // 
            this.LblSistemaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSistemaLab.AutoSize = true;
            this.LblSistemaLab.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemaLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSistemaLab.Location = new System.Drawing.Point(541, 7);
            this.LblSistemaLab.Name = "LblSistemaLab";
            this.LblSistemaLab.Size = new System.Drawing.Size(246, 23);
            this.LblSistemaLab.TabIndex = 4;
            this.LblSistemaLab.Text = "Sistema Socorro Lab";
            // 
            // Lblsocorro
            // 
            this.Lblsocorro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lblsocorro.AutoSize = true;
            this.Lblsocorro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsocorro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.Lblsocorro.Location = new System.Drawing.Point(92, 43);
            this.Lblsocorro.Name = "Lblsocorro";
            this.Lblsocorro.Size = new System.Drawing.Size(204, 24);
            this.Lblsocorro.TabIndex = 7;
            this.Lblsocorro.Text = "Laboratorio El Socorro";
            // 
            // ICNCalendary
            // 
            this.ICNCalendary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICNCalendary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ICNCalendary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.ICNCalendary.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.ICNCalendary.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.ICNCalendary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNCalendary.IconSize = 40;
            this.ICNCalendary.Location = new System.Drawing.Point(23, 18);
            this.ICNCalendary.Name = "ICNCalendary";
            this.ICNCalendary.Size = new System.Drawing.Size(40, 40);
            this.ICNCalendary.TabIndex = 38;
            this.ICNCalendary.TabStop = false;
            this.ICNCalendary.MouseHover += new System.EventHandler(this.ICNCalendary_MouseHover);
            // 
            // ICNTimes
            // 
            this.ICNTimes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICNTimes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ICNTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.ICNTimes.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ICNTimes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.ICNTimes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNTimes.IconSize = 40;
            this.ICNTimes.Location = new System.Drawing.Point(23, 64);
            this.ICNTimes.Name = "ICNTimes";
            this.ICNTimes.Size = new System.Drawing.Size(40, 45);
            this.ICNTimes.TabIndex = 39;
            this.ICNTimes.TabStop = false;
            this.ICNTimes.MouseHover += new System.EventHandler(this.ICNTimes_MouseHover);
            // 
            // IcnCerrarSesion
            // 
            this.IcnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.IcnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.IcnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.IcnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.IcnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcnCerrarSesion.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IcnCerrarSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnCerrarSesion.IconSize = 30;
            this.IcnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcnCerrarSesion.Location = new System.Drawing.Point(0, 452);
            this.IcnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IcnCerrarSesion.Name = "IcnCerrarSesion";
            this.IcnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IcnCerrarSesion.Size = new System.Drawing.Size(346, 62);
            this.IcnCerrarSesion.TabIndex = 29;
            this.IcnCerrarSesion.Tag = "CerrarSesion";
            this.IcnCerrarSesion.Text = "CerrarSesion";
            this.IcnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcnCerrarSesion.UseVisualStyleBackColor = true;
            this.IcnCerrarSesion.Click += new System.EventHandler(this.IcnCerrarSesion_Click);
            this.IcnCerrarSesion.MouseEnter += new System.EventHandler(this.IcnCerrarSesion_MouseEnter);
            // 
            // BtnConf
            // 
            this.BtnConf.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConf.FlatAppearance.BorderSize = 0;
            this.BtnConf.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConf.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConf.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnConf.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.BtnConf.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnConf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConf.IconSize = 30;
            this.BtnConf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConf.Location = new System.Drawing.Point(0, 402);
            this.BtnConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConf.Size = new System.Drawing.Size(346, 50);
            this.BtnConf.TabIndex = 25;
            this.BtnConf.Tag = "Configuracion";
            this.BtnConf.Text = "Configuracion";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConf.UseVisualStyleBackColor = true;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            this.BtnConf.MouseHover += new System.EventHandler(this.BtnConf_MouseHover);
            // 
            // BtnCitas
            // 
            this.BtnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCitas.FlatAppearance.BorderSize = 0;
            this.BtnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitas.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.BtnCitas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCitas.IconSize = 30;
            this.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.Location = new System.Drawing.Point(0, 353);
            this.BtnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCitas.Size = new System.Drawing.Size(346, 49);
            this.BtnCitas.TabIndex = 24;
            this.BtnCitas.Tag = "Citas";
            this.BtnCitas.Text = "Citas";
            this.BtnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCitas.UseVisualStyleBackColor = true;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            this.BtnCitas.MouseHover += new System.EventHandler(this.BtnCitas_MouseHover);
            // 
            // BtnAd_Usuario
            // 
            this.BtnAd_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAd_Usuario.FlatAppearance.BorderSize = 0;
            this.BtnAd_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAd_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAd_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAd_Usuario.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAd_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnAd_Usuario.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.BtnAd_Usuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnAd_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAd_Usuario.IconSize = 30;
            this.BtnAd_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAd_Usuario.Location = new System.Drawing.Point(0, 303);
            this.BtnAd_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAd_Usuario.Name = "BtnAd_Usuario";
            this.BtnAd_Usuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAd_Usuario.Size = new System.Drawing.Size(346, 50);
            this.BtnAd_Usuario.TabIndex = 23;
            this.BtnAd_Usuario.Tag = "Administracion de Usuario";
            this.BtnAd_Usuario.Text = "Administracion de Usuarios";
            this.BtnAd_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAd_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAd_Usuario.UseVisualStyleBackColor = true;
            this.BtnAd_Usuario.Click += new System.EventHandler(this.BtnAd_Usuario_Click);
            this.BtnAd_Usuario.MouseHover += new System.EventHandler(this.BtnAd_Usuario_MouseHover);
            // 
            // BtnGesti_Exa
            // 
            this.BtnGesti_Exa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGesti_Exa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGesti_Exa.FlatAppearance.BorderSize = 0;
            this.BtnGesti_Exa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGesti_Exa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGesti_Exa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGesti_Exa.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGesti_Exa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnGesti_Exa.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.BtnGesti_Exa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnGesti_Exa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGesti_Exa.IconSize = 30;
            this.BtnGesti_Exa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGesti_Exa.Location = new System.Drawing.Point(0, 253);
            this.BtnGesti_Exa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGesti_Exa.Name = "BtnGesti_Exa";
            this.BtnGesti_Exa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGesti_Exa.Size = new System.Drawing.Size(346, 50);
            this.BtnGesti_Exa.TabIndex = 22;
            this.BtnGesti_Exa.Tag = "Gestion de Examenes";
            this.BtnGesti_Exa.Text = "Gestion de Examenes";
            this.BtnGesti_Exa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGesti_Exa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGesti_Exa.UseVisualStyleBackColor = false;
            this.BtnGesti_Exa.Click += new System.EventHandler(this.BtnGesti_Exa_Click);
            this.BtnGesti_Exa.MouseHover += new System.EventHandler(this.BtnGesti_Exa_MouseHover);
            // 
            // BtnRes_Ex
            // 
            this.BtnRes_Ex.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRes_Ex.FlatAppearance.BorderSize = 0;
            this.BtnRes_Ex.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRes_Ex.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRes_Ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes_Ex.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes_Ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnRes_Ex.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.BtnRes_Ex.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnRes_Ex.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRes_Ex.IconSize = 30;
            this.BtnRes_Ex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRes_Ex.Location = new System.Drawing.Point(0, 200);
            this.BtnRes_Ex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRes_Ex.Name = "BtnRes_Ex";
            this.BtnRes_Ex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRes_Ex.Size = new System.Drawing.Size(346, 53);
            this.BtnRes_Ex.TabIndex = 21;
            this.BtnRes_Ex.Tag = "Resultados ";
            this.BtnRes_Ex.Text = "Resultados";
            this.BtnRes_Ex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRes_Ex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRes_Ex.UseVisualStyleBackColor = true;
            this.BtnRes_Ex.Click += new System.EventHandler(this.BtnRes_Ex_Click_1);
            this.BtnRes_Ex.MouseHover += new System.EventHandler(this.BtnRes_Ex_MouseHover);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.BtnCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompras.IconSize = 30;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 150);
            this.BtnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCompras.Size = new System.Drawing.Size(346, 50);
            this.BtnCompras.TabIndex = 20;
            this.BtnCompras.Tag = "Compras";
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = false;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            this.BtnCompras.MouseHover += new System.EventHandler(this.BtnCompras_MouseHover);
            // 
            // BtnReg_pas
            // 
            this.BtnReg_pas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReg_pas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReg_pas.FlatAppearance.BorderSize = 0;
            this.BtnReg_pas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReg_pas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReg_pas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg_pas.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg_pas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnReg_pas.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnReg_pas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnReg_pas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReg_pas.IconSize = 30;
            this.BtnReg_pas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReg_pas.Location = new System.Drawing.Point(0, 100);
            this.BtnReg_pas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReg_pas.Name = "BtnReg_pas";
            this.BtnReg_pas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReg_pas.Size = new System.Drawing.Size(346, 50);
            this.BtnReg_pas.TabIndex = 19;
            this.BtnReg_pas.Tag = "Registro del Paciente";
            this.BtnReg_pas.Text = "Registro de paciente";
            this.BtnReg_pas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReg_pas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReg_pas.UseVisualStyleBackColor = false;
            this.BtnReg_pas.Click += new System.EventHandler(this.BtnReg_pas_Click);
            this.BtnReg_pas.MouseHover += new System.EventHandler(this.BtnReg_pas_MouseHover);
            // 
            // BtnFac_m
            // 
            this.BtnFac_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFac_m.FlatAppearance.BorderSize = 0;
            this.BtnFac_m.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFac_m.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFac_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFac_m.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFac_m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnFac_m.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.BtnFac_m.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnFac_m.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFac_m.IconSize = 30;
            this.BtnFac_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFac_m.Location = new System.Drawing.Point(0, 50);
            this.BtnFac_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFac_m.Name = "BtnFac_m";
            this.BtnFac_m.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnFac_m.Size = new System.Drawing.Size(346, 50);
            this.BtnFac_m.TabIndex = 18;
            this.BtnFac_m.Tag = "Facturacion";
            this.BtnFac_m.Text = "Facturacion";
            this.BtnFac_m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFac_m.UseVisualStyleBackColor = true;
            this.BtnFac_m.Click += new System.EventHandler(this.BtnFac_m_Click);
            this.BtnFac_m.MouseHover += new System.EventHandler(this.BtnFac_m_MouseHover);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BtnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnHome.IconSize = 30;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(346, 50);
            this.BtnHome.TabIndex = 17;
            this.BtnHome.Tag = "Home";
            this.BtnHome.Text = "Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.MouseHover += new System.EventHandler(this.BtnHome_MouseHover);
            // 
            // IcnUsers
            // 
            this.IcnUsers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IcnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.IcnUsers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnUsers.IconSize = 52;
            this.IcnUsers.Location = new System.Drawing.Point(23, 6);
            this.IcnUsers.Name = "IcnUsers";
            this.IcnUsers.Size = new System.Drawing.Size(63, 52);
            this.IcnUsers.TabIndex = 8;
            this.IcnUsers.TabStop = false;
            this.IcnUsers.MouseHover += new System.EventHandler(this.IcnUsers_MouseHover);
            // 
            // PcLogo
            // 
            this.PcLogo.Image = ((System.Drawing.Image)(resources.GetObject("PcLogo.Image")));
            this.PcLogo.Location = new System.Drawing.Point(10, 4);
            this.PcLogo.Name = "PcLogo";
            this.PcLogo.Size = new System.Drawing.Size(76, 103);
            this.PcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcLogo.TabIndex = 8;
            this.PcLogo.TabStop = false;
            this.PcLogo.MouseHover += new System.EventHandler(this.PcLogo_MouseHover);
            // 
            // ICNMenu
            // 
            this.ICNMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICNMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.ICNMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICNMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.ICNMenu.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNMenu.IconSize = 30;
            this.ICNMenu.Location = new System.Drawing.Point(23, 16);
            this.ICNMenu.Name = "ICNMenu";
            this.ICNMenu.Size = new System.Drawing.Size(36, 30);
            this.ICNMenu.TabIndex = 0;
            this.ICNMenu.TabStop = false;
            this.ICNMenu.Click += new System.EventHandler(this.ICNMenu_Click_1);
            this.ICNMenu.MouseHover += new System.EventHandler(this.ICNMenu_MouseHover);
            // 
            // Btnmin
            // 
            this.Btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.Btnmin.FlatAppearance.BorderSize = 0;
            this.Btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Btnmin.IconColor = System.Drawing.Color.White;
            this.Btnmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btnmin.IconSize = 20;
            this.Btnmin.Location = new System.Drawing.Point(1306, 3);
            this.Btnmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnmin.Name = "Btnmin";
            this.Btnmin.Size = new System.Drawing.Size(36, 34);
            this.Btnmin.TabIndex = 3;
            this.Btnmin.UseVisualStyleBackColor = false;
            this.Btnmin.Click += new System.EventHandler(this.Btnmin_Click);
            this.Btnmin.MouseHover += new System.EventHandler(this.Btnmin_MouseHover);
            // 
            // FrmMDI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1392, 924);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PnlCerrarMaximizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMDI";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.PnlCerrarMaximizar.ResumeLayout(false);
            this.PnlCerrarMaximizar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PblHorario.ResumeLayout(false);
            this.PblHorario.PerformLayout();
            this.PnlDesplegable.ResumeLayout(false);
            this.PnlUser.ResumeLayout(false);
            this.PnlUser.PerformLayout();
            this.PnlLogo.ResumeLayout(false);
            this.PnlLogo.PerformLayout();
            this.PnlSistema.ResumeLayout(false);
            this.PnlSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNCalendary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICNTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICNMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCerrarMaximizar;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton Btnmin;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.Panel PnlSistema;
        private System.Windows.Forms.Button BtnCerrarFormulario;
        private System.Windows.Forms.Label LblMenu;
        private FontAwesome.Sharp.IconPictureBox ICNMenu;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PcLogo;
        private System.Windows.Forms.Panel PnlUser;
        private FontAwesome.Sharp.IconPictureBox IcnUsers;
        private System.Windows.Forms.Label Lbluser;
        private System.Windows.Forms.Panel PblHorario;
        private System.Windows.Forms.Label lblHora;
        private FontAwesome.Sharp.IconPictureBox ICNCalendary;
        private FontAwesome.Sharp.IconPictureBox ICNTimes;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel PnlDesplegable;
        private FontAwesome.Sharp.IconButton IcnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnConf;
        private FontAwesome.Sharp.IconButton BtnCitas;
        private FontAwesome.Sharp.IconButton BtnAd_Usuario;
        private FontAwesome.Sharp.IconButton BtnGesti_Exa;
        private FontAwesome.Sharp.IconButton BtnRes_Ex;
        private FontAwesome.Sharp.IconButton BtnCompras;
        private FontAwesome.Sharp.IconButton BtnReg_pas;
        private FontAwesome.Sharp.IconButton BtnFac_m;
        private FontAwesome.Sharp.IconButton BtnHome;
        private System.Windows.Forms.Label LblSistemaLab;
        private System.Windows.Forms.Label Lblsocorro;
    }
}