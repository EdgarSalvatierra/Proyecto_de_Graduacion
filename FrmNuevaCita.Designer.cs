namespace Proyecto_de_Graduacion
{
    partial class FrmNuevaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaCita));
            this.Pnlarriba = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.LblSistemaLab = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Pnlencabezado = new System.Windows.Forms.Panel();
            this.TxtCodigo = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblRegistroCompras = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Pnlok = new System.Windows.Forms.Panel();
            this.LblFech = new System.Windows.Forms.Label();
            this.DtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.LblHoracita = new System.Windows.Forms.Label();
            this.DtpHoraCita = new System.Windows.Forms.DateTimePicker();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.LblMotivo = new System.Windows.Forms.Label();
            this.Pnlestado = new System.Windows.Forms.Panel();
            this.Pcimagen = new System.Windows.Forms.PictureBox();
            this.PnlNacimiento = new System.Windows.Forms.Panel();
            this.pnop = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Btnnueva = new System.Windows.Forms.Button();
            this.Pnlarriba.SuspendLayout();
            this.Pnlencabezado.SuspendLayout();
            this.Pnlok.SuspendLayout();
            this.Pnlestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcimagen)).BeginInit();
            this.PnlNacimiento.SuspendLayout();
            this.pnop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlarriba
            // 
            this.Pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.Pnlarriba.Controls.Add(this.BtnMinimizar);
            this.Pnlarriba.Controls.Add(this.LblSistemaLab);
            this.Pnlarriba.Controls.Add(this.BtnClose);
            this.Pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.Pnlarriba.Name = "Pnlarriba";
            this.Pnlarriba.Size = new System.Drawing.Size(938, 36);
            this.Pnlarriba.TabIndex = 14;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnMinimizar.Location = new System.Drawing.Point(870, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(32, 29);
            this.BtnMinimizar.TabIndex = 18;
            this.BtnMinimizar.Text = "-";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // LblSistemaLab
            // 
            this.LblSistemaLab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSistemaLab.AutoSize = true;
            this.LblSistemaLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.LblSistemaLab.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemaLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSistemaLab.Location = new System.Drawing.Point(327, 9);
            this.LblSistemaLab.Name = "LblSistemaLab";
            this.LblSistemaLab.Size = new System.Drawing.Size(211, 19);
            this.LblSistemaLab.TabIndex = 16;
            this.LblSistemaLab.Text = "Sistema Socorro Lab";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClose.Location = new System.Drawing.Point(908, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 29);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Pnlencabezado
            // 
            this.Pnlencabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(179)))));
            this.Pnlencabezado.Controls.Add(this.TxtCodigo);
            this.Pnlencabezado.Controls.Add(this.LblProveedor);
            this.Pnlencabezado.Controls.Add(this.LblRegistroCompras);
            this.Pnlencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlencabezado.Location = new System.Drawing.Point(0, 36);
            this.Pnlencabezado.Name = "Pnlencabezado";
            this.Pnlencabezado.Size = new System.Drawing.Size(938, 55);
            this.Pnlencabezado.TabIndex = 16;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCodigo.AutoSize = true;
            this.TxtCodigo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCodigo.Location = new System.Drawing.Point(646, 18);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(29, 19);
            this.TxtCodigo.TabIndex = 2;
            this.TxtCodigo.Text = "....";
            // 
            // LblProveedor
            // 
            this.LblProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblProveedor.Location = new System.Drawing.Point(573, 20);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(67, 21);
            this.LblProveedor.TabIndex = 1;
            this.LblProveedor.Text = "Codigo";
            // 
            // LblRegistroCompras
            // 
            this.LblRegistroCompras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblRegistroCompras.AutoSize = true;
            this.LblRegistroCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRegistroCompras.Location = new System.Drawing.Point(20, 18);
            this.LblRegistroCompras.Name = "LblRegistroCompras";
            this.LblRegistroCompras.Size = new System.Drawing.Size(197, 23);
            this.LblRegistroCompras.TabIndex = 0;
            this.LblRegistroCompras.Text = "Reservacion de Citas";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNombre.Location = new System.Drawing.Point(20, 19);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(73, 21);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(125, 19);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(232, 28);
            this.TxtNombre.TabIndex = 0;
            // 
            // Pnlok
            // 
            this.Pnlok.Controls.Add(this.LblFech);
            this.Pnlok.Controls.Add(this.DtpFechaCita);
            this.Pnlok.Controls.Add(this.LblHoracita);
            this.Pnlok.Controls.Add(this.DtpHoraCita);
            this.Pnlok.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlok.Location = new System.Drawing.Point(0, 91);
            this.Pnlok.Name = "Pnlok";
            this.Pnlok.Size = new System.Drawing.Size(938, 63);
            this.Pnlok.TabIndex = 22;
            // 
            // LblFech
            // 
            this.LblFech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFech.AutoSize = true;
            this.LblFech.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFech.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFech.Location = new System.Drawing.Point(20, 21);
            this.LblFech.Name = "LblFech";
            this.LblFech.Size = new System.Drawing.Size(122, 21);
            this.LblFech.TabIndex = 10;
            this.LblFech.Text = "Fecha de Cita";
            // 
            // DtpFechaCita
            // 
            this.DtpFechaCita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpFechaCita.CalendarFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCita.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCita.Location = new System.Drawing.Point(148, 17);
            this.DtpFechaCita.MinDate = new System.DateTime(2024, 1, 14, 0, 0, 0, 0);
            this.DtpFechaCita.Name = "DtpFechaCita";
            this.DtpFechaCita.Size = new System.Drawing.Size(232, 27);
            this.DtpFechaCita.TabIndex = 11;
            // 
            // LblHoracita
            // 
            this.LblHoracita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblHoracita.AutoSize = true;
            this.LblHoracita.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoracita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblHoracita.Location = new System.Drawing.Point(564, 23);
            this.LblHoracita.Name = "LblHoracita";
            this.LblHoracita.Size = new System.Drawing.Size(111, 21);
            this.LblHoracita.TabIndex = 24;
            this.LblHoracita.Text = "Hora de Cita";
            // 
            // DtpHoraCita
            // 
            this.DtpHoraCita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpHoraCita.CalendarFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraCita.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraCita.Location = new System.Drawing.Point(693, 19);
            this.DtpHoraCita.Name = "DtpHoraCita";
            this.DtpHoraCita.Size = new System.Drawing.Size(232, 27);
            this.DtpHoraCita.TabIndex = 25;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtTelefono.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(125, 37);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(232, 28);
            this.TxtTelefono.TabIndex = 7;
            // 
            // LblTelefono
            // 
            this.LblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTelefono.Location = new System.Drawing.Point(20, 37);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(79, 21);
            this.LblTelefono.TabIndex = 6;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(125, 73);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(232, 28);
            this.TxtApellido.TabIndex = 5;
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblApellido.Location = new System.Drawing.Point(20, 73);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(73, 21);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "Apellido";
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtpNacimiento.CalendarFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNacimiento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNacimiento.Location = new System.Drawing.Point(125, 133);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(232, 27);
            this.DtpNacimiento.TabIndex = 9;
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtMotivo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotivo.Location = new System.Drawing.Point(691, 14);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(232, 75);
            this.TxtMotivo.TabIndex = 8;
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNacimiento.Location = new System.Drawing.Point(20, 133);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(99, 21);
            this.LblNacimiento.TabIndex = 8;
            this.LblNacimiento.Text = "Nacimiento";
            // 
            // LblMotivo
            // 
            this.LblMotivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblMotivo.AutoSize = true;
            this.LblMotivo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMotivo.Location = new System.Drawing.Point(600, 40);
            this.LblMotivo.Name = "LblMotivo";
            this.LblMotivo.Size = new System.Drawing.Size(63, 21);
            this.LblMotivo.TabIndex = 10;
            this.LblMotivo.Text = "Motivo";
            // 
            // Pnlestado
            // 
            this.Pnlestado.Controls.Add(this.LblNacimiento);
            this.Pnlestado.Controls.Add(this.DtpNacimiento);
            this.Pnlestado.Controls.Add(this.Pcimagen);
            this.Pnlestado.Controls.Add(this.LblNombre);
            this.Pnlestado.Controls.Add(this.TxtNombre);
            this.Pnlestado.Controls.Add(this.LblApellido);
            this.Pnlestado.Controls.Add(this.TxtApellido);
            this.Pnlestado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlestado.Location = new System.Drawing.Point(0, 154);
            this.Pnlestado.Name = "Pnlestado";
            this.Pnlestado.Size = new System.Drawing.Size(938, 183);
            this.Pnlestado.TabIndex = 23;
            // 
            // Pcimagen
            // 
            this.Pcimagen.Image = global::Proyecto_de_Graduacion.Properties.Resources.imagescita_removebg_preview;
            this.Pcimagen.Location = new System.Drawing.Point(690, 19);
            this.Pcimagen.Name = "Pcimagen";
            this.Pcimagen.Size = new System.Drawing.Size(232, 149);
            this.Pcimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcimagen.TabIndex = 11;
            this.Pcimagen.TabStop = false;
            // 
            // PnlNacimiento
            // 
            this.PnlNacimiento.Controls.Add(this.TxtMotivo);
            this.PnlNacimiento.Controls.Add(this.LblMotivo);
            this.PnlNacimiento.Controls.Add(this.LblTelefono);
            this.PnlNacimiento.Controls.Add(this.TxtTelefono);
            this.PnlNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNacimiento.Location = new System.Drawing.Point(0, 337);
            this.PnlNacimiento.Name = "PnlNacimiento";
            this.PnlNacimiento.Size = new System.Drawing.Size(938, 100);
            this.PnlNacimiento.TabIndex = 24;
            // 
            // pnop
            // 
            this.pnop.Controls.Add(this.BtnCancelar);
            this.pnop.Controls.Add(this.BtnGuardar);
            this.pnop.Controls.Add(this.Btnnueva);
            this.pnop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnop.Location = new System.Drawing.Point(0, 464);
            this.pnop.Name = "pnop";
            this.pnop.Size = new System.Drawing.Size(938, 84);
            this.pnop.TabIndex = 25;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCancelar.Location = new System.Drawing.Point(705, 19);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(197, 42);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(371, 19);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(197, 42);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Btnnueva
            // 
            this.Btnnueva.BackColor = System.Drawing.Color.SteelBlue;
            this.Btnnueva.FlatAppearance.BorderSize = 0;
            this.Btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnnueva.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnnueva.ForeColor = System.Drawing.Color.White;
            this.Btnnueva.Location = new System.Drawing.Point(34, 19);
            this.Btnnueva.Name = "Btnnueva";
            this.Btnnueva.Size = new System.Drawing.Size(197, 42);
            this.Btnnueva.TabIndex = 0;
            this.Btnnueva.Text = "Nueva";
            this.Btnnueva.UseVisualStyleBackColor = false;
            this.Btnnueva.Click += new System.EventHandler(this.Btnnueva_Click);
            // 
            // FrmNuevaCita
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 548);
            this.Controls.Add(this.pnop);
            this.Controls.Add(this.PnlNacimiento);
            this.Controls.Add(this.Pnlestado);
            this.Controls.Add(this.Pnlok);
            this.Controls.Add(this.Pnlencabezado);
            this.Controls.Add(this.Pnlarriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservacion de Citas";
            this.Load += new System.EventHandler(this.FrmNuevaCita_Load);
            this.Pnlarriba.ResumeLayout(false);
            this.Pnlarriba.PerformLayout();
            this.Pnlencabezado.ResumeLayout(false);
            this.Pnlencabezado.PerformLayout();
            this.Pnlok.ResumeLayout(false);
            this.Pnlok.PerformLayout();
            this.Pnlestado.ResumeLayout(false);
            this.Pnlestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcimagen)).EndInit();
            this.PnlNacimiento.ResumeLayout(false);
            this.PnlNacimiento.PerformLayout();
            this.pnop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlarriba;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblSistemaLab;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel Pnlencabezado;
        private System.Windows.Forms.Label TxtCodigo;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblRegistroCompras;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Panel Pnlok;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.Label LblNacimiento;
        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.Label LblMotivo;
        private System.Windows.Forms.Label LblFech;
        private System.Windows.Forms.DateTimePicker DtpFechaCita;
        private System.Windows.Forms.Label LblHoracita;
        private System.Windows.Forms.DateTimePicker DtpHoraCita;
        private System.Windows.Forms.Panel Pnlestado;
        private System.Windows.Forms.PictureBox Pcimagen;
        private System.Windows.Forms.Panel PnlNacimiento;
        private System.Windows.Forms.Panel pnop;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button Btnnueva;
    }
}