namespace Proyecto_de_Graduacion
{
    partial class FrmEditarExamen_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnleditarexamen = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardarTodo = new System.Windows.Forms.Button();
            this.BtncargarPlantilla = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.Lblruta = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CMBCategoria = new System.Windows.Forms.ComboBox();
            this.PnlExamen = new System.Windows.Forms.Panel();
            this.DtgExamen = new System.Windows.Forms.DataGridView();
            this.PnlPaciente = new System.Windows.Forms.Panel();
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            this.Pnleditarexamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgExamen)).BeginInit();
            this.PnlPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnleditarexamen
            // 
            this.Pnleditarexamen.Controls.Add(this.BtnCancelar);
            this.Pnleditarexamen.Controls.Add(this.BtnGuardarTodo);
            this.Pnleditarexamen.Controls.Add(this.BtncargarPlantilla);
            this.Pnleditarexamen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnleditarexamen.Location = new System.Drawing.Point(0, 489);
            this.Pnleditarexamen.Name = "Pnleditarexamen";
            this.Pnleditarexamen.Size = new System.Drawing.Size(1267, 63);
            this.Pnleditarexamen.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AllowDrop = true;
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(666, 9);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 42);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardarTodo
            // 
            this.BtnGuardarTodo.AllowDrop = true;
            this.BtnGuardarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnGuardarTodo.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarTodo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarTodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardarTodo.Location = new System.Drawing.Point(487, 9);
            this.BtnGuardarTodo.Name = "BtnGuardarTodo";
            this.BtnGuardarTodo.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardarTodo.TabIndex = 1;
            this.BtnGuardarTodo.Text = "Guardar";
            this.BtnGuardarTodo.UseVisualStyleBackColor = false;
            this.BtnGuardarTodo.Click += new System.EventHandler(this.BtnGuardarTodo_Click);
            // 
            // BtncargarPlantilla
            // 
            this.BtncargarPlantilla.AllowDrop = true;
            this.BtncargarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtncargarPlantilla.BackColor = System.Drawing.Color.SteelBlue;
            this.BtncargarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncargarPlantilla.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncargarPlantilla.ForeColor = System.Drawing.Color.White;
            this.BtncargarPlantilla.Location = new System.Drawing.Point(304, 9);
            this.BtncargarPlantilla.Name = "BtncargarPlantilla";
            this.BtncargarPlantilla.Size = new System.Drawing.Size(160, 42);
            this.BtncargarPlantilla.TabIndex = 0;
            this.BtncargarPlantilla.Text = "Cargar Plantilla";
            this.BtncargarPlantilla.UseVisualStyleBackColor = false;
            this.BtncargarPlantilla.Click += new System.EventHandler(this.BtncargarPlantilla_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.LblPrecio);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Controls.Add(this.TxtTitulo);
            this.panel1.Controls.Add(this.TxtRuta);
            this.panel1.Controls.Add(this.Lblruta);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.CMBCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 151);
            this.panel1.TabIndex = 99;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(12, 10);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(77, 20);
            this.lblPaciente.TabIndex = 112;
            this.lblPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(143, 6);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(485, 31);
            this.txtPaciente.TabIndex = 113;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(144, 111);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(484, 31);
            this.TxtPrecio.TabIndex = 110;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(16, 111);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(60, 20);
            this.LblPrecio.TabIndex = 109;
            this.LblPrecio.Text = "Precio";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(16, 59);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(73, 20);
            this.lbltitulo.TabIndex = 98;
            this.lbltitulo.Text = "Examen";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(143, 59);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(485, 31);
            this.TxtTitulo.TabIndex = 100;
            // 
            // TxtRuta
            // 
            this.TxtRuta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRuta.Location = new System.Drawing.Point(783, 66);
            this.TxtRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(431, 31);
            this.TxtRuta.TabIndex = 108;
            // 
            // Lblruta
            // 
            this.Lblruta.AutoSize = true;
            this.Lblruta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblruta.Location = new System.Drawing.Point(643, 70);
            this.Lblruta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblruta.Name = "Lblruta";
            this.Lblruta.Size = new System.Drawing.Size(133, 20);
            this.Lblruta.TabIndex = 107;
            this.Lblruta.Text = "Ruta de Archivo";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(643, 10);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(87, 20);
            this.LblCategoria.TabIndex = 104;
            this.LblCategoria.Text = "Categoria";
            // 
            // CMBCategoria
            // 
            this.CMBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCategoria.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCategoria.FormattingEnabled = true;
            this.CMBCategoria.Location = new System.Drawing.Point(782, 10);
            this.CMBCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBCategoria.Name = "CMBCategoria";
            this.CMBCategoria.Size = new System.Drawing.Size(432, 28);
            this.CMBCategoria.TabIndex = 105;
            // 
            // PnlExamen
            // 
            this.PnlExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlExamen.Controls.Add(this.DtgExamen);
            this.PnlExamen.Location = new System.Drawing.Point(12, 158);
            this.PnlExamen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlExamen.Name = "PnlExamen";
            this.PnlExamen.Size = new System.Drawing.Size(658, 324);
            this.PnlExamen.TabIndex = 102;
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
            this.DtgExamen.Size = new System.Drawing.Size(634, 277);
            this.DtgExamen.TabIndex = 1;
            this.DtgExamen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgExamen_CellClick);
            // 
            // PnlPaciente
            // 
            this.PnlPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPaciente.Controls.Add(this.DtgPaciente);
            this.PnlPaciente.Location = new System.Drawing.Point(676, 158);
            this.PnlPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlPaciente.Name = "PnlPaciente";
            this.PnlPaciente.Size = new System.Drawing.Size(579, 324);
            this.PnlPaciente.TabIndex = 103;
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.AllowUserToAddRows = false;
            this.DtgPaciente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgPaciente.ColumnHeadersHeight = 40;
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgPaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgPaciente.EnableHeadersVisualStyles = false;
            this.DtgPaciente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgPaciente.Location = new System.Drawing.Point(12, 27);
            this.DtgPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.ReadOnly = true;
            this.DtgPaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgPaciente.RowHeadersWidth = 65;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgPaciente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgPaciente.RowTemplate.Height = 24;
            this.DtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPaciente.Size = new System.Drawing.Size(555, 277);
            this.DtgPaciente.TabIndex = 1;
            this.DtgPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPaciente_CellClick);
            // 
            // FrmEditarExamen_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 552);
            this.Controls.Add(this.PnlPaciente);
            this.Controls.Add(this.PnlExamen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnleditarexamen);
            this.Name = "FrmEditarExamen_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarExamen_";
            this.Load += new System.EventHandler(this.FrmEditarExamen__Load);
            this.Pnleditarexamen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlExamen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgExamen)).EndInit();
            this.PnlPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnleditarexamen;
        private System.Windows.Forms.Button BtncargarPlantilla;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardarTodo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.Label Lblruta;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CMBCategoria;
        private System.Windows.Forms.Panel PnlPaciente;
        private System.Windows.Forms.DataGridView DtgPaciente;
        private System.Windows.Forms.Panel PnlExamen;
        private System.Windows.Forms.DataGridView DtgExamen;
    }
}