namespace DrususV2
{
    partial class FormFichaCliente
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
            this.lblBuscador = new System.Windows.Forms.Label();
            this.buscadorComboBox = new System.Windows.Forms.ComboBox();
            this.panelFicha = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.deudorButton = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nuevoPagoButton = new System.Windows.Forms.Button();
            this.nuevaVentaButton = new System.Windows.Forms.Button();
            this.tabControlFicha = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.compraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.pagosDataGridView = new System.Windows.Forms.DataGridView();
            this.pagoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDeuda = new System.Windows.Forms.Panel();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblDeudaTitle = new System.Windows.Forms.Label();
            this.cardDesglose = new System.Windows.Forms.GroupBox();
            this.USStextBox = new System.Windows.Forms.TextBox();
            this.lblUss = new System.Windows.Forms.Label();
            this.masVentiunTextBox = new System.Windows.Forms.TextBox();
            this.lblMas21 = new System.Windows.Forms.Label();
            this.ventiunTextBox = new System.Windows.Forms.TextBox();
            this.lbl21 = new System.Windows.Forms.Label();
            this.catorceTextBox = new System.Windows.Forms.TextBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.sieteTextBox = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelFicha.SuspendLayout();
            this.tabControlFicha.SuspendLayout();
            this.tabCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosDataGridView)).BeginInit();
            this.cardDeuda.SuspendLayout();
            this.cardDesglose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ficha de Clientes";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblBuscador.Location = new System.Drawing.Point(40, 80);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(95, 17);
            this.lblBuscador.TabIndex = 1;
            this.lblBuscador.Text = "Buscar Cliente: ";
            // 
            // buscadorComboBox
            // 
            this.buscadorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buscadorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscadorComboBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.buscadorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.buscadorComboBox.FormattingEnabled = true;
            this.buscadorComboBox.Location = new System.Drawing.Point(150, 76);
            this.buscadorComboBox.Name = "buscadorComboBox";
            this.buscadorComboBox.Size = new System.Drawing.Size(350, 27);
            this.buscadorComboBox.TabIndex = 2;
            this.buscadorComboBox.SelectedIndexChanged += new System.EventHandler(this.buscadorComboBox_SelectedIndexChanged);
            // 
            // panelFicha
            // 
            this.panelFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelFicha.Controls.Add(this.btnGuardar);
            this.panelFicha.Controls.Add(this.deudorButton);
            this.panelFicha.Controls.Add(this.btnEliminar);
            this.panelFicha.Controls.Add(this.nuevoPagoButton);
            this.panelFicha.Controls.Add(this.nuevaVentaButton);
            this.panelFicha.Controls.Add(this.tabControlFicha);
            this.panelFicha.Controls.Add(this.cardDeuda);
            this.panelFicha.Controls.Add(this.cardDesglose);
            this.panelFicha.Controls.Add(this.txtCuil);
            this.panelFicha.Controls.Add(this.lblCuil);
            this.panelFicha.Controls.Add(this.txtDireccion);
            this.panelFicha.Controls.Add(this.lblDireccion);
            this.panelFicha.Controls.Add(this.txtApellido);
            this.panelFicha.Controls.Add(this.lblApellido);
            this.panelFicha.Controls.Add(this.txtNombre);
            this.panelFicha.Controls.Add(this.lblNombre);
            this.panelFicha.Location = new System.Drawing.Point(40, 120);
            this.panelFicha.Name = "panelFicha";
            this.panelFicha.Size = new System.Drawing.Size(890, 500);
            this.panelFicha.TabIndex = 3;
            this.panelFicha.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(280, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 32);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // deudorButton
            // 
            this.deudorButton.BackColor = System.Drawing.Color.Transparent;
            this.deudorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deudorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.deudorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deudorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.deudorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.deudorButton.Location = new System.Drawing.Point(150, 230);
            this.deudorButton.Name = "deudorButton";
            this.deudorButton.Size = new System.Drawing.Size(120, 32);
            this.deudorButton.TabIndex = 14;
            this.deudorButton.Text = "Marcar Deudor";
            this.deudorButton.UseVisualStyleBackColor = false;
            this.deudorButton.Click += new System.EventHandler(this.deudorButton_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnEliminar.Location = new System.Drawing.Point(20, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // nuevoPagoButton
            // 
            this.nuevoPagoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevoPagoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.nuevoPagoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevoPagoButton.FlatAppearance.BorderSize = 0;
            this.nuevoPagoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoPagoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nuevoPagoButton.ForeColor = System.Drawing.Color.White;
            this.nuevoPagoButton.Location = new System.Drawing.Point(750, 230);
            this.nuevoPagoButton.Name = "nuevoPagoButton";
            this.nuevoPagoButton.Size = new System.Drawing.Size(120, 32);
            this.nuevoPagoButton.TabIndex = 12;
            this.nuevoPagoButton.Text = "Registrar Pago";
            this.nuevoPagoButton.UseVisualStyleBackColor = false;
            this.nuevoPagoButton.Click += new System.EventHandler(this.nuevoPagoButton_Click);
            // 
            // nuevaVentaButton
            // 
            this.nuevaVentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevaVentaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.nuevaVentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevaVentaButton.FlatAppearance.BorderSize = 0;
            this.nuevaVentaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaVentaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nuevaVentaButton.ForeColor = System.Drawing.Color.White;
            this.nuevaVentaButton.Location = new System.Drawing.Point(620, 230);
            this.nuevaVentaButton.Name = "nuevaVentaButton";
            this.nuevaVentaButton.Size = new System.Drawing.Size(120, 32);
            this.nuevaVentaButton.TabIndex = 11;
            this.nuevaVentaButton.Text = "Registrar Venta";
            this.nuevaVentaButton.UseVisualStyleBackColor = false;
            this.nuevaVentaButton.Click += new System.EventHandler(this.nuevaVentaButton_Click);
            // 
            // tabControlFicha
            // 
            this.tabControlFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlFicha.Controls.Add(this.tabCompras);
            this.tabControlFicha.Controls.Add(this.tabPagos);
            this.tabControlFicha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlFicha.Location = new System.Drawing.Point(20, 275);
            this.tabControlFicha.Name = "tabControlFicha";
            this.tabControlFicha.SelectedIndex = 0;
            this.tabControlFicha.Size = new System.Drawing.Size(850, 210);
            this.tabControlFicha.TabIndex = 10;
            // 
            // tabCompras
            // 
            this.tabCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.tabCompras.Controls.Add(this.dgvCompras);
            this.tabCompras.Location = new System.Drawing.Point(4, 24);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(842, 182);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "Historial Compras / Ventas";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compraId,
            this.compraFecha,
            this.compraDesc,
            this.compraMonto});
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(85)))));
            this.dgvCompras.Location = new System.Drawing.Point(3, 3);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.Size = new System.Drawing.Size(836, 176);
            this.dgvCompras.TabIndex = 0;
            // 
            // compraId
            // 
            this.compraId.DataPropertyName = "idVenta";
            this.compraId.HeaderText = "ID Venta";
            this.compraId.Name = "compraId";
            this.compraId.ReadOnly = true;
            this.compraId.Width = 80;
            // 
            // compraFecha
            // 
            this.compraFecha.DataPropertyName = "fecha";
            this.compraFecha.HeaderText = "Fecha";
            this.compraFecha.Name = "compraFecha";
            this.compraFecha.ReadOnly = true;
            this.compraFecha.Width = 120;
            // 
            // compraDesc
            // 
            this.compraDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compraDesc.DataPropertyName = "descripcion";
            this.compraDesc.HeaderText = "Descripción";
            this.compraDesc.Name = "compraDesc";
            this.compraDesc.ReadOnly = true;
            // 
            // compraMonto
            // 
            this.compraMonto.DataPropertyName = "monto";
            this.compraMonto.HeaderText = "Monto";
            this.compraMonto.Name = "compraMonto";
            this.compraMonto.ReadOnly = true;
            this.compraMonto.Width = 120;
            // 
            // tabPagos
            // 
            this.tabPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.tabPagos.Controls.Add(this.pagosDataGridView);
            this.tabPagos.Location = new System.Drawing.Point(4, 24);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(842, 182);
            this.tabPagos.TabIndex = 1;
            this.tabPagos.Text = "Historial Cobros / Pagos";
            // 
            // pagosDataGridView
            // 
            this.pagosDataGridView.AllowUserToAddRows = false;
            this.pagosDataGridView.AllowUserToDeleteRows = false;
            this.pagosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.pagosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pagoId,
            this.pagoFecha,
            this.pagoDesc,
            this.pagoMonto});
            this.pagosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(85)))));
            this.pagosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.pagosDataGridView.Name = "pagosDataGridView";
            this.pagosDataGridView.ReadOnly = true;
            this.pagosDataGridView.RowHeadersVisible = false;
            this.pagosDataGridView.Size = new System.Drawing.Size(836, 176);
            this.pagosDataGridView.TabIndex = 0;
            // 
            // pagoId
            // 
            this.pagoId.DataPropertyName = "idCobro";
            this.pagoId.HeaderText = "ID Pago";
            this.pagoId.Name = "pagoId";
            this.pagoId.ReadOnly = true;
            this.pagoId.Width = 80;
            // 
            // pagoFecha
            // 
            this.pagoFecha.DataPropertyName = "fecha";
            this.pagoFecha.HeaderText = "Fecha";
            this.pagoFecha.Name = "pagoFecha";
            this.pagoFecha.ReadOnly = true;
            this.pagoFecha.Width = 120;
            // 
            // pagoDesc
            // 
            this.pagoDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pagoDesc.DataPropertyName = "descripcion";
            this.pagoDesc.HeaderText = "Descripción";
            this.pagoDesc.Name = "pagoDesc";
            this.pagoDesc.ReadOnly = true;
            // 
            // pagoMonto
            // 
            this.pagoMonto.DataPropertyName = "monto";
            this.pagoMonto.HeaderText = "Monto";
            this.pagoMonto.Name = "pagoMonto";
            this.pagoMonto.ReadOnly = true;
            this.pagoMonto.Width = 120;
            // 
            // cardDeuda
            // 
            this.cardDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.cardDeuda.Controls.Add(this.lblDeuda);
            this.cardDeuda.Controls.Add(this.lblDeudaTitle);
            this.cardDeuda.Location = new System.Drawing.Point(580, 20);
            this.cardDeuda.Name = "cardDeuda";
            this.cardDeuda.Size = new System.Drawing.Size(290, 80);
            this.cardDeuda.TabIndex = 9;
            // 
            // lblDeuda
            // 
            this.lblDeuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeuda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblDeuda.Location = new System.Drawing.Point(0, 30);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(290, 50);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "$ 0";
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeudaTitle
            // 
            this.lblDeudaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeudaTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDeudaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDeudaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDeudaTitle.Name = "lblDeudaTitle";
            this.lblDeudaTitle.Size = new System.Drawing.Size(290, 30);
            this.lblDeudaTitle.TabIndex = 0;
            this.lblDeudaTitle.Text = "DEUDA TOTAL REGISTRADA (ARS)";
            this.lblDeudaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardDesglose
            // 
            this.cardDesglose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardDesglose.Controls.Add(this.USStextBox);
            this.cardDesglose.Controls.Add(this.lblUss);
            this.cardDesglose.Controls.Add(this.masVentiunTextBox);
            this.cardDesglose.Controls.Add(this.lblMas21);
            this.cardDesglose.Controls.Add(this.ventiunTextBox);
            this.cardDesglose.Controls.Add(this.lbl21);
            this.cardDesglose.Controls.Add(this.catorceTextBox);
            this.cardDesglose.Controls.Add(this.lbl14);
            this.cardDesglose.Controls.Add(this.sieteTextBox);
            this.cardDesglose.Controls.Add(this.lbl7);
            this.cardDesglose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cardDesglose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.cardDesglose.Location = new System.Drawing.Point(580, 110);
            this.cardDesglose.Name = "cardDesglose";
            this.cardDesglose.Size = new System.Drawing.Size(290, 110);
            this.cardDesglose.TabIndex = 8;
            this.cardDesglose.TabStop = false;
            this.cardDesglose.Text = "Desglose de Saldos";
            // 
            // USStextBox
            // 
            this.USStextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.USStextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USStextBox.ForeColor = System.Drawing.Color.White;
            this.USStextBox.Location = new System.Drawing.Point(125, 75);
            this.USStextBox.Name = "USStextBox";
            this.USStextBox.Size = new System.Drawing.Size(70, 23);
            this.USStextBox.TabIndex = 9;
            this.USStextBox.Text = "0";
            // 
            // lblUss
            // 
            this.lblUss.AutoSize = true;
            this.lblUss.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblUss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblUss.Location = new System.Drawing.Point(125, 60);
            this.lblUss.Name = "lblUss";
            this.lblUss.Size = new System.Drawing.Size(63, 13);
            this.lblUss.TabIndex = 8;
            this.lblUss.Text = "Deuda USD";
            // 
            // masVentiunTextBox
            // 
            this.masVentiunTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.masVentiunTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masVentiunTextBox.ForeColor = System.Drawing.Color.White;
            this.masVentiunTextBox.Location = new System.Drawing.Point(20, 75);
            this.masVentiunTextBox.Name = "masVentiunTextBox";
            this.masVentiunTextBox.Size = new System.Drawing.Size(70, 23);
            this.masVentiunTextBox.TabIndex = 7;
            this.masVentiunTextBox.Text = "0";
            // 
            // lblMas21
            // 
            this.lblMas21.AutoSize = true;
            this.lblMas21.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblMas21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblMas21.Location = new System.Drawing.Point(20, 60);
            this.lblMas21.Name = "lblMas21";
            this.lblMas21.Size = new System.Drawing.Size(51, 13);
            this.lblMas21.TabIndex = 6;
            this.lblMas21.Text = "+21 Días";
            // 
            // ventiunTextBox
            // 
            this.ventiunTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ventiunTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventiunTextBox.ForeColor = System.Drawing.Color.White;
            this.ventiunTextBox.Location = new System.Drawing.Point(200, 33);
            this.ventiunTextBox.Name = "ventiunTextBox";
            this.ventiunTextBox.Size = new System.Drawing.Size(70, 23);
            this.ventiunTextBox.TabIndex = 5;
            this.ventiunTextBox.Text = "0";
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lbl21.Location = new System.Drawing.Point(200, 18);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(43, 13);
            this.lbl21.TabIndex = 4;
            this.lbl21.Text = "21 Días";
            // 
            // catorceTextBox
            // 
            this.catorceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.catorceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catorceTextBox.ForeColor = System.Drawing.Color.White;
            this.catorceTextBox.Location = new System.Drawing.Point(110, 33);
            this.catorceTextBox.Name = "catorceTextBox";
            this.catorceTextBox.Size = new System.Drawing.Size(70, 23);
            this.catorceTextBox.TabIndex = 3;
            this.catorceTextBox.Text = "0";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lbl14.Location = new System.Drawing.Point(110, 18);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(43, 13);
            this.lbl14.TabIndex = 2;
            this.lbl14.Text = "14 Días";
            // 
            // sieteTextBox
            // 
            this.sieteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.sieteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sieteTextBox.ForeColor = System.Drawing.Color.White;
            this.sieteTextBox.Location = new System.Drawing.Point(20, 33);
            this.sieteTextBox.Name = "sieteTextBox";
            this.sieteTextBox.Size = new System.Drawing.Size(70, 23);
            this.sieteTextBox.TabIndex = 1;
            this.sieteTextBox.Text = "0";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lbl7.Location = new System.Drawing.Point(20, 18);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(37, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "7 Días";
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtCuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuil.ForeColor = System.Drawing.Color.White;
            this.txtCuil.Location = new System.Drawing.Point(300, 145);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(250, 23);
            this.txtCuil.TabIndex = 7;
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblCuil.Location = new System.Drawing.Point(300, 125);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(32, 15);
            this.lblCuil.TabIndex = 6;
            this.lblCuil.Text = "CUIL";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(20, 145);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDireccion.Location = new System.Drawing.Point(20, 125);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(300, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblApellido.Location = new System.Drawing.Point(300, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(20, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // FormFichaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.panelFicha);
            this.Controls.Add(this.buscadorComboBox);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFichaCliente";
            this.Text = "Ficha Cliente";
            this.Load += new System.EventHandler(this.FormFichaCliente_Load);
            this.panelFicha.ResumeLayout(false);
            this.panelFicha.PerformLayout();
            this.tabControlFicha.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.tabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagosDataGridView)).EndInit();
            this.cardDeuda.ResumeLayout(false);
            this.cardDesglose.ResumeLayout(false);
            this.cardDesglose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.ComboBox buscadorComboBox;
        private System.Windows.Forms.Panel panelFicha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.GroupBox cardDesglose;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox sieteTextBox;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.TextBox catorceTextBox;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.TextBox ventiunTextBox;
        private System.Windows.Forms.Label lblMas21;
        private System.Windows.Forms.TextBox masVentiunTextBox;
        private System.Windows.Forms.Label lblUss;
        private System.Windows.Forms.TextBox USStextBox;
        private System.Windows.Forms.Panel cardDeuda;
        private System.Windows.Forms.Label lblDeudaTitle;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.TabControl tabControlFicha;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button deudorButton;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button nuevaVentaButton;
        private System.Windows.Forms.Button nuevoPagoButton;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridView pagosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoMonto;
    }
}
