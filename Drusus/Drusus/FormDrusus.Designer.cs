namespace Drusus
{
    partial class FormDrusus
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrusus));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGastos = new FontAwesome.Sharp.IconButton();
            this.panelCobros = new System.Windows.Forms.Panel();
            this.btnNuevoCobro = new FontAwesome.Sharp.IconButton();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnSubasta = new FontAwesome.Sharp.IconButton();
            this.btnNuevaVenta = new FontAwesome.Sharp.IconButton();
            this.btnListaVentas = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnFichaCliente = new FontAwesome.Sharp.IconButton();
            this.btnListaClientes = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarraDeTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelCobros.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
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
            this.panelMenu.Size = new System.Drawing.Size(250, 472);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGastos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnGastos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGastos.IconSize = 35;
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 702);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGastos.Rotation = 0D;
            this.btnGastos.Size = new System.Drawing.Size(233, 60);
            this.btnGastos.TabIndex = 16;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click_1);
            // 
            // panelCobros
            // 
            this.panelCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panelCobros.Controls.Add(this.btnNuevoCobro);
            this.panelCobros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCobros.Location = new System.Drawing.Point(0, 658);
            this.panelCobros.Name = "panelCobros";
            this.panelCobros.Size = new System.Drawing.Size(233, 44);
            this.panelCobros.TabIndex = 15;
            // 
            // btnNuevoCobro
            // 
            this.btnNuevoCobro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoCobro.FlatAppearance.BorderSize = 0;
            this.btnNuevoCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCobro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevoCobro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCobro.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnNuevoCobro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCobro.IconSize = 25;
            this.btnNuevoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCobro.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoCobro.Name = "btnNuevoCobro";
            this.btnNuevoCobro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevoCobro.Rotation = 0D;
            this.btnNuevoCobro.Size = new System.Drawing.Size(233, 40);
            this.btnNuevoCobro.TabIndex = 15;
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
            this.btnCobros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCobros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.btnCobros.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCobros.IconSize = 35;
            this.btnCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.Location = new System.Drawing.Point(0, 598);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCobros.Rotation = 0D;
            this.btnCobros.Size = new System.Drawing.Size(233, 60);
            this.btnCobros.TabIndex = 14;
            this.btnCobros.Text = "Cobros";
            this.btnCobros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobros.UseVisualStyleBackColor = true;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click_1);
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panelVentas.Controls.Add(this.btnSubasta);
            this.panelVentas.Controls.Add(this.btnNuevaVenta);
            this.panelVentas.Controls.Add(this.btnListaVentas);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 476);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(233, 122);
            this.panelVentas.TabIndex = 12;
            // 
            // btnSubasta
            // 
            this.btnSubasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubasta.FlatAppearance.BorderSize = 0;
            this.btnSubasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubasta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSubasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubasta.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.btnSubasta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSubasta.IconSize = 25;
            this.btnSubasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubasta.Location = new System.Drawing.Point(0, 80);
            this.btnSubasta.Name = "btnSubasta";
            this.btnSubasta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSubasta.Rotation = 0D;
            this.btnSubasta.Size = new System.Drawing.Size(233, 40);
            this.btnSubasta.TabIndex = 14;
            this.btnSubasta.Text = "Subasta";
            this.btnSubasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubasta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubasta.UseVisualStyleBackColor = true;
            this.btnSubasta.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaVenta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevaVenta.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaVenta.IconSize = 25;
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 40);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevaVenta.Rotation = 0D;
            this.btnNuevaVenta.Size = new System.Drawing.Size(233, 40);
            this.btnNuevaVenta.TabIndex = 13;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnListaVentas
            // 
            this.btnListaVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaVentas.FlatAppearance.BorderSize = 0;
            this.btnListaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListaVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListaVentas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnListaVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListaVentas.IconSize = 25;
            this.btnListaVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaVentas.Location = new System.Drawing.Point(0, 0);
            this.btnListaVentas.Name = "btnListaVentas";
            this.btnListaVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListaVentas.Rotation = 0D;
            this.btnListaVentas.Size = new System.Drawing.Size(233, 40);
            this.btnListaVentas.TabIndex = 12;
            this.btnListaVentas.Text = "Lista de ventas";
            this.btnListaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaVentas.UseVisualStyleBackColor = true;
            this.btnListaVentas.Click += new System.EventHandler(this.btnListaVentas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconSize = 35;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 416);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(233, 60);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click_1);
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panelClientes.Controls.Add(this.btnAgregar);
            this.panelClientes.Controls.Add(this.btnFichaCliente);
            this.panelClientes.Controls.Add(this.btnListaClientes);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.Location = new System.Drawing.Point(0, 290);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(233, 126);
            this.panelClientes.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgregar.Rotation = 0D;
            this.btnAgregar.Size = new System.Drawing.Size(233, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFichaCliente
            // 
            this.btnFichaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFichaCliente.FlatAppearance.BorderSize = 0;
            this.btnFichaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFichaCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFichaCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnFichaCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFichaCliente.IconSize = 25;
            this.btnFichaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaCliente.Location = new System.Drawing.Point(0, 40);
            this.btnFichaCliente.Name = "btnFichaCliente";
            this.btnFichaCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFichaCliente.Rotation = 0D;
            this.btnFichaCliente.Size = new System.Drawing.Size(233, 40);
            this.btnFichaCliente.TabIndex = 5;
            this.btnFichaCliente.Text = "Buscar ficha";
            this.btnFichaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFichaCliente.UseVisualStyleBackColor = true;
            this.btnFichaCliente.Click += new System.EventHandler(this.btnFichaCliente_Click);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaClientes.FlatAppearance.BorderSize = 0;
            this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListaClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListaClientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnListaClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListaClientes.IconSize = 25;
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(0, 0);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListaClientes.Rotation = 0D;
            this.btnListaClientes.Size = new System.Drawing.Size(233, 40);
            this.btnListaClientes.TabIndex = 4;
            this.btnListaClientes.Text = "Lista de clientes";
            this.btnListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 230);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(233, 60);
            this.btnClientes.TabIndex = 3;
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
            this.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconSize = 35;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 170);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicio.Rotation = 0D;
            this.btnInicio.Size = new System.Drawing.Size(233, 60);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drusus.Properties.Resources.grifo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelBarraDeTitulo
            // 
            this.panelBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.panelBarraDeTitulo.Controls.Add(this.btnMinimize);
            this.panelBarraDeTitulo.Controls.Add(this.btnMaximize);
            this.panelBarraDeTitulo.Controls.Add(this.btnExit);
            this.panelBarraDeTitulo.Controls.Add(this.lblTitleChildForm);
            this.panelBarraDeTitulo.Controls.Add(this.iconCurrentChildForm);
            this.panelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraDeTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelBarraDeTitulo.Name = "panelBarraDeTitulo";
            this.panelBarraDeTitulo.Size = new System.Drawing.Size(734, 75);
            this.panelBarraDeTitulo.TabIndex = 1;
            this.panelBarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraDeTitulo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 17;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(636, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(37, 24);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconSize = 17;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.Location = new System.Drawing.Point(662, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(44, 22);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 17;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(691, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(56, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(66, 35);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(32, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(250, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(734, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(734, 388);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormDrusus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 472);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelBarraDeTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDrusus";
            this.Text = "Panel Drusus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDrusus_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelCobros.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraDeTitulo.ResumeLayout(false);
            this.panelBarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBarraDeTitulo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelClientes;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnFichaCliente;
        private FontAwesome.Sharp.IconButton btnListaClientes;
        private System.Windows.Forms.Panel panelVentas;
        private FontAwesome.Sharp.IconButton btnNuevaVenta;
        private FontAwesome.Sharp.IconButton btnListaVentas;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnGastos;
        private System.Windows.Forms.Panel panelCobros;
        private FontAwesome.Sharp.IconButton btnNuevoCobro;
        private FontAwesome.Sharp.IconButton btnCobros;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSubasta;
    }
}

