namespace Proyecto_de_Graduacion
{
    partial class FrmRegistrodePacientes
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
            this.PbLogomodu = new FontAwesome.Sharp.IconPictureBox();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoPaciente = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            this.pnlopcioens = new System.Windows.Forms.Panel();
            this.Btndardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogomodu)).BeginInit();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.pnlopcioens.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.PbLogomodu);
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.BtnNuevoPaciente);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(924, 78);
            this.PnlBudc.TabIndex = 3;
            // 
            // PbLogomodu
            // 
            this.PbLogomodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLogomodu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PbLogomodu.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.PbLogomodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.PbLogomodu.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.PbLogomodu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.PbLogomodu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PbLogomodu.IconSize = 49;
            this.PbLogomodu.Location = new System.Drawing.Point(863, 12);
            this.PbLogomodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbLogomodu.Name = "PbLogomodu";
            this.PbLogomodu.Size = new System.Drawing.Size(49, 50);
            this.PbLogomodu.TabIndex = 26;
            this.PbLogomodu.TabStop = false;
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
            // BtnNuevoPaciente
            // 
            this.BtnNuevoPaciente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnNuevoPaciente.BackColor = System.Drawing.Color.White;
            this.BtnNuevoPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoPaciente.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoPaciente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoPaciente.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoPaciente.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoPaciente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoPaciente.IconSize = 20;
            this.BtnNuevoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoPaciente.Location = new System.Drawing.Point(490, 25);
            this.BtnNuevoPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoPaciente.Name = "BtnNuevoPaciente";
            this.BtnNuevoPaciente.Size = new System.Drawing.Size(209, 37);
            this.BtnNuevoPaciente.TabIndex = 50;
            this.BtnNuevoPaciente.Text = "Nuevo Paciente";
            this.BtnNuevoPaciente.UseVisualStyleBackColor = false;
            this.BtnNuevoPaciente.Click += new System.EventHandler(this.BtnNuevoPaciente_Click);
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
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarPaciente);
            this.PnlBuscare.Location = new System.Drawing.Point(11, 25);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(371, 35);
            this.PnlBuscare.TabIndex = 0;
            // 
            // TxtBuscarPaciente
            // 
            this.TxtBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarPaciente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarPaciente.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarPaciente.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarPaciente.Name = "TxtBuscarPaciente";
            this.TxtBuscarPaciente.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarPaciente.TabIndex = 0;
            this.TxtBuscarPaciente.Text = "Buscar Paciente";
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DtgPaciente);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(924, 503);
            this.PnlGrid.TabIndex = 79;
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.AllowUserToAddRows = false;
            this.DtgPaciente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgPaciente.ColumnHeadersHeight = 40;
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgPaciente.DefaultCellStyle = dataGridViewCellStyle7;
            this.DtgPaciente.EnableHeadersVisualStyles = false;
            this.DtgPaciente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.Location = new System.Drawing.Point(12, 27);
            this.DtgPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.ReadOnly = true;
            this.DtgPaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgPaciente.RowHeadersWidth = 65;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DtgPaciente.RowTemplate.Height = 24;
            this.DtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPaciente.Size = new System.Drawing.Size(900, 457);
            this.DtgPaciente.TabIndex = 1;
            // 
            // pnlopcioens
            // 
            this.pnlopcioens.Controls.Add(this.Btndardebaja);
            this.pnlopcioens.Controls.Add(this.BtnEditar);
            this.pnlopcioens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlopcioens.Location = new System.Drawing.Point(0, 589);
            this.pnlopcioens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlopcioens.Name = "pnlopcioens";
            this.pnlopcioens.Size = new System.Drawing.Size(924, 76);
            this.pnlopcioens.TabIndex = 80;
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
            this.Btndardebaja.Location = new System.Drawing.Point(694, 24);
            this.Btndardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndardebaja.Name = "Btndardebaja";
            this.Btndardebaja.Size = new System.Drawing.Size(191, 39);
            this.Btndardebaja.TabIndex = 54;
            this.Btndardebaja.Text = "Dar de Baja";
            this.Btndardebaja.UseVisualStyleBackColor = false;
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
            this.BtnEditar.Location = new System.Drawing.Point(27, 24);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(215, 39);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar Paciente";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrodePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.pnlopcioens);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBudc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrodePacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistrodePacientes_Load);
            this.PnlBudc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogomodu)).EndInit();
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).EndInit();
            this.pnlopcioens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconPictureBox PbLogomodu;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton BtnNuevoPaciente;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarPaciente;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgPaciente;
        private System.Windows.Forms.Panel pnlopcioens;
        private FontAwesome.Sharp.IconButton Btndardebaja;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}