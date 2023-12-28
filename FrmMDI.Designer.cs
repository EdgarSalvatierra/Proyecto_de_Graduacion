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
            this.PnlCerrarMaximizar = new System.Windows.Forms.Panel();
            this.LblSistemaLab = new System.Windows.Forms.Label();
            this.Btnmin = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlSistema = new System.Windows.Forms.Panel();
            this.BtnCerrarFormulario = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.ICNMenu = new FontAwesome.Sharp.IconPictureBox();
            this.PnlDesplegable = new System.Windows.Forms.Panel();
            this.IcnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.BtnConf = new FontAwesome.Sharp.IconButton();
            this.BtnCitas = new FontAwesome.Sharp.IconButton();
            this.BtnAd_Usuario = new FontAwesome.Sharp.IconButton();
            this.BtnGesti_Exa = new FontAwesome.Sharp.IconButton();
            this.BtnRes_Ex = new FontAwesome.Sharp.IconButton();
            this.BtnCompras = new FontAwesome.Sharp.IconButton();
            this.BtnReg_pas = new FontAwesome.Sharp.IconButton();
            this.BtnFac_m = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PcLaboratorio = new System.Windows.Forms.PictureBox();
            this.LblLaboratorio = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.PnlCerrarMaximizar.SuspendLayout();
            this.PnlSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNMenu)).BeginInit();
            this.PnlDesplegable.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcLaboratorio)).BeginInit();
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
            this.PnlCerrarMaximizar.Size = new System.Drawing.Size(1265, 42);
            this.PnlCerrarMaximizar.TabIndex = 0;
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
            this.Btnmin.Location = new System.Drawing.Point(1179, 3);
            this.Btnmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnmin.Name = "Btnmin";
            this.Btnmin.Size = new System.Drawing.Size(36, 34);
            this.Btnmin.TabIndex = 3;
            this.Btnmin.UseVisualStyleBackColor = false;
            this.Btnmin.Click += new System.EventHandler(this.Btnmin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1221, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlSistema
            // 
            this.PnlSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(165)))));
            this.PnlSistema.Controls.Add(this.BtnCerrarFormulario);
            this.PnlSistema.Controls.Add(this.LblMenu);
            this.PnlSistema.Controls.Add(this.ICNMenu);
            this.PnlSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSistema.Location = new System.Drawing.Point(0, 42);
            this.PnlSistema.Name = "PnlSistema";
            this.PnlSistema.Size = new System.Drawing.Size(1265, 60);
            this.PnlSistema.TabIndex = 1;
            // 
            // BtnCerrarFormulario
            // 
            this.BtnCerrarFormulario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCerrarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarFormulario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCerrarFormulario.Location = new System.Drawing.Point(1002, 13);
            this.BtnCerrarFormulario.Name = "BtnCerrarFormulario";
            this.BtnCerrarFormulario.Size = new System.Drawing.Size(251, 39);
            this.BtnCerrarFormulario.TabIndex = 5;
            this.BtnCerrarFormulario.Text = "Cerrar Formulario";
            this.BtnCerrarFormulario.UseVisualStyleBackColor = true;
            this.BtnCerrarFormulario.Click += new System.EventHandler(this.BtnCerrarFormulario_Click);
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
            this.ICNMenu.Click += new System.EventHandler(this.ICNMenu_Click);
            // 
            // PnlDesplegable
            // 
            this.PnlDesplegable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlDesplegable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDesplegable.Controls.Add(this.IcnCerrarSesion);
            this.PnlDesplegable.Controls.Add(this.panel1);
            this.PnlDesplegable.Controls.Add(this.lblHora);
            this.PnlDesplegable.Controls.Add(this.LblFecha);
            this.PnlDesplegable.Controls.Add(this.BtnConf);
            this.PnlDesplegable.Controls.Add(this.BtnCitas);
            this.PnlDesplegable.Controls.Add(this.BtnAd_Usuario);
            this.PnlDesplegable.Controls.Add(this.BtnGesti_Exa);
            this.PnlDesplegable.Controls.Add(this.BtnRes_Ex);
            this.PnlDesplegable.Controls.Add(this.BtnCompras);
            this.PnlDesplegable.Controls.Add(this.BtnReg_pas);
            this.PnlDesplegable.Controls.Add(this.BtnFac_m);
            this.PnlDesplegable.Controls.Add(this.BtnHome);
            this.PnlDesplegable.Controls.Add(this.PnlLogo);
            this.PnlDesplegable.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlDesplegable.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlDesplegable.Location = new System.Drawing.Point(0, 102);
            this.PnlDesplegable.Name = "PnlDesplegable";
            this.PnlDesplegable.Size = new System.Drawing.Size(304, 713);
            this.PnlDesplegable.TabIndex = 2;
            this.PnlDesplegable.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDesplegable_Paint);
            // 
            // IcnCerrarSesion
            // 
            this.IcnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IcnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.IcnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.IcnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.IcnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcnCerrarSesion.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.IcnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IcnCerrarSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.IcnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnCerrarSesion.IconSize = 30;
            this.IcnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcnCerrarSesion.Location = new System.Drawing.Point(3, 546);
            this.IcnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IcnCerrarSesion.Name = "IcnCerrarSesion";
            this.IcnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IcnCerrarSesion.Size = new System.Drawing.Size(302, 50);
            this.IcnCerrarSesion.TabIndex = 29;
            this.IcnCerrarSesion.Tag = "CerrarSesion";
            this.IcnCerrarSesion.Text = "CerrarSesion";
            this.IcnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcnCerrarSesion.UseVisualStyleBackColor = true;
            this.IcnCerrarSesion.Click += new System.EventHandler(this.IcnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(2, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 28;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.lblHora.Location = new System.Drawing.Point(21, 669);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 22);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "--:--";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.LblFecha.Location = new System.Drawing.Point(18, 625);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(55, 22);
            this.LblFecha.TabIndex = 27;
            this.LblFecha.Text = "d/m/a";
            // 
            // BtnConf
            // 
            this.BtnConf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConf.FlatAppearance.BorderSize = 0;
            this.BtnConf.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConf.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConf.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.BtnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnConf.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.BtnConf.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnConf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConf.IconSize = 30;
            this.BtnConf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConf.Location = new System.Drawing.Point(0, 484);
            this.BtnConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConf.Size = new System.Drawing.Size(302, 50);
            this.BtnConf.TabIndex = 25;
            this.BtnConf.Tag = "Configuracion";
            this.BtnConf.Text = "Configuracion";
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConf.UseVisualStyleBackColor = true;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // BtnCitas
            // 
            this.BtnCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCitas.FlatAppearance.BorderSize = 0;
            this.BtnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitas.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.BtnCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.BtnCitas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCitas.IconSize = 30;
            this.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.Location = new System.Drawing.Point(0, 437);
            this.BtnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCitas.Size = new System.Drawing.Size(302, 49);
            this.BtnCitas.TabIndex = 24;
            this.BtnCitas.Tag = "Citas";
            this.BtnCitas.Text = "Citas";
            this.BtnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCitas.UseVisualStyleBackColor = true;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            // 
            // BtnAd_Usuario
            // 
            this.BtnAd_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAd_Usuario.FlatAppearance.BorderSize = 0;
            this.BtnAd_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAd_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAd_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAd_Usuario.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.BtnAd_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnAd_Usuario.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.BtnAd_Usuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnAd_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAd_Usuario.IconSize = 30;
            this.BtnAd_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAd_Usuario.Location = new System.Drawing.Point(0, 382);
            this.BtnAd_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAd_Usuario.Name = "BtnAd_Usuario";
            this.BtnAd_Usuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAd_Usuario.Size = new System.Drawing.Size(302, 50);
            this.BtnAd_Usuario.TabIndex = 23;
            this.BtnAd_Usuario.Tag = "Administracion de Usuario";
            this.BtnAd_Usuario.Text = "Administracion de Usuarios";
            this.BtnAd_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAd_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAd_Usuario.UseVisualStyleBackColor = true;
            this.BtnAd_Usuario.Click += new System.EventHandler(this.BtnAd_Usuario_Click_1);
            // 
            // BtnGesti_Exa
            // 
            this.BtnGesti_Exa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGesti_Exa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGesti_Exa.FlatAppearance.BorderSize = 0;
            this.BtnGesti_Exa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGesti_Exa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGesti_Exa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGesti_Exa.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.BtnGesti_Exa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnGesti_Exa.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.BtnGesti_Exa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnGesti_Exa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGesti_Exa.IconSize = 30;
            this.BtnGesti_Exa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGesti_Exa.Location = new System.Drawing.Point(0, 331);
            this.BtnGesti_Exa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGesti_Exa.Name = "BtnGesti_Exa";
            this.BtnGesti_Exa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnGesti_Exa.Size = new System.Drawing.Size(302, 50);
            this.BtnGesti_Exa.TabIndex = 22;
            this.BtnGesti_Exa.Tag = "Gestion de Examenes";
            this.BtnGesti_Exa.Text = "Gestion de Examenes";
            this.BtnGesti_Exa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGesti_Exa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGesti_Exa.UseVisualStyleBackColor = false;
            this.BtnGesti_Exa.Click += new System.EventHandler(this.BtnGesti_Exa_Click);
            // 
            // BtnRes_Ex
            // 
            this.BtnRes_Ex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRes_Ex.FlatAppearance.BorderSize = 0;
            this.BtnRes_Ex.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRes_Ex.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRes_Ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes_Ex.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes_Ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnRes_Ex.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.BtnRes_Ex.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnRes_Ex.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRes_Ex.IconSize = 30;
            this.BtnRes_Ex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRes_Ex.Location = new System.Drawing.Point(0, 280);
            this.BtnRes_Ex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRes_Ex.Name = "BtnRes_Ex";
            this.BtnRes_Ex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRes_Ex.Size = new System.Drawing.Size(302, 50);
            this.BtnRes_Ex.TabIndex = 21;
            this.BtnRes_Ex.Tag = "Resultados ";
            this.BtnRes_Ex.Text = "Resultados";
            this.BtnRes_Ex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRes_Ex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRes_Ex.UseVisualStyleBackColor = true;
            this.BtnRes_Ex.Click += new System.EventHandler(this.BtnRes_Ex_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.BtnCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompras.IconSize = 30;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 229);
            this.BtnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCompras.Size = new System.Drawing.Size(302, 50);
            this.BtnCompras.TabIndex = 20;
            this.BtnCompras.Tag = "Compras";
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = false;
            this.BtnCompras.Click += new System.EventHandler(this.Btncompra_Click);
            // 
            // BtnReg_pas
            // 
            this.BtnReg_pas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReg_pas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReg_pas.FlatAppearance.BorderSize = 0;
            this.BtnReg_pas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReg_pas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReg_pas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg_pas.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg_pas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnReg_pas.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnReg_pas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnReg_pas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReg_pas.IconSize = 30;
            this.BtnReg_pas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReg_pas.Location = new System.Drawing.Point(0, 178);
            this.BtnReg_pas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReg_pas.Name = "BtnReg_pas";
            this.BtnReg_pas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReg_pas.Size = new System.Drawing.Size(302, 50);
            this.BtnReg_pas.TabIndex = 19;
            this.BtnReg_pas.Tag = "Registro del Paciente";
            this.BtnReg_pas.Text = "Registro de paciente";
            this.BtnReg_pas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReg_pas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReg_pas.UseVisualStyleBackColor = false;
            this.BtnReg_pas.Click += new System.EventHandler(this.BtnReg_pas_Click);
            // 
            // BtnFac_m
            // 
            this.BtnFac_m.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFac_m.FlatAppearance.BorderSize = 0;
            this.BtnFac_m.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFac_m.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFac_m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFac_m.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFac_m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnFac_m.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.BtnFac_m.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnFac_m.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFac_m.IconSize = 30;
            this.BtnFac_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFac_m.Location = new System.Drawing.Point(0, 127);
            this.BtnFac_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFac_m.Name = "BtnFac_m";
            this.BtnFac_m.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnFac_m.Size = new System.Drawing.Size(302, 50);
            this.BtnFac_m.TabIndex = 18;
            this.BtnFac_m.Tag = "Facturacion";
            this.BtnFac_m.Text = "Facturacion";
            this.BtnFac_m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFac_m.UseVisualStyleBackColor = true;
            this.BtnFac_m.Click += new System.EventHandler(this.BtnFac_m_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BtnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnHome.IconSize = 30;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 76);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(302, 50);
            this.BtnHome.TabIndex = 17;
            this.BtnHome.Tag = "Home";
            this.BtnHome.Text = "Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlLogo
            // 
            this.PnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogo.Controls.Add(this.PcLaboratorio);
            this.PnlLogo.Controls.Add(this.LblLaboratorio);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(302, 76);
            this.PnlLogo.TabIndex = 6;
            // 
            // PcLaboratorio
            // 
            this.PcLaboratorio.Image = global::Proyecto_de_Graduacion.Properties.Resources.Laboratorio;
            this.PcLaboratorio.Location = new System.Drawing.Point(10, 13);
            this.PcLaboratorio.Name = "PcLaboratorio";
            this.PcLaboratorio.Size = new System.Drawing.Size(65, 57);
            this.PcLaboratorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcLaboratorio.TabIndex = 8;
            this.PcLaboratorio.TabStop = false;
            // 
            // LblLaboratorio
            // 
            this.LblLaboratorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLaboratorio.AutoSize = true;
            this.LblLaboratorio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(75)))), ((int)(((byte)(194)))));
            this.LblLaboratorio.Location = new System.Drawing.Point(92, 24);
            this.LblLaboratorio.Name = "LblLaboratorio";
            this.LblLaboratorio.Size = new System.Drawing.Size(204, 24);
            this.LblLaboratorio.TabIndex = 7;
            this.LblLaboratorio.Text = "Laboratorio El Socorro";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(304, 102);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(961, 713);
            this.panelDesktop.TabIndex = 3;
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // FrmMDI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1265, 815);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PnlDesplegable);
            this.Controls.Add(this.PnlSistema);
            this.Controls.Add(this.PnlCerrarMaximizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMDI";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.Resize += new System.EventHandler(this.FrmMDI_Resize);
            this.PnlCerrarMaximizar.ResumeLayout(false);
            this.PnlCerrarMaximizar.PerformLayout();
            this.PnlSistema.ResumeLayout(false);
            this.PnlSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNMenu)).EndInit();
            this.PnlDesplegable.ResumeLayout(false);
            this.PnlDesplegable.PerformLayout();
            this.PnlLogo.ResumeLayout(false);
            this.PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcLaboratorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCerrarMaximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlSistema;
        private FontAwesome.Sharp.IconButton Btnmin;
        private System.Windows.Forms.Label LblMenu;
        private FontAwesome.Sharp.IconPictureBox ICNMenu;
        private System.Windows.Forms.Panel PnlDesplegable;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label LblSistemaLab;
        private System.Windows.Forms.Label LblLaboratorio;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PcLaboratorio;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.Button BtnCerrarFormulario;
        private FontAwesome.Sharp.IconButton BtnGesti_Exa;
        private FontAwesome.Sharp.IconButton BtnRes_Ex;
        private FontAwesome.Sharp.IconButton BtnReg_pas;
        private FontAwesome.Sharp.IconButton BtnFac_m;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton BtnConf;
        private FontAwesome.Sharp.IconButton BtnCitas;
        private FontAwesome.Sharp.IconButton BtnAd_Usuario;
        private FontAwesome.Sharp.IconButton BtnCompras;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IcnCerrarSesion;
    }
}