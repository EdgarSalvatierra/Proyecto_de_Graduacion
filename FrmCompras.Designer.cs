namespace Proyecto_de_Graduacion
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.ICNCompra = new FontAwesome.Sharp.IconButton();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarCompra = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgCompras = new System.Windows.Forms.DataGridView();
            this.Pnlopciones = new System.Windows.Forms.Panel();
            this.BtnDardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompras)).BeginInit();
            this.Pnlopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.ICNCompra);
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(924, 78);
            this.PnlBudc.TabIndex = 1;
            // 
            // ICNCompra
            // 
            this.ICNCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ICNCompra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ICNCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICNCompra.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICNCompra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ICNCompra.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ICNCompra.IconColor = System.Drawing.SystemColors.Highlight;
            this.ICNCompra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ICNCompra.IconSize = 20;
            this.ICNCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICNCompra.Location = new System.Drawing.Point(732, 25);
            this.ICNCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ICNCompra.Name = "ICNCompra";
            this.ICNCompra.Size = new System.Drawing.Size(180, 37);
            this.ICNCompra.TabIndex = 78;
            this.ICNCompra.Text = "Nueva Compra";
            this.ICNCompra.UseVisualStyleBackColor = false;
            this.ICNCompra.Click += new System.EventHandler(this.ICNCompra_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.BtnRefrescar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRefrescar.IconSize = 25;
            this.BtnRefrescar.Location = new System.Drawing.Point(438, 24);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(46, 38);
            this.BtnRefrescar.TabIndex = 76;
            this.BtnRefrescar.UseVisualStyleBackColor = false;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // ICNBuscador
            // 
            this.ICNBuscador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ICNBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICNBuscador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ICNBuscador.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.ICNBuscador.IconColor = System.Drawing.SystemColors.Highlight;
            this.ICNBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNBuscador.IconSize = 30;
            this.ICNBuscador.Location = new System.Drawing.Point(387, 25);
            this.ICNBuscador.Name = "ICNBuscador";
            this.ICNBuscador.Size = new System.Drawing.Size(45, 37);
            this.ICNBuscador.TabIndex = 1;
            this.ICNBuscador.UseVisualStyleBackColor = false;
            this.ICNBuscador.Click += new System.EventHandler(this.ICNBuscador_Click);
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarCompra);
            this.PnlBuscare.Location = new System.Drawing.Point(11, 25);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(371, 35);
            this.PnlBuscare.TabIndex = 0;
            // 
            // TxtBuscarCompra
            // 
            this.TxtBuscarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarCompra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarCompra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarCompra.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarCompra.Name = "TxtBuscarCompra";
            this.TxtBuscarCompra.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarCompra.TabIndex = 0;
            this.TxtBuscarCompra.Text = "Buscar Compra";
            this.TxtBuscarCompra.Enter += new System.EventHandler(this.TxtBuscarCompra_Enter);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgCompras);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(924, 500);
            this.PnlGrid.TabIndex = 77;
            // 
            // DtgCompras
            // 
            this.DtgCompras.AllowUserToAddRows = false;
            this.DtgCompras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCompras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgCompras.ColumnHeadersHeight = 40;
            this.DtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgCompras.EnableHeadersVisualStyles = false;
            this.DtgCompras.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgCompras.Location = new System.Drawing.Point(12, 27);
            this.DtgCompras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgCompras.Name = "DtgCompras";
            this.DtgCompras.ReadOnly = true;
            this.DtgCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgCompras.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgCompras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgCompras.RowTemplate.Height = 24;
            this.DtgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCompras.Size = new System.Drawing.Size(900, 469);
            this.DtgCompras.TabIndex = 1;
            // 
            // Pnlopciones
            // 
            this.Pnlopciones.Controls.Add(this.BtnDardebaja);
            this.Pnlopciones.Controls.Add(this.BtnEditar);
            this.Pnlopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlopciones.Location = new System.Drawing.Point(0, 586);
            this.Pnlopciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlopciones.Name = "Pnlopciones";
            this.Pnlopciones.Size = new System.Drawing.Size(924, 79);
            this.Pnlopciones.TabIndex = 78;
            // 
            // BtnDardebaja
            // 
            this.BtnDardebaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDardebaja.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconChar = FontAwesome.Sharp.IconChar.TurnDown;
            this.BtnDardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDardebaja.IconSize = 20;
            this.BtnDardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDardebaja.Location = new System.Drawing.Point(682, 19);
            this.BtnDardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDardebaja.Name = "BtnDardebaja";
            this.BtnDardebaja.Size = new System.Drawing.Size(210, 37);
            this.BtnDardebaja.TabIndex = 52;
            this.BtnDardebaja.Text = "Dar de Baja";
            this.BtnDardebaja.UseVisualStyleBackColor = false;
            this.BtnDardebaja.Click += new System.EventHandler(this.BtnDardebaja_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(28, 19);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(236, 37);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar Compra";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // FrmCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.Pnlopciones);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBudc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.PnlBudc.ResumeLayout(false);
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCompras)).EndInit();
            this.Pnlopciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconButton ICNCompra;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarCompra;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgCompras;
        private System.Windows.Forms.Panel Pnlopciones;
        private FontAwesome.Sharp.IconButton BtnDardebaja;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}