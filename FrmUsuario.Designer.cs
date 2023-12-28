namespace Proyecto_de_Graduacion
{
    partial class FrmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgUsuarios = new System.Windows.Forms.DataGridView();
            this.Btndardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(1132, 78);
            this.PnlBudc.TabIndex = 2;
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
            // BtnNuevoUsuario
            // 
            this.BtnNuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.BtnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoUsuario.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoUsuario.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoUsuario.IconSize = 20;
            this.BtnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(484, 471);
            this.BtnNuevoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(210, 37);
            this.BtnNuevoUsuario.TabIndex = 50;
            this.BtnNuevoUsuario.Text = "Nuevo Usuario";
            this.BtnNuevoUsuario.UseVisualStyleBackColor = false;
            this.BtnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
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
            this.TxtBuscarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarFactura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtBuscarFactura.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarFactura.Name = "TxtBuscarFactura";
            this.TxtBuscarFactura.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarFactura.TabIndex = 0;
            this.TxtBuscarFactura.Text = "Buscar Usuario";
            this.TxtBuscarFactura.Enter += new System.EventHandler(this.TxtBuscarFactura_Enter);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGrid.Controls.Add(this.Btndardebaja);
            this.PnlGrid.Controls.Add(this.BtnNuevoUsuario);
            this.PnlGrid.Controls.Add(this.DtgUsuarios);
            this.PnlGrid.Controls.Add(this.BtnEditar);
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(1120, 521);
            this.PnlGrid.TabIndex = 78;
            // 
            // DtgUsuarios
            // 
            this.DtgUsuarios.AllowUserToAddRows = false;
            this.DtgUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.DtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DtgUsuarios.ColumnHeadersHeight = 40;
            this.DtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgUsuarios.DefaultCellStyle = dataGridViewCellStyle18;
            this.DtgUsuarios.EnableHeadersVisualStyles = false;
            this.DtgUsuarios.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgUsuarios.Location = new System.Drawing.Point(12, 27);
            this.DtgUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgUsuarios.Name = "DtgUsuarios";
            this.DtgUsuarios.ReadOnly = true;
            this.DtgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DtgUsuarios.RowHeadersWidth = 65;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DtgUsuarios.RowTemplate.Height = 24;
            this.DtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgUsuarios.Size = new System.Drawing.Size(1096, 421);
            this.DtgUsuarios.TabIndex = 1;
            // 
            // Btndardebaja
            // 
            this.Btndardebaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btndardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btndardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btndardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndardebaja.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.Btndardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btndardebaja.IconSize = 20;
            this.Btndardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndardebaja.Location = new System.Drawing.Point(920, 471);
            this.Btndardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndardebaja.Name = "Btndardebaja";
            this.Btndardebaja.Size = new System.Drawing.Size(191, 36);
            this.Btndardebaja.TabIndex = 54;
            this.Btndardebaja.Text = "Dar de Baja";
            this.Btndardebaja.UseVisualStyleBackColor = false;
            this.Btndardebaja.Click += new System.EventHandler(this.Btndardebaja_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(712, 472);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(192, 36);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar Usuario";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 665);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBudc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.PnlBudc.ResumeLayout(false);
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgUsuarios;
        private FontAwesome.Sharp.IconButton Btndardebaja;
        private FontAwesome.Sharp.IconButton BtnNuevoUsuario;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}