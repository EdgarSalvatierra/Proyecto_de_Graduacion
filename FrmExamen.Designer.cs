namespace Proyecto_de_Graduacion
{
    partial class FrmExamen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBudc = new System.Windows.Forms.Panel();
            this.PnlBuscare = new System.Windows.Forms.Panel();
            this.TxtBuscarExamen = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DtgExamen = new System.Windows.Forms.DataGridView();
            this.BtnRefrescar = new FontAwesome.Sharp.IconButton();
            this.ICNBuscador = new FontAwesome.Sharp.IconButton();
            this.gbopciones = new System.Windows.Forms.GroupBox();
            this.BtnNuevoExamen = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.ICNCategoria = new FontAwesome.Sharp.IconButton();
            this.BtnDardebaja = new FontAwesome.Sharp.IconButton();
            this.PnlBudc.SuspendLayout();
            this.PnlBuscare.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgExamen)).BeginInit();
            this.gbopciones.SuspendLayout();
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
            this.PnlBudc.Size = new System.Drawing.Size(1043, 78);
            this.PnlBudc.TabIndex = 0;
            // 
            // PnlBuscare
            // 
            this.PnlBuscare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBuscare.Controls.Add(this.TxtBuscarExamen);
            this.PnlBuscare.Location = new System.Drawing.Point(11, 25);
            this.PnlBuscare.Name = "PnlBuscare";
            this.PnlBuscare.Size = new System.Drawing.Size(371, 35);
            this.PnlBuscare.TabIndex = 0;
            // 
            // TxtBuscarExamen
            // 
            this.TxtBuscarExamen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscarExamen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarExamen.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtBuscarExamen.Location = new System.Drawing.Point(15, 10);
            this.TxtBuscarExamen.Name = "TxtBuscarExamen";
            this.TxtBuscarExamen.Size = new System.Drawing.Size(351, 15);
            this.TxtBuscarExamen.TabIndex = 0;
            this.TxtBuscarExamen.Text = "Buscar Examen";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "gear-fill.png");
            this.imageList.Images.SetKeyName(1, "house-fill.png");
            this.imageList.Images.SetKeyName(2, "usuarios.PNG");
            this.imageList.Images.SetKeyName(3, "ventas.PNG");
            this.imageList.Images.SetKeyName(4, "Compras.PNG");
            this.imageList.Images.SetKeyName(5, "file-earmark-easel.png");
            this.imageList.Images.SetKeyName(6, "people-fill.png");
            this.imageList.Images.SetKeyName(7, "journal-medical (1).png");
            this.imageList.Images.SetKeyName(8, "buscador-removebg-preview (1).png");
            // 
            // PnlGrid
            // 
            this.PnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlGrid.Controls.Add(this.DtgExamen);
            this.PnlGrid.Location = new System.Drawing.Point(0, 78);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(1043, 452);
            this.PnlGrid.TabIndex = 76;
            // 
            // DtgExamen
            // 
            this.DtgExamen.AllowUserToAddRows = false;
            this.DtgExamen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DtgExamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtgExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgExamen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgExamen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgExamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgExamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgExamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgExamen.ColumnHeadersHeight = 40;
            this.DtgExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgExamen.DefaultCellStyle = dataGridViewCellStyle7;
            this.DtgExamen.EnableHeadersVisualStyles = false;
            this.DtgExamen.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgExamen.Location = new System.Drawing.Point(12, 27);
            this.DtgExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgExamen.Name = "DtgExamen";
            this.DtgExamen.ReadOnly = true;
            this.DtgExamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgExamen.RowHeadersWidth = 65;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgExamen.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DtgExamen.RowTemplate.Height = 24;
            this.DtgExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgExamen.Size = new System.Drawing.Size(1019, 405);
            this.DtgExamen.TabIndex = 1;
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
            // gbopciones
            // 
            this.gbopciones.Controls.Add(this.BtnNuevoExamen);
            this.gbopciones.Controls.Add(this.BtnEditar);
            this.gbopciones.Controls.Add(this.ICNCategoria);
            this.gbopciones.Controls.Add(this.BtnDardebaja);
            this.gbopciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbopciones.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbopciones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbopciones.Location = new System.Drawing.Point(0, 546);
            this.gbopciones.Name = "gbopciones";
            this.gbopciones.Size = new System.Drawing.Size(1043, 119);
            this.gbopciones.TabIndex = 77;
            this.gbopciones.TabStop = false;
            this.gbopciones.Text = "Opciones";
            // 
            // BtnNuevoExamen
            // 
            this.BtnNuevoExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnNuevoExamen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevoExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNuevoExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoExamen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoExamen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoExamen.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnNuevoExamen.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevoExamen.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnNuevoExamen.IconSize = 20;
            this.BtnNuevoExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoExamen.Location = new System.Drawing.Point(541, 38);
            this.BtnNuevoExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNuevoExamen.Name = "BtnNuevoExamen";
            this.BtnNuevoExamen.Size = new System.Drawing.Size(206, 49);
            this.BtnNuevoExamen.TabIndex = 81;
            this.BtnNuevoExamen.Text = "Nuevo Examen";
            this.BtnNuevoExamen.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.BtnEditar.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEditar.IconSize = 20;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(12, 37);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(198, 50);
            this.BtnEditar.TabIndex = 79;
            this.BtnEditar.Text = "Editar Examen";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // ICNCategoria
            // 
            this.ICNCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ICNCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ICNCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ICNCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICNCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICNCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ICNCategoria.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ICNCategoria.IconColor = System.Drawing.SystemColors.Highlight;
            this.ICNCategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ICNCategoria.IconSize = 20;
            this.ICNCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICNCategoria.Location = new System.Drawing.Point(282, 37);
            this.ICNCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ICNCategoria.Name = "ICNCategoria";
            this.ICNCategoria.Size = new System.Drawing.Size(202, 50);
            this.ICNCategoria.TabIndex = 82;
            this.ICNCategoria.Text = "Nuevo Categoria";
            this.ICNCategoria.UseVisualStyleBackColor = false;
            // 
            // BtnDardebaja
            // 
            this.BtnDardebaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDardebaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDardebaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDardebaja.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDardebaja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconChar = FontAwesome.Sharp.IconChar.TurnDown;
            this.BtnDardebaja.IconColor = System.Drawing.SystemColors.Highlight;
            this.BtnDardebaja.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDardebaja.IconSize = 20;
            this.BtnDardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDardebaja.Location = new System.Drawing.Point(828, 38);
            this.BtnDardebaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDardebaja.Name = "BtnDardebaja";
            this.BtnDardebaja.Size = new System.Drawing.Size(190, 49);
            this.BtnDardebaja.TabIndex = 80;
            this.BtnDardebaja.Text = "Dar de Baja";
            this.BtnDardebaja.UseVisualStyleBackColor = false;
            // 
            // FrmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 665);
            this.Controls.Add(this.gbopciones);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBudc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExamen";
            this.Load += new System.EventHandler(this.FrmExamen_Load);
            this.PnlBudc.ResumeLayout(false);
            this.PnlBuscare.ResumeLayout(false);
            this.PnlBuscare.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgExamen)).EndInit();
            this.gbopciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBudc;
        private System.Windows.Forms.Panel PnlBuscare;
        private System.Windows.Forms.TextBox TxtBuscarExamen;
        private System.Windows.Forms.ImageList imageList;
        private FontAwesome.Sharp.IconButton ICNBuscador;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView DtgExamen;
        private FontAwesome.Sharp.IconButton BtnRefrescar;
        private System.Windows.Forms.GroupBox gbopciones;
        private FontAwesome.Sharp.IconButton BtnNuevoExamen;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton ICNCategoria;
        private FontAwesome.Sharp.IconButton BtnDardebaja;
    }
}