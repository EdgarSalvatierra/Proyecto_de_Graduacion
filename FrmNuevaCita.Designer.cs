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
            this.BtnClose = new System.Windows.Forms.Button();
            this.Pnlarriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlarriba
            // 
            this.Pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(210)))));
            this.Pnlarriba.Controls.Add(this.BtnClose);
            this.Pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.Pnlarriba.Name = "Pnlarriba";
            this.Pnlarriba.Size = new System.Drawing.Size(864, 36);
            this.Pnlarriba.TabIndex = 14;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClose.Location = new System.Drawing.Point(834, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 29);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // FrmNuevaCita
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 568);
            this.Controls.Add(this.Pnlarriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnlarriba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlarriba;
        private System.Windows.Forms.Button BtnClose;
    }
}