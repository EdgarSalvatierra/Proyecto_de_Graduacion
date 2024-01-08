namespace Proyecto_de_Graduacion
{
    partial class FrmNuevaConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaConfiguracion));
            this.Pnlopciones = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.PnlFecha = new System.Windows.Forms.Panel();
            this.GbConfiguracion = new System.Windows.Forms.GroupBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtAdministrador = new System.Windows.Forms.TextBox();
            this.TxtEntidad = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.Lbladministrador = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.LblNombreEntidad = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Lblfechita = new System.Windows.Forms.Label();
            this.Pnlopciones.SuspendLayout();
            this.PnlFecha.SuspendLayout();
            this.GbConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlopciones
            // 
            this.Pnlopciones.Controls.Add(this.BtnLimpiar);
            this.Pnlopciones.Controls.Add(this.BtnActualizar);
            this.Pnlopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlopciones.Location = new System.Drawing.Point(0, 309);
            this.Pnlopciones.Name = "Pnlopciones";
            this.Pnlopciones.Size = new System.Drawing.Size(653, 66);
            this.Pnlopciones.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(355, 15);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(275, 39);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(16, 15);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(275, 39);
            this.BtnActualizar.TabIndex = 0;
            this.BtnActualizar.Text = "Actualizar Informacion";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // PnlFecha
            // 
            this.PnlFecha.Controls.Add(this.Lblfechita);
            this.PnlFecha.Controls.Add(this.LblFecha);
            this.PnlFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFecha.Location = new System.Drawing.Point(0, 0);
            this.PnlFecha.Name = "PnlFecha";
            this.PnlFecha.Size = new System.Drawing.Size(653, 53);
            this.PnlFecha.TabIndex = 17;
            // 
            // GbConfiguracion
            // 
            this.GbConfiguracion.Controls.Add(this.TxtCiudad);
            this.GbConfiguracion.Controls.Add(this.TxtUbicacion);
            this.GbConfiguracion.Controls.Add(this.TxtTelefono);
            this.GbConfiguracion.Controls.Add(this.TxtAdministrador);
            this.GbConfiguracion.Controls.Add(this.TxtEntidad);
            this.GbConfiguracion.Controls.Add(this.LblTelefono);
            this.GbConfiguracion.Controls.Add(this.Lbladministrador);
            this.GbConfiguracion.Controls.Add(this.LblCiudad);
            this.GbConfiguracion.Controls.Add(this.LblUbicacion);
            this.GbConfiguracion.Controls.Add(this.LblNombreEntidad);
            this.GbConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbConfiguracion.Location = new System.Drawing.Point(0, 53);
            this.GbConfiguracion.Name = "GbConfiguracion";
            this.GbConfiguracion.Size = new System.Drawing.Size(653, 250);
            this.GbConfiguracion.TabIndex = 18;
            this.GbConfiguracion.TabStop = false;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(311, 203);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(319, 27);
            this.TxtCiudad.TabIndex = 15;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUbicacion.Location = new System.Drawing.Point(311, 156);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(319, 27);
            this.TxtUbicacion.TabIndex = 14;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(310, 114);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(320, 27);
            this.TxtTelefono.TabIndex = 13;
            // 
            // TxtAdministrador
            // 
            this.TxtAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdministrador.Location = new System.Drawing.Point(310, 69);
            this.TxtAdministrador.Name = "TxtAdministrador";
            this.TxtAdministrador.Size = new System.Drawing.Size(320, 28);
            this.TxtAdministrador.TabIndex = 12;
            // 
            // TxtEntidad
            // 
            this.TxtEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEntidad.Location = new System.Drawing.Point(311, 21);
            this.TxtEntidad.Name = "TxtEntidad";
            this.TxtEntidad.Size = new System.Drawing.Size(319, 28);
            this.TxtEntidad.TabIndex = 11;
            // 
            // LblTelefono
            // 
            this.LblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(12, 114);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(89, 21);
            this.LblTelefono.TabIndex = 10;
            this.LblTelefono.Text = "Telefono: ";
            // 
            // Lbladministrador
            // 
            this.Lbladministrador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbladministrador.AutoSize = true;
            this.Lbladministrador.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbladministrador.Location = new System.Drawing.Point(12, 67);
            this.Lbladministrador.Name = "Lbladministrador";
            this.Lbladministrador.Size = new System.Drawing.Size(124, 21);
            this.Lbladministrador.TabIndex = 9;
            this.Lbladministrador.Text = "Administrador:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(12, 207);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(72, 21);
            this.LblCiudad.TabIndex = 8;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacion.Location = new System.Drawing.Point(12, 158);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(99, 21);
            this.LblUbicacion.TabIndex = 7;
            this.LblUbicacion.Text = "Ubicacion: ";
            // 
            // LblNombreEntidad
            // 
            this.LblNombreEntidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNombreEntidad.AutoSize = true;
            this.LblNombreEntidad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEntidad.Location = new System.Drawing.Point(12, 21);
            this.LblNombreEntidad.Name = "LblNombreEntidad";
            this.LblNombreEntidad.Size = new System.Drawing.Size(193, 21);
            this.LblNombreEntidad.TabIndex = 6;
            this.LblNombreEntidad.Text = "Nombre de la Entidad: ";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(41, 19);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(70, 21);
            this.LblFecha.TabIndex = 16;
            this.LblFecha.Text = "Fecha: ";
            // 
            // Lblfechita
            // 
            this.Lblfechita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lblfechita.AutoSize = true;
            this.Lblfechita.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfechita.Location = new System.Drawing.Point(117, 19);
            this.Lblfechita.Name = "Lblfechita";
            this.Lblfechita.Size = new System.Drawing.Size(40, 21);
            this.Lblfechita.TabIndex = 17;
            this.Lblfechita.Text = "......";
            // 
            // FrmNuevaConfiguracion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(653, 375);
            this.Controls.Add(this.GbConfiguracion);
            this.Controls.Add(this.PnlFecha);
            this.Controls.Add(this.Pnlopciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Informacion de la Entidad";
            this.Load += new System.EventHandler(this.FrmNuevaConfiguracion_Load);
            this.Pnlopciones.ResumeLayout(false);
            this.PnlFecha.ResumeLayout(false);
            this.PnlFecha.PerformLayout();
            this.GbConfiguracion.ResumeLayout(false);
            this.GbConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnlopciones;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Panel PnlFecha;
        private System.Windows.Forms.GroupBox GbConfiguracion;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtAdministrador;
        private System.Windows.Forms.TextBox TxtEntidad;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label Lbladministrador;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.Label LblNombreEntidad;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label Lblfechita;
    }
}