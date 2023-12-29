﻿namespace Proyecto_de_Graduacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.PbLogomodu = new FontAwesome.Sharp.IconPictureBox();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            this.GbOpciones = new System.Windows.Forms.GroupBox();
            this.Btndardebaja = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevoPaciente = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogomodu)).BeginInit();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.GbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBudc
            // 
            this.PnlBudc.Controls.Add(this.PbLogomodu);
            this.PnlBudc.Controls.Add(this.BtnRefrescar);
            this.PnlBudc.Controls.Add(this.ICNBuscador);
            this.PnlBudc.Controls.Add(this.PnlBuscare);
            this.PnlBudc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBudc.Location = new System.Drawing.Point(0, 0);
            this.PnlBudc.Name = "PnlBudc";
            this.PnlBudc.Size = new System.Drawing.Size(1097, 78);
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
            this.PbLogomodu.Location = new System.Drawing.Point(1036, 12);
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
            this.TxtBuscarPaciente.Enter += new System.EventHandler(this.TxtBuscarPaciente_Enter);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGrid.Controls.Add(this.DtgPaciente);
            this.PnlGrid.Location = new System.Drawing.Point(12, 85);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(1073, 518);
            this.PnlGrid.TabIndex = 79;
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.AllowUserToAddRows = false;
            this.DtgPaciente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DtgPaciente.ColumnHeadersHeight = 40;
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgPaciente.DefaultCellStyle = dataGridViewCellStyle8;
            this.DtgPaciente.EnableHeadersVisualStyles = false;
            this.DtgPaciente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.Location = new System.Drawing.Point(18, 14);
            this.DtgPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.ReadOnly = true;
            this.DtgPaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DtgPaciente.RowHeadersWidth = 65;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DtgPaciente.RowTemplate.Height = 24;
            this.DtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPaciente.Size = new System.Drawing.Size(1040, 479);
            this.DtgPaciente.TabIndex = 2;
            // 
            // GbOpciones
            // 
            this.GbOpciones.Controls.Add(this.Btndardebaja);
            this.GbOpciones.Controls.Add(this.BtnEditar);
            this.GbOpciones.Controls.Add(this.BtnNuevoPaciente);
            this.GbOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbOpciones.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbOpciones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GbOpciones.Location = new System.Drawing.Point(0, 597);
            this.GbOpciones.Name = "GbOpciones";
            this.GbOpciones.Size = new System.Drawing.Size(1097, 100);
            this.GbOpciones.TabIndex = 80;
            this.GbOpciones.TabStop = false;
            this.GbOpciones.Text = "Opciones";
            // 
            // Btndardebaja
            // 
            this.Btndardebaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btndardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btndardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btndardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndardebaja.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.Btndardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.Btndardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btndardebaja.IconSize = 20;
            this.Btndardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndardebaja.Location = new System.Drawing.Point(857, 32);
            this.Btndardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndardebaja.Name = "Btndardebaja";
            this.Btndardebaja.Size = new System.Drawing.Size(216, 44);
            this.Btndardebaja.TabIndex = 57;
            this.Btndardebaja.Text = "Dar de Baja";
            this.Btndardebaja.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(30, 32);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(215, 44);
            this.BtnEditar.TabIndex = 56;
            this.BtnEditar.Text = "Editar Paciente";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevoPaciente
            // 
            this.BtnNuevoPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnNuevoPaciente.BackColor = System.Drawing.Color.White;
            this.BtnNuevoPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoPaciente.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoPaciente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoPaciente.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoPaciente.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoPaciente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoPaciente.IconSize = 20;
            this.BtnNuevoPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoPaciente.Location = new System.Drawing.Point(452, 32);
            this.BtnNuevoPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoPaciente.Name = "BtnNuevoPaciente";
            this.BtnNuevoPaciente.Size = new System.Drawing.Size(209, 44);
            this.BtnNuevoPaciente.TabIndex = 55;
            this.BtnNuevoPaciente.Text = "Nuevo Paciente";
            this.BtnNuevoPaciente.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrodePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1097, 697);
            this.Controls.Add(this.GbOpciones);
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
            this.GbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private FontAwesome.Sharp.IconPictureBox PbLogomodu;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarPaciente;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgPaciente;
        private System.Windows.Forms.GroupBox GbOpciones;
        private FontAwesome.Sharp.IconButton Btndardebaja;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnNuevoPaciente;
    }
}