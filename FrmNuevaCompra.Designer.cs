namespace Proyecto_de_Graduacion
{
    partial class FrmNuevaCompra
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
            this.PnlFacturacion = new System.Windows.Forms.Panel();
            this.BtnX = new FontAwesome.Sharp.IconButton();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.PnlFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFacturacion
            // 
            this.PnlFacturacion.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlFacturacion.Controls.Add(this.BtnX);
            this.PnlFacturacion.Controls.Add(this.LbTitulo);
            this.PnlFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFacturacion.Location = new System.Drawing.Point(0, 0);
            this.PnlFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlFacturacion.Name = "PnlFacturacion";
            this.PnlFacturacion.Size = new System.Drawing.Size(959, 60);
            this.PnlFacturacion.TabIndex = 2;
            // 
            // BtnX
            // 
            this.BtnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnX.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnX.FlatAppearance.BorderSize = 0;
            this.BtnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnX.IconColor = System.Drawing.Color.White;
            this.BtnX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnX.IconSize = 20;
            this.BtnX.Location = new System.Drawing.Point(908, 1);
            this.BtnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(51, 56);
            this.BtnX.TabIndex = 29;
            this.BtnX.UseVisualStyleBackColor = false;
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbTitulo.Location = new System.Drawing.Point(298, 15);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(235, 24);
            this.LbTitulo.TabIndex = 28;
            this.LbTitulo.Text = "Formulario de Compra";
            // 
            // FrmNuevaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 705);
            this.Controls.Add(this.PnlFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevaCompra";
            this.PnlFacturacion.ResumeLayout(false);
            this.PnlFacturacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFacturacion;
        private FontAwesome.Sharp.IconButton BtnX;
        private System.Windows.Forms.Label LbTitulo;
    }
}