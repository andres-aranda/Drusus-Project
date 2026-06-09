namespace DrususV2
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSubasta = new FontAwesome.Sharp.IconButton();
            this.btnGastos = new FontAwesome.Sharp.IconButton();
            this.panelCobros = new System.Windows.Forms.Panel();
            this.btnNuevoCobro = new FontAwesome.Sharp.IconButton();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnListaVentas = new FontAwesome.Sharp.IconButton();
            this.btnNuevaVenta = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnListaClientes = new FontAwesome.Sharp.IconButton();
            this.btnFichaCliente = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMenuToggle = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelCobros.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.iconButtonSubasta);
            this.panelMenu.Controls.Add(this.btnGastos);
            this.panelMenu.Controls.Add(this.panelCobros);
            this.panelMenu.Controls.Add(this.btnCobros);
            this.panelMenu.Controls.Add(this.panelVentas);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.panelClientes);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonSubasta
            // 
            this.iconButtonSubasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSubasta.FlatAppearance.BorderSize = 0;
            this.iconButtonSubasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSubasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSubasta.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.iconButtonSubasta.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSubasta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSubasta.IconSize = 32;
            this.iconButtonSubasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSubasta.Location = new System.Drawing.Point(0, 570);
            this.iconButtonSubasta.Name = "iconButtonSubasta";
            this.iconButtonSubasta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSubasta.Size = new System.Drawing.Size(230, 50);
            this.iconButtonSubasta.TabIndex = 9;
            this.iconButtonSubasta.Text = "Subasta";
            this.iconButtonSubasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSubasta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSubasta.UseVisualStyleBackColor = true;
            this.iconButtonSubasta.Click += new System.EventHandler(this.btnSubasta_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGastos.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnGastos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGastos.IconSize = 32;
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 520);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGastos.Size = new System.Drawing.Size(230, 50);
            this.btnGastos.TabIndex = 8;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // panelCobros
            // 
            this.panelCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.panelCobros.Controls.Add(this.btnNuevoCobro);
            this.panelCobros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCobros.Location = new System.Drawing.Point(0, 470);
            this.panelCobros.Name = "panelCobros";
            this.panelCobros.Size = new System.Drawing.Size(230, 50);
            this.panelCobros.TabIndex = 7;
            // 
            // btnNuevoCobro
            // 
            this.btnNuevoCobro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoCobro.FlatAppearance.BorderSize = 0;
            this.btnNuevoCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCobro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCobro.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.btnNuevoCobro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCobro.IconSize = 24;
            this.btnNuevoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCobro.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoCobro.Name = "btnNuevoCobro";
            this.btnNuevoCobro.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnNuevoCobro.Size = new System.Drawing.Size(230, 40);
            this.btnNuevoCobro.TabIndex = 0;
            this.btnNuevoCobro.Text = "Nuevo Cobro";
            this.btnNuevoCobro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCobro.UseVisualStyleBackColor = true;
            this.btnNuevoCobro.Click += new System.EventHandler(this.btnNuevoCobro_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCobros.FlatAppearance.BorderSize = 0;
            this.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.HandHoldingDollar;
            this.btnCobros.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobros.IconSize = 32;
            this.btnCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.Location = new System.Drawing.Point(0, 420);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCobros.Size = new System.Drawing.Size(230, 50);
            this.btnCobros.TabIndex = 6;
            this.btnCobros.Text = "Cobros";
            this.btnCobros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobros.UseVisualStyleBackColor = true;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.panelVentas.Controls.Add(this.btnListaVentas);
            this.panelVentas.Controls.Add(this.btnNuevaVenta);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 335);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(230, 85);
            this.panelVentas.TabIndex = 5;
            // 
            // btnListaVentas
            // 
            this.btnListaVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaVentas.FlatAppearance.BorderSize = 0;
            this.btnListaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListaVentas.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListaVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListaVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListaVentas.IconSize = 24;
            this.btnListaVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaVentas.Location = new System.Drawing.Point(0, 40);
            this.btnListaVentas.Name = "btnListaVentas";
            this.btnListaVentas.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnListaVentas.Size = new System.Drawing.Size(230, 40);
            this.btnListaVentas.TabIndex = 1;
            this.btnListaVentas.Text = "Lista Ventas";
            this.btnListaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaVentas.UseVisualStyleBackColor = true;
            this.btnListaVentas.Click += new System.EventHandler(this.btnListaVentas_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNuevaVenta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaVenta.IconSize = 24;
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnNuevaVenta.Size = new System.Drawing.Size(230, 40);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 285);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(230, 50);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.panelClientes.Controls.Add(this.btnListaClientes);
            this.panelClientes.Controls.Add(this.btnFichaCliente);
            this.panelClientes.Controls.Add(this.btnAgregarCliente);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.Location = new System.Drawing.Point(0, 160);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(230, 125);
            this.panelClientes.TabIndex = 3;
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaClientes.FlatAppearance.BorderSize = 0;
            this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListaClientes.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            this.btnListaClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListaClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListaClientes.IconSize = 24;
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(0, 80);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnListaClientes.Size = new System.Drawing.Size(230, 40);
            this.btnListaClientes.TabIndex = 2;
            this.btnListaClientes.Text = "Lista Clientes";
            this.btnListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnFichaCliente
            // 
            this.btnFichaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFichaCliente.FlatAppearance.BorderSize = 0;
            this.btnFichaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFichaCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnFichaCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFichaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFichaCliente.IconSize = 24;
            this.btnFichaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaCliente.Location = new System.Drawing.Point(0, 40);
            this.btnFichaCliente.Name = "btnFichaCliente";
            this.btnFichaCliente.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnFichaCliente.Size = new System.Drawing.Size(230, 40);
            this.btnFichaCliente.TabIndex = 1;
            this.btnFichaCliente.Text = "Ficha Cliente";
            this.btnFichaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFichaCliente.UseVisualStyleBackColor = true;
            this.btnFichaCliente.Click += new System.EventHandler(this.btnFichaCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.IconSize = 24;
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnAgregarCliente.Size = new System.Drawing.Size(230, 40);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 110);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Size = new System.Drawing.Size(230, 50);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 32;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 60);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicio.Size = new System.Drawing.Size(230, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(45, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMenuToggle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(970, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMenuToggle
            // 
            this.btnMenuToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuToggle.FlatAppearance.BorderSize = 0;
            this.btnMenuToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuToggle.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenuToggle.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMenuToggle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuToggle.IconSize = 22;
            this.btnMenuToggle.Location = new System.Drawing.Point(10, 15);
            this.btnMenuToggle.Name = "btnMenuToggle";
            this.btnMenuToggle.Size = new System.Drawing.Size(30, 30);
            this.btnMenuToggle.TabIndex = 5;
            this.btnMenuToggle.UseVisualStyleBackColor = false;
            this.btnMenuToggle.Click += new System.EventHandler(this.btnMenuToggle_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 16;
            this.btnMinimize.Location = new System.Drawing.Point(865, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 16;
            this.btnMaximize.Location = new System.Drawing.Point(900, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 16;
            this.btnExit.Location = new System.Drawing.Point(935, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(88, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(50, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(970, 660);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drusus Admin V2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelCobros.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.Panel panelClientes;
        private FontAwesome.Sharp.IconButton btnListaClientes;
        private FontAwesome.Sharp.IconButton btnFichaCliente;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private System.Windows.Forms.Panel panelVentas;
        private FontAwesome.Sharp.IconButton btnListaVentas;
        private FontAwesome.Sharp.IconButton btnNuevaVenta;
        private FontAwesome.Sharp.IconButton btnVentas;
        private System.Windows.Forms.Panel panelCobros;
        private FontAwesome.Sharp.IconButton btnNuevoCobro;
        private FontAwesome.Sharp.IconButton btnCobros;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton iconButtonSubasta;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMenuToggle;
    }
}
