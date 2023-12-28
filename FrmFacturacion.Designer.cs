namespace Proyecto_de_Graduacion
{
    partial class FrmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.ICNServicio = new FontAwesome.Sharp.IconButton();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.Pnlopciones = new System.Windows.Forms.Panel();
            this.BtnImprimir = new FontAwesome.Sharp.IconButton();
            this.BtnDardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.Pnlopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.ICNServicio);
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(924, 78);
            this.PnlBudc.TabIndex = 1;
            // 
            // ICNServicio
            // 
            this.ICNServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICNServicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ICNServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICNServicio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICNServicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ICNServicio.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ICNServicio.IconColor = System.Drawing.SystemColors.Highlight;
            this.ICNServicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ICNServicio.IconSize = 20;
            this.ICNServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICNServicio.Location = new System.Drawing.Point(732, 24);
            this.ICNServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ICNServicio.Name = "ICNServicio";
            this.ICNServicio.Size = new System.Drawing.Size(180, 37);
            this.ICNServicio.TabIndex = 78;
            this.ICNServicio.Text = "Nuevo Servicio";
            this.ICNServicio.UseVisualStyleBackColor = false;
            this.ICNServicio.Click += new System.EventHandler(this.ICNServicio_Click);
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
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarFactura);
            this.PnlBuscare.Location = new System.Drawing.Point(11, 25);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(371, 35);
            this.PnlBuscare.TabIndex = 0;
            // 
            // TxtBuscarFactura
            // 
            this.TxtBuscarFactura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarFactura.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarFactura.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarFactura.Name = "TxtBuscarFactura";
            this.TxtBuscarFactura.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarFactura.TabIndex = 0;
            this.TxtBuscarFactura.Text = "Buscar Factura";
            // 
            // PnlGrid
            // 
            this.PnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGrid.Controls.Add(this.DtgFactura);
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(924, 522);
            this.PnlGrid.TabIndex = 77;
            // 
            // DtgFactura
            // 
            this.DtgFactura.AllowUserToAddRows = false;
            this.DtgFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DtgFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgFactura.ColumnHeadersHeight = 40;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgFactura.DefaultCellStyle = dataGridViewCellStyle7;
            this.DtgFactura.EnableHeadersVisualStyles = false;
            this.DtgFactura.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgFactura.Location = new System.Drawing.Point(12, 27);
            this.DtgFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.ReadOnly = true;
            this.DtgFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgFactura.RowHeadersWidth = 65;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgFactura.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DtgFactura.RowTemplate.Height = 24;
            this.DtgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgFactura.Size = new System.Drawing.Size(900, 475);
            this.DtgFactura.TabIndex = 1;
            this.DtgFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgFactura_CellContentClick);
            // 
            // Pnlopciones
            // 
            this.Pnlopciones.Controls.Add(this.BtnImprimir);
            this.Pnlopciones.Controls.Add(this.BtnDardebaja);
            this.Pnlopciones.Controls.Add(this.BtnEditar);
            this.Pnlopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlopciones.Location = new System.Drawing.Point(0, 598);
            this.Pnlopciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pnlopciones.Name = "Pnlopciones";
            this.Pnlopciones.Size = new System.Drawing.Size(924, 67);
            this.Pnlopciones.TabIndex = 78;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.BtnImprimir.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnImprimir.IconSize = 20;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(689, 13);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(210, 37);
            this.BtnImprimir.TabIndex = 53;
            this.BtnImprimir.Text = "Impresion";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnDardebaja
            // 
            this.BtnDardebaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnDardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDardebaja.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconChar = FontAwesome.Sharp.IconChar.TurnDown;
            this.BtnDardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDardebaja.IconSize = 20;
            this.BtnDardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDardebaja.Location = new System.Drawing.Point(374, 13);
            this.BtnDardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDardebaja.Name = "BtnDardebaja";
            this.BtnDardebaja.Size = new System.Drawing.Size(210, 35);
            this.BtnDardebaja.TabIndex = 52;
            this.BtnDardebaja.Text = "Dar de Baja";
            this.BtnDardebaja.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(28, 13);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(236, 37);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar Factura";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.Pnlopciones);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBudc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.PnlBudc.ResumeLayout(false);
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.Pnlopciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconButton ICNServicio;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Panel Pnlopciones;
        private FontAwesome.Sharp.IconButton BtnImprimir;
        private FontAwesome.Sharp.IconButton BtnDardebaja;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}