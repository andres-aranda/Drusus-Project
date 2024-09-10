namespace Drusus.Formularios
{
    partial class FormularioSubasta
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblGanador = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnSortear = new System.Windows.Forms.Button();
			this.btnFinalizar = new System.Windows.Forms.Button();
			this.dgvSubasta = new System.Windows.Forms.DataGridView();
			this.sbastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rbSubasta = new System.Windows.Forms.RadioButton();
			this.rbMia = new System.Windows.Forms.RadioButton();
			this.MonedaTextBox = new System.Windows.Forms.TextBox();
			this.limpiarButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.totalButton = new System.Windows.Forms.Button();
			this.totalLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textboxDolar = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.btnClientes = new FontAwesome.Sharp.IconButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbastaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textboxDolar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(927, 103);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(154, 25);
			this.lblTitulo.TabIndex = 29;
			this.lblTitulo.Text = " Subasta drusus";
			// 
			// lblGanador
			// 
			this.lblGanador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblGanador.AutoSize = true;
			this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGanador.ForeColor = System.Drawing.Color.White;
			this.lblGanador.Location = new System.Drawing.Point(193, 503);
			this.lblGanador.Name = "lblGanador";
			this.lblGanador.Size = new System.Drawing.Size(41, 37);
			this.lblGanador.TabIndex = 30;
			this.lblGanador.Text = "N";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(128, 513);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "Ganador";
			// 
			// btnSortear
			// 
			this.btnSortear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSortear.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSortear.ForeColor = System.Drawing.Color.White;
			this.btnSortear.Location = new System.Drawing.Point(29, 508);
			this.btnSortear.Name = "btnSortear";
			this.btnSortear.Size = new System.Drawing.Size(75, 23);
			this.btnSortear.TabIndex = 32;
			this.btnSortear.Text = "Sortear";
			this.btnSortear.UseVisualStyleBackColor = true;
			this.btnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinalizar.ForeColor = System.Drawing.Color.White;
			this.btnFinalizar.Location = new System.Drawing.Point(932, 321);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(150, 23);
			this.btnFinalizar.TabIndex = 34;
			this.btnFinalizar.Text = "Finalizar";
			this.btnFinalizar.UseVisualStyleBackColor = true;
			this.btnFinalizar.Click += new System.EventHandler(this.Finalizar_Click);
			// 
			// dgvSubasta
			// 
			this.dgvSubasta.AllowDrop = true;
			this.dgvSubasta.AllowUserToAddRows = false;
			this.dgvSubasta.AllowUserToDeleteRows = false;
			this.dgvSubasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSubasta.AutoGenerateColumns = false;
			this.dgvSubasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSubasta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSubasta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.dgvSubasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSubasta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dgvSubasta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSubasta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSubasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSubasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.monto,
            this.descripcion});
			this.dgvSubasta.DataSource = this.sbastaBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSubasta.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvSubasta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.dgvSubasta.Location = new System.Drawing.Point(29, 69);
			this.dgvSubasta.MultiSelect = false;
			this.dgvSubasta.Name = "dgvSubasta";
			this.dgvSubasta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSubasta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvSubasta.RowHeadersWidth = 70;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			this.dgvSubasta.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSubasta.Size = new System.Drawing.Size(856, 414);
			this.dgvSubasta.TabIndex = 116;
			this.dgvSubasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubasta_CellContentClick);
			this.dgvSubasta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubasta_CellValueChanged);
			this.dgvSubasta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
			// 
			// sbastaBindingSource
			// 
			this.sbastaBindingSource.DataSource = typeof(Datos.sbasta);
			// 
			// rbSubasta
			// 
			this.rbSubasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbSubasta.AutoSize = true;
			this.rbSubasta.Checked = true;
			this.rbSubasta.ForeColor = System.Drawing.Color.White;
			this.rbSubasta.Location = new System.Drawing.Point(736, 30);
			this.rbSubasta.Name = "rbSubasta";
			this.rbSubasta.Size = new System.Drawing.Size(64, 17);
			this.rbSubasta.TabIndex = 117;
			this.rbSubasta.TabStop = true;
			this.rbSubasta.Text = "Subasta";
			this.rbSubasta.UseVisualStyleBackColor = true;
			this.rbSubasta.CheckedChanged += new System.EventHandler(this.RbSubasta_CheckedChanged);
			// 
			// rbMia
			// 
			this.rbMia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbMia.AutoSize = true;
			this.rbMia.ForeColor = System.Drawing.Color.White;
			this.rbMia.Location = new System.Drawing.Point(844, 30);
			this.rbMia.Name = "rbMia";
			this.rbMia.Size = new System.Drawing.Size(42, 17);
			this.rbMia.TabIndex = 118;
			this.rbMia.Text = "Mia";
			this.rbMia.UseVisualStyleBackColor = true;
			this.rbMia.CheckedChanged += new System.EventHandler(this.RbMia_CheckedChanged);
			// 
			// MonedaTextBox
			// 
			this.MonedaTextBox.Location = new System.Drawing.Point(220, 32);
			this.MonedaTextBox.Name = "MonedaTextBox";
			this.MonedaTextBox.Size = new System.Drawing.Size(177, 20);
			this.MonedaTextBox.TabIndex = 122;
			this.MonedaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonedaTextBox_KeyPress);
			// 
			// limpiarButton
			// 
			this.limpiarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.limpiarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.limpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.limpiarButton.ForeColor = System.Drawing.Color.White;
			this.limpiarButton.Location = new System.Drawing.Point(932, 350);
			this.limpiarButton.Name = "limpiarButton";
			this.limpiarButton.Size = new System.Drawing.Size(150, 23);
			this.limpiarButton.TabIndex = 125;
			this.limpiarButton.Text = "Limpiar datos";
			this.limpiarButton.UseVisualStyleBackColor = true;
			this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(78, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 23);
			this.button2.TabIndex = 127;
			this.button2.Text = "Agregar moneda";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.AgregadorMonedas);
			// 
			// totalButton
			// 
			this.totalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.totalButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.totalButton.ForeColor = System.Drawing.Color.White;
			this.totalButton.Location = new System.Drawing.Point(931, 439);
			this.totalButton.Name = "totalButton";
			this.totalButton.Size = new System.Drawing.Size(150, 23);
			this.totalButton.TabIndex = 128;
			this.totalButton.Text = "Ver total";
			this.totalButton.UseVisualStyleBackColor = true;
			this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
			// 
			// totalLabel
			// 
			this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.totalLabel.AutoSize = true;
			this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalLabel.ForeColor = System.Drawing.Color.White;
			this.totalLabel.Location = new System.Drawing.Point(935, 400);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(19, 25);
			this.totalLabel.TabIndex = 129;
			this.totalLabel.Text = "-";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(929, 382);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 130;
			this.label2.Text = " Total";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(931, 506);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 23);
			this.button1.TabIndex = 131;
			this.button1.Text = "Pesificar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textboxDolar
			// 
			this.textboxDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxDolar.Location = new System.Drawing.Point(1020, 477);
			this.textboxDolar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.textboxDolar.Name = "textboxDolar";
			this.textboxDolar.Size = new System.Drawing.Size(63, 20);
			this.textboxDolar.TabIndex = 133;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(931, 479);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 134;
			this.label1.Text = "Precio Dolar";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImage = global::Drusus.Properties.Resources.wod;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.Location = new System.Drawing.Point(29, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(42, 41);
			this.button3.TabIndex = 135;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// iconButton1
			// 
			this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 20;
			this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.Location = new System.Drawing.Point(566, 21);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButton1.Size = new System.Drawing.Size(149, 41);
			this.iconButton1.TabIndex = 124;
			this.iconButton1.Text = "Eliminar";
			this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClientes.FlatAppearance.BorderSize = 0;
			this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
			this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
			this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClientes.IconSize = 35;
			this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClientes.Location = new System.Drawing.Point(927, 32);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnClientes.Size = new System.Drawing.Size(155, 41);
			this.btnClientes.TabIndex = 123;
			this.btnClientes.Text = "Agregar Cliente";
			this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::Drusus.Properties.Resources.grifo;
			this.pictureBox2.Location = new System.Drawing.Point(932, 150);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(150, 150);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 33;
			this.pictureBox2.TabStop = false;
			// 
			// Nro
			// 
			this.Nro.DataPropertyName = "id";
			this.Nro.FillWeight = 45.68528F;
			this.Nro.HeaderText = "Nro";
			this.Nro.Name = "Nro";
			this.Nro.ReadOnly = true;
			// 
			// monto
			// 
			this.monto.DataPropertyName = "monto";
			this.monto.FillWeight = 127.1574F;
			this.monto.HeaderText = "Monto";
			this.monto.Name = "monto";
			// 
			// descripcion
			// 
			this.descripcion.DataPropertyName = "descripcion";
			this.descripcion.FillWeight = 127.1574F;
			this.descripcion.HeaderText = "Descripcion";
			this.descripcion.Name = "descripcion";
			// 
			// FormularioSubasta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1137, 555);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textboxDolar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.totalButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.limpiarButton);
			this.Controls.Add(this.iconButton1);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.MonedaTextBox);
			this.Controls.Add(this.rbMia);
			this.Controls.Add(this.rbSubasta);
			this.Controls.Add(this.dgvSubasta);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnSortear);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.lblGanador);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FormularioSubasta";
			this.Text = "Subasta / Mia";
			this.Load += new System.EventHandler(this.FormularioSubasta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbastaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textboxDolar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvSubasta;
        private System.Windows.Forms.RadioButton rbSubasta;
        private System.Windows.Forms.RadioButton rbMia;
        private System.Windows.Forms.BindingSource sbastaBindingSource;
        private System.Windows.Forms.TextBox MonedaTextBox;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown textboxDolar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn monto;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
	}
}