namespace DrususV2
{
    partial class FormSubasta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbSubasta = new System.Windows.Forms.RadioButton();
            this.rbMia = new System.Windows.Forms.RadioButton();
            this.cardGrid = new System.Windows.Forms.Panel();
            this.dgvSubasta = new System.Windows.Forms.DataGridView();
            this.subastaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDolar = new System.Windows.Forms.Label();
            this.textboxDolar = new System.Windows.Forms.NumericUpDown();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cardControles = new System.Windows.Forms.Panel();
            this.totalMiasLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.MonedaTextBox = new System.Windows.Forms.TextBox();
            this.lblAgregarPremio = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxDolar)).BeginInit();
            this.cardControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Controlador de Subastas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Subasta Drusus";
            // 
            // rbSubasta
            // 
            this.rbSubasta.AutoSize = true;
            this.rbSubasta.Checked = true;
            this.rbSubasta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbSubasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbSubasta.Location = new System.Drawing.Point(250, 75);
            this.rbSubasta.Name = "rbSubasta";
            this.rbSubasta.Size = new System.Drawing.Size(117, 21);
            this.rbSubasta.TabIndex = 2;
            this.rbSubasta.TabStop = true;
            this.rbSubasta.Text = "Subasta Oficial";
            this.rbSubasta.UseVisualStyleBackColor = true;
            this.rbSubasta.CheckedChanged += new System.EventHandler(this.RbSubasta_CheckedChanged);
            // 
            // rbMia
            // 
            this.rbMia.AutoSize = true;
            this.rbMia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbMia.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbMia.Location = new System.Drawing.Point(380, 75);
            this.rbMia.Name = "rbMia";
            this.rbMia.Size = new System.Drawing.Size(100, 21);
            this.rbMia.TabIndex = 3;
            this.rbMia.Text = "Subasta Mía";
            this.rbMia.UseVisualStyleBackColor = true;
            this.rbMia.CheckedChanged += new System.EventHandler(this.RbMia_CheckedChanged);
            // 
            // cardGrid
            // 
            this.cardGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardGrid.Controls.Add(this.dgvSubasta);
            this.cardGrid.Location = new System.Drawing.Point(40, 115);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Size = new System.Drawing.Size(530, 480);
            this.cardGrid.TabIndex = 4;
            // 
            // dgvSubasta
            // 
            this.dgvSubasta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.dgvSubasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subastaId,
            this.monto,
            this.descripcion});
            this.dgvSubasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubasta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(85)))));
            this.dgvSubasta.Location = new System.Drawing.Point(0, 0);
            this.dgvSubasta.Name = "dgvSubasta";
            this.dgvSubasta.RowHeadersVisible = false;
            this.dgvSubasta.Size = new System.Drawing.Size(530, 480);
            this.dgvSubasta.TabIndex = 0;
            this.dgvSubasta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubasta_CellValueChanged);
            this.dgvSubasta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // subastaId
            // 
            this.subastaId.DataPropertyName = "id";
            this.subastaId.HeaderText = "ID";
            this.subastaId.Name = "subastaId";
            this.subastaId.ReadOnly = true;
            this.subastaId.Width = 50;
            this.subastaId.Visible = false;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Premio / Artículo";
            this.descripcion.Name = "descripcion";
            // 
            // lblDolar
            // 
            this.lblDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDolar.Location = new System.Drawing.Point(40, 608);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(76, 15);
            this.lblDolar.TabIndex = 5;
            this.lblDolar.Text = "Multiplicador";
            // 
            // textboxDolar
            // 
            this.textboxDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.textboxDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxDolar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textboxDolar.ForeColor = System.Drawing.Color.White;
            this.textboxDolar.Location = new System.Drawing.Point(120, 604);
            this.textboxDolar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textboxDolar.Name = "textboxDolar";
            this.textboxDolar.Size = new System.Drawing.Size(60, 24);
            this.textboxDolar.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Location = new System.Drawing.Point(185, 604);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(65, 25);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "× Dólar";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(255, 604);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(65, 25);
            this.btnDividir.TabIndex = 11;
            this.btnDividir.Text = "÷ Dólar";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnWord
            // 
            this.btnWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWord.BackColor = System.Drawing.Color.Transparent;
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnWord.Location = new System.Drawing.Point(340, 604);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(100, 25);
            this.btnWord.TabIndex = 8;
            this.btnWord.Text = "Importar Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnEliminar.Location = new System.Drawing.Point(450, 604);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 25);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnLimpiar.Location = new System.Drawing.Point(510, 604);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Vaciar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cardControles
            // 
            this.cardControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardControles.Controls.Add(this.btnFinalizar);
            this.cardControles.Controls.Add(this.totalMiasLabel);
            this.cardControles.Controls.Add(this.totalLabel);
            this.cardControles.Controls.Add(this.btnTotal);
            this.cardControles.Controls.Add(this.lblGanador);
            this.cardControles.Controls.Add(this.btnSortear);
            this.cardControles.Controls.Add(this.btnAgregar);
            this.cardControles.Controls.Add(this.MonedaTextBox);
            this.cardControles.Controls.Add(this.lblAgregarPremio);
            this.cardControles.Location = new System.Drawing.Point(590, 115);
            this.cardControles.Name = "cardControles";
            this.cardControles.Size = new System.Drawing.Size(340, 480);
            this.cardControles.TabIndex = 11;
            // 
            // totalMiasLabel
            // 
            this.totalMiasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.totalMiasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.totalMiasLabel.Location = new System.Drawing.Point(20, 350);
            this.totalMiasLabel.Name = "totalMiasLabel";
            this.totalMiasLabel.Size = new System.Drawing.Size(300, 30);
            this.totalMiasLabel.TabIndex = 8;
            this.totalMiasLabel.Text = "Mías: $ 0";
            this.totalMiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.totalLabel.Location = new System.Drawing.Point(20, 310);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(300, 40);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "$ 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(20, 270);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(300, 35);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Calcular Total Subastado";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblGanador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblGanador.Location = new System.Drawing.Point(20, 210);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(300, 35);
            this.lblGanador.TabIndex = 4;
            this.lblGanador.Text = "Ganador Sorteo";
            this.lblGanador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnSortear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortear.FlatAppearance.BorderSize = 0;
            this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSortear.ForeColor = System.Drawing.Color.White;
            this.btnSortear.Location = new System.Drawing.Point(20, 160);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(300, 40);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "Realizar Sorteo Aleatorio";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(240, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.AgregadorMonedas);
            // 
            // MonedaTextBox
            // 
            this.MonedaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.MonedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonedaTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MonedaTextBox.ForeColor = System.Drawing.Color.White;
            this.MonedaTextBox.Location = new System.Drawing.Point(20, 95);
            this.MonedaTextBox.Name = "MonedaTextBox";
            this.MonedaTextBox.Size = new System.Drawing.Size(210, 25);
            this.MonedaTextBox.TabIndex = 1;
            this.MonedaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonedaTextBox_KeyPress);
            // 
            // lblAgregarPremio
            // 
            this.lblAgregarPremio.AutoSize = true;
            this.lblAgregarPremio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAgregarPremio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblAgregarPremio.Location = new System.Drawing.Point(20, 70);
            this.lblAgregarPremio.Name = "lblAgregarPremio";
            this.lblAgregarPremio.Size = new System.Drawing.Size(149, 17);
            this.lblAgregarPremio.TabIndex = 0;
            this.lblAgregarPremio.Text = "Añadir Premio Manual";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(20, 390);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(300, 45);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar Subasta y Computar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // FormSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.cardControles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.textboxDolar);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.rbMia);
            this.Controls.Add(this.rbSubasta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSubasta";
            this.Text = "Subasta";
            this.Load += new System.EventHandler(this.FormSubasta_Load);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxDolar)).EndInit();
            this.cardControles.ResumeLayout(false);
            this.cardControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbSubasta;
        private System.Windows.Forms.RadioButton rbMia;
        private System.Windows.Forms.Panel cardGrid;
        private System.Windows.Forms.DataGridView dgvSubasta;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.NumericUpDown textboxDolar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel cardControles;
        private System.Windows.Forms.Label lblAgregarPremio;
        private System.Windows.Forms.TextBox MonedaTextBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn subastaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label totalMiasLabel;
    }
}
