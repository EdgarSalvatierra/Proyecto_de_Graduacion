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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarFactura = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlopcioens = new System.Windows.Forms.Panel();
            this.Btndardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.ICNUser = new FontAwesome.Sharp.IconPictureBox();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).BeginInit();
            this.pnlopcioens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.ICNUser);
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.BtnNuevoUsuario);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(924, 78);
            this.PnlBudc.TabIndex = 2;
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
            this.TxtBuscarFactura.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarFactura.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarFactura.Name = "TxtBuscarFactura";
            this.TxtBuscarFactura.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarFactura.TabIndex = 0;
            this.TxtBuscarFactura.Text = "Buscar Usuario";
            this.TxtBuscarFactura.Enter += new System.EventHandler(this.TxtBuscarFactura_Enter);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgUsuarios);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(924, 491);
            this.PnlGrid.TabIndex = 78;
            // 
            // DtgUsuarios
            // 
            this.DtgUsuarios.AllowUserToAddRows = false;
            this.DtgUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DtgUsuarios.ColumnHeadersHeight = 40;
            this.DtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.DtgUsuarios.EnableHeadersVisualStyles = false;
            this.DtgUsuarios.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgUsuarios.Location = new System.Drawing.Point(12, 27);
            this.DtgUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgUsuarios.Name = "DtgUsuarios";
            this.DtgUsuarios.ReadOnly = true;
            this.DtgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DtgUsuarios.RowHeadersWidth = 65;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DtgUsuarios.RowTemplate.Height = 24;
            this.DtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgUsuarios.Size = new System.Drawing.Size(900, 460);
            this.DtgUsuarios.TabIndex = 1;
            // 
            // pnlopcioens
            // 
            this.pnlopcioens.Controls.Add(this.Btndardebaja);
            this.pnlopcioens.Controls.Add(this.BtnEditar);
            this.pnlopcioens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlopcioens.Location = new System.Drawing.Point(0, 577);
            this.pnlopcioens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlopcioens.Name = "pnlopcioens";
            this.pnlopcioens.Size = new System.Drawing.Size(924, 88);
            this.pnlopcioens.TabIndex = 79;
            // 
            // Btndardebaja
            // 
            this.Btndardebaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btndardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btndardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btndardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndardebaja.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.Btndardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btndardebaja.IconSize = 20;
            this.Btndardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndardebaja.Location = new System.Drawing.Point(661, 29);
            this.Btndardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndardebaja.Name = "Btndardebaja";
            this.Btndardebaja.Size = new System.Drawing.Size(246, 41);
            this.Btndardebaja.TabIndex = 54;
            this.Btndardebaja.Text = "Dar de Baja";
            this.Btndardebaja.UseVisualStyleBackColor = false;
            this.Btndardebaja.Click += new System.EventHandler(this.Btndardebaja_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(27, 29);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(254, 41);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar Usuario";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ICNUser
            // 
            this.ICNUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ICNUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ICNUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ICNUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ICNUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ICNUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICNUser.IconSize = 52;
            this.ICNUser.Location = new System.Drawing.Point(853, 10);
            this.ICNUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ICNUser.Name = "ICNUser";
            this.ICNUser.Size = new System.Drawing.Size(54, 52);
            this.ICNUser.TabIndex = 52;
            this.ICNUser.TabStop = false;
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
            this.BtnNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.BtnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoUsuario.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoUsuario.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoUsuario.IconSize = 20;
            this.BtnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(490, 25);
            this.BtnNuevoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(209, 37);
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.pnlopcioens);
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
            this.pnlopcioens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICNUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarFactura;
        private FontAwesome.Sharp.IconPictureBox ICNUser;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgUsuarios;
        private System.Windows.Forms.Panel pnlopcioens;
        private FontAwesome.Sharp.IconButton Btndardebaja;
        private FontAwesome.Sharp.IconButton BtnNuevoUsuario;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}